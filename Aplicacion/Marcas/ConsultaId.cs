using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Marcas
{
    using Aplicacion.ManejadorError;
    using Dominio;
    using System.Net;

    public class ConsultaId
    {
        public class Unico : IRequest<Marcas>
        {
            public string Id { get; set; }
        }

        public class Manejador : IRequestHandler<Unico, Marcas>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public async Task<Marcas> Handle(Unico request, CancellationToken cancellationToken)
            {
                var marcas = await context.paramMarcas.FindAsync(request.Id);
                if (marcas == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                return marcas;
            }
        }

    }
}
