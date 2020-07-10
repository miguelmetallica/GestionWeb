namespace Dominio
{
    public class NumeracionesComprobantes
    {
        public int Id { get; set; }
        public string SucursalId { get; set; }
        public string Letra { get; set; }
        public int PtoVenta { get; set; }
        public decimal Numero { get; set; }        
        public Sucursales Sucursal { get; set; }
    }
}
