using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ProductosStock
    {
        public string Id { get; set; }
        public string SucursalId { get; set; }
        public string UbicacionId { get; set; }
        public string ProductoId { get; set; }
        public string ColorId { get; set; }
        public string TalleId { get; set; }
        public decimal? Cantidad { get; set; }

        public virtual ParamColores Color { get; set; }
        public virtual Productos Producto { get; set; }
        public virtual Sucursales Sucursal { get; set; }
        public virtual Ubicaciones Ubicacion { get; set; }
    }
}
