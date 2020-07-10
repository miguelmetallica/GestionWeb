namespace Dominio
{
    public class ProductosMovimientosStock
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string SucursalId { get; set; }

        public Productos Producto { get; set; }
        public Sucursales Sucursal { get; set; }        
    }
}
