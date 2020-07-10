using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Etiquetas
{
    using Dominio;
    public class Consulta
    {
        public class Listado : IRequest<List<Etiquetas>>
        { 
        
        }

        public class Manejador : IRequestHandler<Listado, List<Etiquetas>>
        {
            private readonly GestionContext context;

            public Manejador(GestionContext context)
            {
                this.context = context;
            }
            public Task<List<Etiquetas>> Handle(Listado request, CancellationToken cancellationToken)
            {
                var etiquetas = context.paramEtiquetas.ToListAsync();
                return etiquetas;
            }
        }

    }
}
