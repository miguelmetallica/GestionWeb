using Aplicacion.JWT;
using Aplicacion.ManejadorError;
using Dominio;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Seguridad
{
    public class Registrar
    {
        public class Ejecuta : IRequest<UsuarioData>
        {
            public string NombreCompleto { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string UserName { get; set; }
            public string SucursalId { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.NombreCompleto).NotEmpty();
                RuleFor(x => x.Email).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
                RuleFor(x => x.UserName).NotEmpty();
                RuleFor(x => x.SucursalId).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<Ejecuta, UsuarioData> 
        {
            private readonly GestionContext context;
            private readonly UserManager<Usuarios> userManager;
            private readonly IJwtGenerador jwtGenerador;

            public Manejador(GestionContext context,UserManager<Usuarios> userManager, IJwtGenerador jwtGenerador) 
            {
                this.context = context;
                this.userManager = userManager;
                this.jwtGenerador = jwtGenerador;
            }

            public async Task<UsuarioData> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var existeEmail = await context.Users.Where(x => x.Email == request.Email).AnyAsync();
                if(existeEmail) {
                    throw new ManejadorException(HttpStatusCode.BadRequest, new { mensaje = "Existe ya un usuario registrado con ese Email" });
                }

                var existeUser = await context.Users.Where(x => x.UserName == request.UserName).AnyAsync();
                if (existeUser)
                {
                    throw new ManejadorException(HttpStatusCode.BadRequest, new { mensaje = "Existe ya un usuario registrado con ese UserName" });
                }

                var usuario = new Usuarios
                {
                    NombreCompleto = request.NombreCompleto,
                    UserName = request.UserName,
                    Email = request.Email,
                    SucursalId = request.SucursalId
                };

                var result = await userManager.CreateAsync(usuario, request.Password);
                if (result.Succeeded)
                {
                    return new UsuarioData
                    {
                        NombreCompleto = usuario.NombreCompleto,
                        Token = jwtGenerador.CrearToken(usuario, null),
                        Username = usuario.UserName,
                        Email = usuario.Email,
                        Imagen = null,
                        SucursalId = usuario.SucursalId,
                        sucursalesDTO = context.sucursales
                                    .Where(c => c.Id == usuario.SucursalId)
                                    .Select(c => new SucursalesDTO { Id = c.Id,
                                                                    Codigo = c.Codigo,
                                                                    Nombre = c.Nombre,
                                                                    ProvinciaId = c.ProvinciaId,
                                                                    Localidad = c.Localidad,
                                                                    CodigoPostal = c.CodigoPostal,
                                                                    Calle = c.Calle,
                                                                    NroCalle = c.NroCalle,
                                                                    PisoDpto = c.PisoDpto,
                                                                    OtrasReferencias = c.OtrasReferencias,
                                                                    Estado = c.Estado }).FirstOrDefault()
                    };
                }

                throw new Exception("No se pudo agregar al Usuario");

            }
        }

    }
}
