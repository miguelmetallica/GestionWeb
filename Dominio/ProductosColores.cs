namespace Dominio
{
    public class ProductosColores
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string ColorId { get; set; }
        public Productos Producto { get; set; }
        public Colores Color { get; set; }        
    }
}
