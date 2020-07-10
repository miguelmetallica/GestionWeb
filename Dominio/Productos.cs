namespace Dominio
{
    public class Productos
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string TipoProductoId { get; set; }
        public string DescripcionCorta { get; set; }
        public string DescripcionLarga { get; set; }
        public decimal? Peso { get; set; }
        public decimal? DimencionesLongitud { get; set; }
        public decimal? DimencionesAncho { get; set; }
        public decimal? DimencionesAltura { get; set; }
        public decimal PrecioCompra { get; set; }
        public string CuentaVentaId { get; set; }
        public string CuentaCompraId { get; set; }
        public string UnidadMedidaId { get; set; }
        public string MarcaId { get; set; }
        public bool Visible { get; set; }
        public decimal PrecioNormal { get; set; }
        public decimal PrecioRebajado { get; set; }
        public string EstadoInventarioId { get; set; }
        public bool Estado { get; set; }

        public TiposProductos TipoProducto { get; set; }
        public CuentasVentas CuentaVenta { get; set; }
        public CuentasCompras CuentaCompra { get; set; }
        public UnidadesMedidas UnidadMedida { get; set; }
        public Marcas Marca { get; set; }
        public EstadosInventario EstadoInventario { get; set; }
    }
}
