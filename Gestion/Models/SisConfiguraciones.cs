using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class SisConfiguraciones
    {
        public string Id { get; set; }
        public string SucursalId { get; set; }
        public string Configuracion { get; set; }
        public string Valor { get; set; }
        public bool? Estado { get; set; }

        public virtual Sucursales Sucursal { get; set; }
    }
}
