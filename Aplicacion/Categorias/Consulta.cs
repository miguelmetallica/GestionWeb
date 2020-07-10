using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Categorias
{
    using Dominio;
    public class Consulta
    {
        public class Listado : IRequest<List<Categorias>>
        { 
        
        }

        public class Manejador : IRequestHandler<Listado, List<Categorias>>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public Task<List<Categorias>> Handle(Listado request, CancellationToken cancellationToken)
            {
                var categorias = context.paramCategorias.ToListAsync();
                return categorias;
            }
        }

    }
}
