using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.EstadosInventario
{
    using Aplicacion.ManejadorError;
    using Dominio;
    using System.Net;

    public class ConsultaId
    {
        public class Unico : IRequest<EstadosInventario>
        {
            public string Id { get; set; }
        }

        public class Manejador : IRequestHandler<Unico, EstadosInventario>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public async Task<EstadosInventario> Handle(Unico request, CancellationToken cancellationToken)
            {
                var estadosInventario = await context.paramEstadosInventario.FindAsync(request.Id);
                if (estadosInventario == null)
                {
                    throw new ManejadorException(HttpStatusCode.NotFound, new { mensaje = "El registro no existe" });
                }

                return estadosInventario;
            }
        }

    }
}
