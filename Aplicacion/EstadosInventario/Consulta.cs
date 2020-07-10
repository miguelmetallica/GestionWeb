using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.EstadosInventario
{
    using Dominio;
    public class Consulta
    {
        public class Listado : IRequest<List<EstadosInventario>>
        { 
        
        }

        public class Manejador : IRequestHandler<Listado, List<EstadosInventario>>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public Task<List<EstadosInventario>> Handle(Listado request, CancellationToken cancellationToken)
            {
                var estadosInventario = context.paramEstadosInventario.ToListAsync();
                return estadosInventario;
            }
        }

    }
}
