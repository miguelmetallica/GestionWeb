using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Aplicacion.Categorias
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
            public string ParentId { get; set; }
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
                var categorias = await context.paramCategorias.FindAsync(request.Id);
                if (categorias == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                categorias.Codigo = request.Codigo ?? categorias.Codigo;
                categorias.Descripcion = request.Descripcion ?? categorias.Descripcion;
                categorias.ParentId = request.ParentId ?? categorias.ParentId;
                categorias.Estado = request.Estado;
                
                context.paramCategorias.Update(categorias);
                var result = await context.SaveChangesAsync();
                if (result > 0) {
                    return Unit.Value;
                }

                throw new Exception("No se pudo editar el registro");
            }
        }

    }
}