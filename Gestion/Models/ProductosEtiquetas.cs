using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ProductosEtiquetas
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string EtiquetasId { get; set; }

        public virtual ParamEtiquetas Etiquetas { get; set; }
        public virtual Productos Producto { get; set; }
    }
}
