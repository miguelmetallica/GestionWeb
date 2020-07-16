using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class SisNumeraciones
    {
        public string Id { get; set; }
        public string SucursalId { get; set; }
        public string Parametro { get; set; }
        public decimal Numero { get; set; }

        public virtual Sucursales Sucursal { get; set; }
    }
}
