using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion.Models
{
    public partial class ClienteFisicoNuevo
    {
        public string Id { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name ="Tipo Documento")]
        public string TipoDocumentoId { get; set; }
        [Required]
        [Display(Name = "Nro Documento")]
        public string NroDocumento { get; set; }

        [Display(Name = "CUIL")]
        public string CuilCuit { get; set; }
        
        [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es valido")]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime? FechaNacimiento { get; set; }

        [Display(Name = "Estado Civil")]
        public string EstadoCivilId { get; set; }

        [Display(Name = "Nacionalidad")]
        public string NacionalidadId { get; set; }

        [Display(Name = "Provincia")]
        public string ProvinciaId { get; set; }
        public string Localidad { get; set; }

        [Display(Name = "Codigo Postal")]
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }

        [Display(Name = "Nro")]
        public string CalleNro { get; set; }

        [Display(Name = "Piso / Dtpo")]
        public string PisoDpto { get; set; }

        [Display(Name = "Otras Referencias")]
        public string OtrasReferencias { get; set; }
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Email { get; set; }
        public string Usuario { get; set; }        
    }
}
