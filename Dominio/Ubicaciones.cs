namespace Dominio
{
    public class Ubicaciones
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int SucursalId { get; set; }
        public bool Estado { get; set; }

        public Sucursales Sucursal { get; set; }
    }
}
