using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ParamProvincias
    {
        public ParamProvincias()
        {
            Clientes = new HashSet<Clientes>();
            Sucursales = new HashSet<Sucursales>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Sucursales> Sucursales { get; set; }
    }
}
