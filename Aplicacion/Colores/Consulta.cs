using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Colores
{
    using Dominio;
    public class Consulta
    {
        public class Listado : IRequest<List<Colores>>
        { 
        
        }

        public class Manejador : IRequestHandler<Listado, List<Colores>>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public Task<List<Colores>> Handle(Listado request, CancellationToken cancellationToken)
            {
                var colores = context.paramColores.ToListAsync();
                return colores;
            }
        }

    }
}
