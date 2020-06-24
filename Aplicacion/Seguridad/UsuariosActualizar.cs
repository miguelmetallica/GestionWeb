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
    public class UsuariosActualizar
    {
        public class Ejecuta : IRequest<UsuarioData>
        {
            public string NombreCompleto { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Username { get; set; }

        }

        public class ValidarEjecuta : AbstractValidator<Ejecuta> 
        {
            public ValidarEjecuta()
            {
                RuleFor(x => x.NombreCompleto).NotEmpty();
                RuleFor(x => x.Email).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
                RuleFor(x => x.Username).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<Ejecuta, UsuarioData>
        {
            private readonly GestionContext gestionContext;
            private readonly UserManager<Usuarios> userManager;
            private readonly IJwtGenerador jwtGenerador;
            private IPasswordHasher<Usuarios> passwordHasher;

            public Manejador(GestionContext gestionContext, UserManager<Usuarios> userManager, IJwtGenerador jwtGenerador, IPasswordHasher<Usuarios> passwordHasher)
            {
                this.gestionContext = gestionContext;
                this.userManager = userManager;
                this.jwtGenerador = jwtGenerador;
                this.passwordHasher= passwordHasher;
            }
            
            public async Task<UsuarioData> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var usuario = await userManager.FindByNameAsync(request.Username);
                if (usuario == null) 
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new {mensaje = "El usuario no existe"});
                }

                var existeEmail = await gestionContext.Users.Where(x => x.Email == request.Email && x.UserName != request.Username).AnyAsync();
                if (existeEmail)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El email pertenece a otro usuario" });
                }

                usuario.NombreCompleto = request.NombreCompleto;
                usuario.PasswordHash = passwordHasher.HashPassword(usuario, request.Password);
                usuario.Email = request.Email;

                var resultRoles = await userManager.GetRolesAsync(usuario);
                var listaRoles = new List<string>(resultRoles);

                var updateUsuario = await userManager.UpdateAsync(usuario);
                if (updateUsuario.Succeeded) {
                    return new UsuarioData
                    {
                        NombreCompleto = usuario.NombreCompleto,
                        Username = usuario.UserName,
                        Email = usuario.Email,
                        Token = jwtGenerador.CrearToken(usuario, listaRoles),
                        Imagen = null
                    };
                }

                throw new ManejadorException(HttpStatusCode.BadRequest, new { mensaje = "no se puede actualizar el usuario" });

            }

            
        }
    }
}
