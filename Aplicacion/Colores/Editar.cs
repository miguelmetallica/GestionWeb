using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Aplicacion.Colores
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
            public string Color { get; set; }
            public bool Estado { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.Id).NotEmpty();
                RuleFor(x => x.Codigo).NotEmpty();
                RuleFor(x => x.Descripcion).NotEmpty();
                RuleFor(x => x.Color).NotEmpty();
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
                var colores = await context.paramColores.FindAsync(request.Id);
                if (colores == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                colores.Codigo = request.Codigo ?? colores.Codigo;
                colores.Descripcion = request.Descripcion ?? colores.Descripcion;
                colores.Color = request.Color ?? colores.Color;
                colores.Estado = request.Estado;
                
                context.paramColores.Update(colores);
                var result = await context.SaveChangesAsync();
                if (result > 0) {
                    return Unit.Value;
                }

                throw new Exception("No se pudo editar el registro");
            }
        }

    }
}
