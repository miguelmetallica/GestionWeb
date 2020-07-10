using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Etiquetas
{
    using Aplicacion.ManejadorError;
    using Dominio;
    using System.Net;

    public class ConsultaId
    {
        public class Unico : IRequest<Etiquetas>
        {
            public string Id { get; set; }
        }

        public class Manejador : IRequestHandler<Unico, Etiquetas>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public async Task<Etiquetas> Handle(Unico request, CancellationToken cancellationToken)
            {
                var etiquetas = await context.paramEtiquetas.FindAsync(request.Id);
                if (etiquetas == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                return etiquetas;
            }
        }

    }
}
