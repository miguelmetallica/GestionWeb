using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gestion.Models
{
    public partial class WebGestionDBContext : DbContext
    {
        public WebGestionDBContext()
        {
        }

        public WebGestionDBContext(DbContextOptions<WebGestionDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ParamCategorias> ParamCategorias { get; set; }
        public virtual DbSet<ParamColores> ParamColores { get; set; }
        public virtual DbSet<ParamComprobantesTipos> ParamComprobantesTipos { get; set; }
        public virtual DbSet<ParamCondicionesIva> ParamCondicionesIva { get; set; }
        public virtual DbSet<ParamCuentasCompras> ParamCuentasCompras { get; set; }
        public virtual DbSet<ParamCuentasVentas> ParamCuentasVentas { get; set; }
        public virtual DbSet<ParamEstadosCiviles> ParamEstadosCiviles { get; set; }
        public virtual DbSet<ParamEstadosInventario> ParamEstadosInventario { get; set; }
        public virtual DbSet<ParamEtiquetas> ParamEtiquetas { get; set; }
        public virtual DbSet<ParamMarcas> ParamMarcas { get; set; }
        public virtual DbSet<ParamNacionalidades> ParamNacionalidades { get; set; }
        public virtual DbSet<ParamProvincias> ParamProvincias { get; set; }
        public virtual DbSet<ParamTiposDocumentos> ParamTiposDocumentos { get; set; }
        public virtual DbSet<ParamTiposProductos> ParamTiposProductos { get; set; }
        public virtual DbSet<ParamUnidadesMedidas> ParamUnidadesMedidas { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosCategorias> ProductosCategorias { get; set; }
        public virtual DbSet<ProductosColores> ProductosColores { get; set; }
        public virtual DbSet<ProductosEtiquetas> ProductosEtiquetas { get; set; }
        public virtual DbSet<ProductosMovimientosStock> ProductosMovimientosStock { get; set; }
        public virtual DbSet<ProductosPrecios> ProductosPrecios { get; set; }
        public virtual DbSet<ProductosStock> ProductosStock { get; set; }
        public virtual DbSet<SisComprobantesNumeraciones> SisComprobantesNumeraciones { get; set; }
        public virtual DbSet<SisConfiguraciones> SisConfiguraciones { get; set; }
        public virtual DbSet<SisErroresLogs> SisErroresLogs { get; set; }
        public virtual DbSet<SisNumeraciones> SisNumeraciones { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-JUPF7GC\\SQLEXPRESS;database=WebGestionDB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NombreCompleto).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.SucursalId).HasMaxLength(450);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_AspNetUsers_Sucursales");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasIndex(e => e.CuilCuit)
                    .IsUnique();

                entity.HasIndex(e => new { e.TipoDocumentoId, e.NroDocumento })
                    .HasName("IX_Clientes_TipoNroDocumento")
                    .IsUnique();

                entity.Property(e => e.Apellido).HasMaxLength(150);

                entity.Property(e => e.Calle).HasMaxLength(500);

                entity.Property(e => e.CalleNro).HasMaxLength(10);

                entity.Property(e => e.Celular).HasMaxLength(15);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CodigoPostal).HasMaxLength(10);

                entity.Property(e => e.CuilCuit)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.EsPersonaJuridica).HasColumnName("esPersonaJuridica");

                entity.Property(e => e.EstadoCivilId).HasMaxLength(150);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Localidad).HasMaxLength(250);

                entity.Property(e => e.NacionalidadId).HasMaxLength(150);

                entity.Property(e => e.Nombre).HasMaxLength(150);

                entity.Property(e => e.NroDocumento)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.OtrasReferencias).HasMaxLength(500);

                entity.Property(e => e.PisoDpto).HasMaxLength(100);

                entity.Property(e => e.ProvinciaId).HasMaxLength(150);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.TipoDocumentoId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UsuarioAlta)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .HasConstraintName("FK_Clientes_ParamEstadosCiviles");

                entity.HasOne(d => d.Nacionalidad)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.NacionalidadId)
                    .HasConstraintName("FK_Clientes_ParamNacionalidades");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("FK_Clientes_ParamProvincias");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clientes_ParamTiposDocumentos");
            });

            modelBuilder.Entity<ParamCategorias>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasMaxLength(450);
            });

            modelBuilder.Entity<ParamColores>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamComprobantesTipos>(entity =>
            {
                entity.Property(e => e.Abrevitura).HasMaxLength(5);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<ParamCondicionesIva>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamCuentasCompras>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamCuentasVentas>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamEstadosCiviles>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamEstadosInventario>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamEtiquetas>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamMarcas>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamNacionalidades>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamProvincias>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamTiposDocumentos>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamTiposProductos>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ParamUnidadesMedidas>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CuentaCompraId).HasMaxLength(450);

                entity.Property(e => e.CuentaVentaId).HasMaxLength(450);

                entity.Property(e => e.DescripcionCorta).HasMaxLength(500);

                entity.Property(e => e.DescripcionLarga).HasMaxLength(4000);

                entity.Property(e => e.DimencionesAltura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DimencionesAncho).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DimencionesLongitud).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EstadoInventarioId).HasMaxLength(450);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.MarcaId).HasMaxLength(450);

                entity.Property(e => e.Peso).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioCompra).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioNormal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioRebajado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TipoProductoId).HasMaxLength(450);

                entity.Property(e => e.UnidadMedidaId).HasMaxLength(450);

                entity.Property(e => e.UsuarioAlta)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.CuentaCompra)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CuentaCompraId)
                    .HasConstraintName("FK_Productos_ParamCuentasCompras");

                entity.HasOne(d => d.CuentaVenta)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CuentaVentaId)
                    .HasConstraintName("FK_Productos_ParamCuentasVentas");

                entity.HasOne(d => d.EstadoInventario)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.EstadoInventarioId)
                    .HasConstraintName("FK_Productos_ParamEstadosInventario");

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.MarcaId)
                    .HasConstraintName("FK_Productos_ParamMarcas");

                entity.HasOne(d => d.TipoProducto)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.TipoProductoId)
                    .HasConstraintName("FK_Productos_ParamTiposProductos");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK_Productos_ParamUnidadesMedidas");
            });

            modelBuilder.Entity<ProductosCategorias>(entity =>
            {
                entity.Property(e => e.CategoriaId).HasMaxLength(450);

                entity.Property(e => e.ProductoId).HasMaxLength(450);

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.ProductosCategorias)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("FK_ProductosCategorias_ParamCategorias");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductosCategorias)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_ProductosCategorias_Productos");
            });

            modelBuilder.Entity<ProductosColores>(entity =>
            {
                entity.Property(e => e.ColorId).HasMaxLength(450);

                entity.Property(e => e.ProductoId).HasMaxLength(450);

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.ProductosColores)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_ProductosColores_ParamColores");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductosColores)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_ProductosColores_Productos");
            });

            modelBuilder.Entity<ProductosEtiquetas>(entity =>
            {
                entity.Property(e => e.EtiquetasId).HasMaxLength(450);

                entity.Property(e => e.ProductoId).HasMaxLength(450);

                entity.HasOne(d => d.Etiquetas)
                    .WithMany(p => p.ProductosEtiquetas)
                    .HasForeignKey(d => d.EtiquetasId)
                    .HasConstraintName("FK_ProductosEtiquetas_ParamEtiquetas");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductosEtiquetas)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_ProductosEtiquetas_Productos");
            });

            modelBuilder.Entity<ProductosMovimientosStock>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ColorId).HasMaxLength(450);

                entity.Property(e => e.Descripcion).HasMaxLength(500);

                entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");

                entity.Property(e => e.NumeroMovimiento).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ProductoId).HasMaxLength(450);

                entity.Property(e => e.SucursalId).HasMaxLength(450);

                entity.Property(e => e.TalleId).HasMaxLength(450);

                entity.Property(e => e.UbicacionId).HasMaxLength(450);

                entity.Property(e => e.UsuarioMovimiento).HasMaxLength(450);

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.ProductosMovimientosStock)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_ProductosMovimientosStock_ParamColores");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductosMovimientosStock)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_ProductosMovimientosStock_Productos");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.ProductosMovimientosStock)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_ProductosMovimientosStock_Sucursales");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.ProductosMovimientosStock)
                    .HasForeignKey(d => d.UbicacionId)
                    .HasConstraintName("FK_ProductosMovimientosStock_Ubicaciones");
            });

            modelBuilder.Entity<ProductosPrecios>(entity =>
            {
                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioRebajado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProductoId).HasMaxLength(450);

                entity.Property(e => e.UsuarioProceso).HasMaxLength(450);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductosPrecios)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_ProductosPrecios_Productos");
            });

            modelBuilder.Entity<ProductosStock>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ColorId).HasMaxLength(450);

                entity.Property(e => e.ProductoId).HasMaxLength(450);

                entity.Property(e => e.SucursalId).HasMaxLength(450);

                entity.Property(e => e.TalleId).HasMaxLength(450);

                entity.Property(e => e.UbicacionId).HasMaxLength(450);

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.ProductosStock)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_ProductosStock_ParamColores");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductosStock)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK_ProductosStock_Productos");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.ProductosStock)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_ProductosStock_Sucursales");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.ProductosStock)
                    .HasForeignKey(d => d.UbicacionId)
                    .HasConstraintName("FK_ProductosStock_Ubicaciones");
            });

            modelBuilder.Entity<SisComprobantesNumeraciones>(entity =>
            {
                entity.Property(e => e.Letra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Numero).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.SucursalId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.SisComprobantesNumeraciones)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisComprobantesNumeraciones_Sucursales");
            });

            modelBuilder.Entity<SisConfiguraciones>(entity =>
            {
                entity.Property(e => e.Configuracion).HasMaxLength(150);

                entity.Property(e => e.SucursalId).HasMaxLength(450);

                entity.Property(e => e.Valor).HasMaxLength(50);

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.SisConfiguraciones)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_SisConfiguraciones_Sucursales");
            });

            modelBuilder.Entity<SisErroresLogs>(entity =>
            {
                entity.HasIndex(e => e.FechaHora)
                    .HasName("IX_SisErroresLogs");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<SisNumeraciones>(entity =>
            {
                entity.Property(e => e.Numero).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Parametro)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SucursalId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.SisNumeraciones)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisNumeraciones_Sucursales");
            });

            modelBuilder.Entity<Sucursales>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Calle).HasMaxLength(500);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodigoPostal).HasMaxLength(10);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Localidad).HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NroCalle).HasMaxLength(10);

                entity.Property(e => e.OtrasReferencias).HasMaxLength(500);

                entity.Property(e => e.PisoDpto).HasMaxLength(100);

                entity.Property(e => e.ProvinciaId).HasMaxLength(150);

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Sucursales)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("FK_Sucursales_ParamProvincias");
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SucursalId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Ubicaciones)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sucursales_Sucursales");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
