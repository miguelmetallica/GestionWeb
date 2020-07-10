using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Marcas
{
    using Dominio;
    public class Consulta
    {
        public class Listado : IRequest<List<Marcas>>
        { 
        
        }

        public class Manejador : IRequestHandler<Listado, List<Marcas>>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public Task<List<Marcas>> Handle(Listado request, CancellationToken cancellationToken)
            {
                var marcas = context.paramMarcas.ToListAsync();
                return marcas;
            }
        }

    }
}
