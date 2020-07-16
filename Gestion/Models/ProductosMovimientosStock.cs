using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ProductosMovimientosStock
    {
        public string Id { get; set; }
        public decimal? NumeroMovimiento { get; set; }
        public string SucursalId { get; set; }
        public string UbicacionId { get; set; }
        public string ProductoId { get; set; }
        public string ColorId { get; set; }
        public string TalleId { get; set; }
        public decimal? Cantidad { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaMovimiento { get; set; }
        public string UsuarioMovimiento { get; set; }

        public virtual ParamColores Color { get; set; }
        public virtual Productos Producto { get; set; }
        public virtual Sucursales Sucursal { get; set; }
        public virtual Ubicaciones Ubicacion { get; set; }
    }
}
