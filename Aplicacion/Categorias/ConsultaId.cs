using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Categorias
{
    using Aplicacion.ManejadorError;
    using Dominio;
    using System.Net;

    public class ConsultaId
    {
        public class Unico : IRequest<Categorias>
        {
            public string Id { get; set; }
        }

        public class Manejador : IRequestHandler<Unico, Categorias>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public async Task<Categorias> Handle(Unico request, CancellationToken cancellationToken)
            {
                var categorias = await context.paramCategorias.FindAsync(request.Id);
                if (categorias == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                return categorias;
            }
        }

    }
}
