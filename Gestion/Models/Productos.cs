using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class Productos
    {
        public Productos()
        {
            ProductosCategorias = new HashSet<ProductosCategorias>();
            ProductosColores = new HashSet<ProductosColores>();
            ProductosEtiquetas = new HashSet<ProductosEtiquetas>();
            ProductosMovimientosStock = new HashSet<ProductosMovimientosStock>();
            ProductosPrecios = new HashSet<ProductosPrecios>();
            ProductosStock = new HashSet<ProductosStock>();
        }

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
        public decimal? PrecioCompra { get; set; }
        public string CuentaVentaId { get; set; }
        public string CuentaCompraId { get; set; }
        public string UnidadMedidaId { get; set; }
        public string MarcaId { get; set; }
        public string Imagen { get; set; }
        public bool? Visible { get; set; }
        public decimal? PrecioNormal { get; set; }
        public decimal? PrecioRebajado { get; set; }
        public string EstadoInventarioId { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }

        public virtual ParamCuentasCompras CuentaCompra { get; set; }
        public virtual ParamCuentasVentas CuentaVenta { get; set; }
        public virtual ParamEstadosInventario EstadoInventario { get; set; }
        public virtual ParamMarcas Marca { get; set; }
        public virtual ParamTiposProductos TipoProducto { get; set; }
        public virtual ParamUnidadesMedidas UnidadMedida { get; set; }
        public virtual ICollection<ProductosCategorias> ProductosCategorias { get; set; }
        public virtual ICollection<ProductosColores> ProductosColores { get; set; }
        public virtual ICollection<ProductosEtiquetas> ProductosEtiquetas { get; set; }
        public virtual ICollection<ProductosMovimientosStock> ProductosMovimientosStock { get; set; }
        public virtual ICollection<ProductosPrecios> ProductosPrecios { get; set; }
        public virtual ICollection<ProductosStock> ProductosStock { get; set; }
    }
}
