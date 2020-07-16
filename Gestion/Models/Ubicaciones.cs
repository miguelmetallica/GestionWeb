using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class Ubicaciones
    {
        public Ubicaciones()
        {
            ProductosMovimientosStock = new HashSet<ProductosMovimientosStock>();
            ProductosStock = new HashSet<ProductosStock>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string SucursalId { get; set; }
        public bool? Estado { get; set; }

        public virtual Sucursales Sucursal { get; set; }
        public virtual ICollection<ProductosMovimientosStock> ProductosMovimientosStock { get; set; }
        public virtual ICollection<ProductosStock> ProductosStock { get; set; }
    }
}
