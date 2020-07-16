using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class Sucursales
    {
        public Sucursales()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            ProductosMovimientosStock = new HashSet<ProductosMovimientosStock>();
            ProductosStock = new HashSet<ProductosStock>();
            SisComprobantesNumeraciones = new HashSet<SisComprobantesNumeraciones>();
            SisConfiguraciones = new HashSet<SisConfiguraciones>();
            SisNumeraciones = new HashSet<SisNumeraciones>();
            Ubicaciones = new HashSet<Ubicaciones>();
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ProvinciaId { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string NroCalle { get; set; }
        public string PisoDpto { get; set; }
        public string OtrasReferencias { get; set; }
        public bool? Estado { get; set; }

        public virtual ParamProvincias Provincia { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<ProductosMovimientosStock> ProductosMovimientosStock { get; set; }
        public virtual ICollection<ProductosStock> ProductosStock { get; set; }
        public virtual ICollection<SisComprobantesNumeraciones> SisComprobantesNumeraciones { get; set; }
        public virtual ICollection<SisConfiguraciones> SisConfiguraciones { get; set; }
        public virtual ICollection<SisNumeraciones> SisNumeraciones { get; set; }
        public virtual ICollection<Ubicaciones> Ubicaciones { get; set; }
    }
}
