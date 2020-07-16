using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ProductosCategorias
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string CategoriaId { get; set; }

        public virtual ParamCategorias Categoria { get; set; }
        public virtual Productos Producto { get; set; }
    }
}
