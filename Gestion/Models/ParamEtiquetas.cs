using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ParamEtiquetas
    {
        public ParamEtiquetas()
        {
            ProductosEtiquetas = new HashSet<ProductosEtiquetas>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<ProductosEtiquetas> ProductosEtiquetas { get; set; }
    }
}
