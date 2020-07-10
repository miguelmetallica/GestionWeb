namespace Dominio
{
    public class Configuraciones
    {
        public int Id { get; set; }
        public string SucursalId { get; set; }
        public string Configuracion { get; set; }
        public string Valor { get; set; }
        public bool Estado { get; set; }

        public Sucursales Sucursal { get; set; }
    }
}
