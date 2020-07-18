using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion.Models
{
    public partial class ParamCategorias
    {
        public ParamCategorias()
        {
            ProductosCategorias = new HashSet<ProductosCategorias>();
        }

        public string Id { get; set; }

        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public string ParentId { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<ProductosCategorias> ProductosCategorias { get; set; }
    }
}
