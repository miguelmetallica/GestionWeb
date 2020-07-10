namespace Aplicacion.Seguridad
{
    public class SucursalesDTO
    {
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
        public bool Estado { get; set; }
    }
}
