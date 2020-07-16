using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class ParamNacionalidades
    {
        public ParamNacionalidades()
        {
            Clientes = new HashSet<Clientes>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
