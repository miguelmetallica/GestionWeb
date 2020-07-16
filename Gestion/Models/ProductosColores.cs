using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ProductosColores
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string ColorId { get; set; }

        public virtual ParamColores Color { get; set; }
        public virtual Productos Producto { get; set; }
    }
}
