using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Categorias
{
    using Aplicacion.ManejadorError;
    using System.Net;

    public class Eliminar
    {
        public class Ejecuta : IRequest 
        {
            public string Id { get; set; }
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
                if (categorias == null) {                    
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                context.paramCategorias.Remove(categorias);
                var result = await context.SaveChangesAsync();
                if (result > 0) {
                    return Unit.Value;
                }

                throw new ManejadorException(HttpStatusCode.BadRequest, new { mensaje = "No se pudo eliminar el registro" });
            }
        }

    }
}
