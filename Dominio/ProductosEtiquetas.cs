namespace Dominio
{
    public class ProductosEtiquetas
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public string EtiquetaId { get; set; }
        public Productos Producto { get; set; }
        public Etiquetas Etiqueta { get; set; }        
    }
}
