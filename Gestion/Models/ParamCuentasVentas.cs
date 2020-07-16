using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ParamCuentasVentas
    {
        public ParamCuentasVentas()
        {
            Productos = new HashSet<Productos>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
