using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class SisComprobantesNumeraciones
    {
        public string Id { get; set; }
        public string SucursalId { get; set; }
        public string Letra { get; set; }
        public int PuntoVenta { get; set; }
        public decimal Numero { get; set; }

        public virtual Sucursales Sucursal { get; set; }
    }
}
