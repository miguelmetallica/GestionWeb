using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Aplicacion.Clientes
{
    using Dominio;
    using FluentValidation;
    using Persistencia.DapperConexion.Cliente;
    using System.Collections.Generic;

    public class Nuevo
    {
        public class Ejecuta : IRequest 
        {
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public string RazonSocial { get; set; }
            public string TipoDocumentoId { get; set; }
            public string NroDocumento { get; set; }
            public string CuilCuit { get; set; }
            public string Foto { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string EstadoCivilId { get; set; }
            public string NacionalidadId { get; set; }
            public bool EsPersonaJuridica { get; set; }
            public string ProvinciaId { get; set; }
            public string Localidad { get; set; }
            public string CodigoPostal { get; set; }
            public string Calle { get; set; }
            public string CalleNro { get; set; }
            public string PisoDpto { get; set; }
            public string OtrasReferencias { get; set; }
            public string Telefono { get; set; }
            public string Celular { get; set; }
            public string Email { get; set; }
            public bool Estado { get; set; }
            public string UsuarioAlta { get; set; }             
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta> {
            public EjecutaValidacion()
            {
                RuleFor(x => x.Apellido).NotEmpty();
            }
        }
        
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly ICliente cliente;

            public Manejador(ICliente cliente)
            {
                this.cliente = cliente;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var parametros = new  Dictionary<string, object>();
                        parametros.Add("@Id", Guid.NewGuid().ToString());
                        parametros.Add("@Apellido", request.Apellido);
                        parametros.Add("@Nombre", request.Nombre);
                        parametros.Add("@TipoDocumentoId", request.TipoDocumentoId);
                        parametros.Add("@NroDocumento", request.NroDocumento);
                        parametros.Add("@CuilCuit", request.CuilCuit);
                        parametros.Add("@FechaNacimiento", request.FechaNacimiento);
                        parametros.Add("@EstadoCivilId", request.EstadoCivilId);
                        parametros.Add("@NacionalidadId", request.NacionalidadId);
                        parametros.Add("@ProvinciaId", request.ProvinciaId);
                        parametros.Add("@Localidad", request.Localidad);
                        parametros.Add("@CodigoPostal", request.CodigoPostal);
                        parametros.Add("@Calle", request.Calle);
                        parametros.Add("@CalleNro", request.CalleNro);
                        parametros.Add("@PisoDpto", request.PisoDpto);
                        parametros.Add("@OtrasReferencias", request.OtrasReferencias);
                        parametros.Add("@Telefono", request.Telefono);
                        parametros.Add("@Celular", request.Celular);
                        parametros.Add("@Email", request.Email);
                        parametros.Add("@Estado", request.Estado);
                        parametros.Add("@Usuario", request.UsuarioAlta);

                var result = await cliente.NuevoSP(parametros);

                if (result > 0) {
                    return Unit.Value;
                }
                throw new Exception("No se pudo insertar el registro");


            }
        }

    }
}
 