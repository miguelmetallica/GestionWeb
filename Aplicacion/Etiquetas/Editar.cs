using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Aplicacion.Etiquetas
{
    using Aplicacion.ManejadorError;
    using Dominio;
    using FluentValidation;
    using System.Net;

    public class Editar
    {
        public class Ejecuta : IRequest 
        {
            public string Id { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public bool Estado { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.Id).NotEmpty();
                RuleFor(x => x.Codigo).NotEmpty();
                RuleFor(x => x.Descripcion).NotEmpty();
            }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var etiquetas = await context.paramEtiquetas.FindAsync(request.Id);
                if (etiquetas == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                etiquetas.Codigo = request.Codigo ?? etiquetas.Codigo;
                etiquetas.Descripcion = request.Descripcion ?? etiquetas.Descripcion;
                etiquetas.Estado = request.Estado;
                
                context.paramEtiquetas.Update(etiquetas);
                var result = await context.SaveChangesAsync();
                if (result > 0) {
                    return Unit.Value;
                }

                throw new Exception("No se pudo editar el registro");
            }
        }

    }
}
