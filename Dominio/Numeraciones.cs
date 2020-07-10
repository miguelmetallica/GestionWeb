namespace Dominio
{
    public class Numeraciones
    {
        public int Id { get; set; }
        public string SucursalId { get; set; }
        public string Parametro { get; set; }
        public decimal Numero { get; set; }        

        public Sucursales Sucursal { get; set; }
    }
}
