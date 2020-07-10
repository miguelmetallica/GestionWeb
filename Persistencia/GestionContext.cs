using Dominio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class GestionContext : IdentityDbContext<Usuarios>
    {
        public GestionContext(DbContextOptions options) :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            //mucho a mucho
            //modelBuilder.Entity<GestionContext>().HasKey(ci => new { ci. })
        }

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Categorias> paramCategorias { get; set; }
        public DbSet<Colores> paramColores { get; set; }
        public DbSet<CondicionesIva> paramCondicionesIva { get; set; }
        public DbSet<CuentasCompras> paramCuentasCompras { get; set; }
        public DbSet<CuentasVentas> paramCuentasVentas { get; set; }
        public DbSet<EstadosCiviles> paramEstadosCiviles { get; set; }
        public DbSet<EstadosInventario> paramEstadosInventario { get; set; }
        public DbSet<Etiquetas> paramEtiquetas { get; set; }
        public DbSet<Marcas> paramMarcas { get; set; }
        public DbSet<Nacionalidades> paramNacionalidades { get; set; }
        public DbSet<Provincias> paramProvincias { get; set; }
        public DbSet<TiposDocumentos> paramTiposDocumentos { get; set; }
        public DbSet<TiposProductos> paramTiposProductos { get; set; }
        public DbSet<UnidadesMedidas> paramUnidadesMedidas { get; set; }
        public DbSet<Sucursales> sucursales { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<ProductosCategorias> productosCategorias { get; set; }
        public DbSet<ProductosEtiquetas> productosEtiquetas { get; set; }
        public DbSet<ProductosColores> productosColores { get; set; }
        

    }
}
