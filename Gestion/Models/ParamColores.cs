using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ParamColores
    {
        public ParamColores()
        {
            ProductosColores = new HashSet<ProductosColores>();
            ProductosMovimientosStock = new HashSet<ProductosMovimientosStock>();
            ProductosStock = new HashSet<ProductosStock>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<ProductosColores> ProductosColores { get; set; }
        public virtual ICollection<ProductosMovimientosStock> ProductosMovimientosStock { get; set; }
        public virtual ICollection<ProductosStock> ProductosStock { get; set; }
    }
}
