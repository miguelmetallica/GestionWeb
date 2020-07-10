using System;

namespace Dominio
{
    public class Clientes
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
        public DateTime FechaNacimiento { get; set; }
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
        public string UsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        
        public TiposDocumentos TipoDocumento { get; set; }       
        public EstadosCiviles EstadoCivil { get; set; }        
        public Nacionalidades Nacionalidad { get; set; }        
        public Provincias Provincia { get; set; }        
    }
}
