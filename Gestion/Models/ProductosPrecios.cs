using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ProductosPrecios
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PrecioRebajado { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string UsuarioProceso { get; set; }

        public virtual Productos Producto { get; set; }
    }
}
