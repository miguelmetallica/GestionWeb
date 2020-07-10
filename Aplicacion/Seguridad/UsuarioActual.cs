using Aplicacion.JWT;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Seguridad
{
    public class UsuarioActual
    {
        public class Ejecutar : IRequest<UsuarioData> {}

        public class Manejador : IRequestHandler<Ejecutar, UsuarioData>
        {
            private readonly GestionContext context;
            private readonly UserManager<Usuarios> userManager;
            private readonly IJwtGenerador jwtGenerador;
            private readonly IUsuarioSesion usuarioSesion;

            public Manejador(GestionContext context, UserManager<Usuarios> userManager,IJwtGenerador jwtGenerador,IUsuarioSesion usuarioSesion)
            {
                this.context = context;
                this.userManager = userManager;
                this.jwtGenerador = jwtGenerador;
                this.usuarioSesion = usuarioSesion;
            }
            public async Task<UsuarioData> Handle(Ejecutar request, CancellationToken cancellationToken)
            {
                var usuario = await userManager.FindByEmailAsync(usuarioSesion.ObtenerUsuarioSesion());
                var resultadoRoles = await userManager.GetRolesAsync(usuario);
                var listaRoles = new List<string>(resultadoRoles);
                
                return new UsuarioData
                {
                    NombreCompleto = usuario.NombreCompleto,
                    Username = usuario.UserName,
                    Token = jwtGenerador.CrearToken(usuario, listaRoles),
                    Imagen = null,
                    Email = usuario.Email,
                    SucursalId = usuario.SucursalId,
                    sucursalesDTO = context.sucursales
                                    .Where(c => c.Id == usuario.SucursalId)
                                    .Select(c => new SucursalesDTO
                                    {
                                        Id = c.Id,
                                        Codigo = c.Codigo,
                                        Nombre = c.Nombre,
                                        ProvinciaId = c.ProvinciaId,
                                        Localidad = c.Localidad,
                                        CodigoPostal = c.CodigoPostal,
                                        Calle = c.Calle,
                                        NroCalle = c.NroCalle,
                                        PisoDpto = c.PisoDpto,
                                        OtrasReferencias = c.OtrasReferencias,
                                        Estado = c.Estado
                                    }).FirstOrDefault()
                };
            }
        }

    }
}
