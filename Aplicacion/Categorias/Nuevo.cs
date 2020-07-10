using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Aplicacion.Categorias
{
    using Dominio;
    using FluentValidation;

    public class Nuevo
    {
        public class Ejecuta : IRequest 
        {
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public string ParentId { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta> {
            public EjecutaValidacion()
            {
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
                var categorias = new Categorias {
                                            Id = Guid.NewGuid().ToString(),
                                            Codigo = request.Codigo,
                                            Descripcion = request.Descripcion,
                                            ParentId = request.ParentId ?? request.ParentId,
                                            Estado = true
                                            };

                context.paramCategorias.Add(categorias);
                var result = await context.SaveChangesAsync();
                if (result > 0) {
                    return Unit.Value;
                }
                throw new Exception("No se pudo insertar el registro");
            }
        }

    }
}
 