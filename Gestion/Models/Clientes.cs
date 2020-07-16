using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion.Models
{
    public partial class Clientes
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string TipoDocumentoId { get; set; }
        public string NroDocumento { get; set; }
        public string CuilCuit { get; set; }
        public string Foto { get; set; }
        [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es valido")]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime? FechaNacimiento { get; set; }
        public string EstadoCivilId { get; set; }
        public string NacionalidadId { get; set; }
        public bool EsPersonaJuridica { get; set; }
        public string ProvinciaId { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string CalleNro { get; set; }
        public string PisoDpto { get; set; }
        public string OtrasReferencias { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }

        public virtual ParamEstadosCiviles EstadoCivil { get; set; }
        public virtual ParamNacionalidades Nacionalidad { get; set; }
        public virtual ParamProvincias Provincia { get; set; }
        public virtual ParamTiposDocumentos TipoDocumento { get; set; }
    }
}
