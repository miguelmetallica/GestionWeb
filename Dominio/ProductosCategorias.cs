namespace Dominio
{
    public class ProductosCategorias
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string CategoriaId { get; set; }
        public Productos Producto { get; set; }
        public Categorias Categoria { get; set; }        
    }
}
