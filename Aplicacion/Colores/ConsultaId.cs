using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Colores
{
    using Aplicacion.ManejadorError;
    using Dominio;
    using System.Net;

    public class ConsultaId
    {
        public class Unico : IRequest<Colores>
        {
            public string Id { get; set; }
        }

        public class Manejador : IRequestHandler<Unico, Colores>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public async Task<Colores> Handle(Unico request, CancellationToken cancellationToken)
            {
                var colores = await context.paramColores.FindAsync(request.Id);
                if (colores == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                return colores;
            }
        }

    }
}
