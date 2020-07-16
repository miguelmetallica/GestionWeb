using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ParamCategorias
    {
        public ParamCategorias()
        {
            ProductosCategorias = new HashSet<ProductosCategorias>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string ParentId { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<ProductosCategorias> ProductosCategorias { get; set; }
    }
}
