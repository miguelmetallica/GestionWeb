using Dominio;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DataPrueba
    {
        public static async Task InsertarData(GestionContext context, UserManager<Usuarios> userManager)
        {
            if (!userManager.Users.Any())
            {
                var usuario = new Usuarios { NombreCompleto = "Miguel Elias", UserName = "admin", Email = "miguel.a.elias@gmail.com" };
                await userManager.CreateAsync(usuario, "Me123456$");
            }


            if (!context.paramColores.Any())
            {
                var obj = new Colores { Id = Guid.NewGuid().ToString(), Codigo = "00", Descripcion = "SIN COLOR", Color = "", Estado = true };
                context.paramColores.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramCategorias.Any())
            {
                var obj = new Categorias { Id = Guid.NewGuid().ToString(), Codigo = "000", Descripcion = "SIN CATEGORIA", ParentId = "", Estado = true };
                context.paramCategorias.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramCondicionesIva.Any())
            {
                var obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "1", Descripcion = "IVA RESPONSABLE INSCRIPTO", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "2", Descripcion = "IVA RESPONSABLE NO INSCRIPTO", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "3", Descripcion = "IVA NO RESPONSABLE", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "4", Descripcion = "IVA SUJETO EXENTO", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "5", Descripcion = "CONSUMIDOR FINAL", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "6", Descripcion = "RESPONSABLE MONOTRIBUTO", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "7", Descripcion = "SUJETO NO CATEGORIZADO", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "8", Descripcion = "PROVEEDOR DEL EXTERIOR", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "9", Descripcion = "CLIENTE DEL EXTERIOR", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "10", Descripcion = "IVA LIBERADO – LEY Nº 19.640", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "11", Descripcion = "IVA RESPONSABLE INSCRIPTO – AGENTE DE PERCEPCIÓN", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "12", Descripcion = "PEQUEÑO CONTRIBUYENTE EVENTUAL", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "13", Descripcion = "MONOTRIBUTISTA SOCIAL", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "14", Descripcion = "PEQUEÑO CONTRIBUYENTE EVENTUAL SOCIAL", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();

                obj = new CondicionesIva { Id = Guid.NewGuid().ToString(), Codigo = "10", Descripcion = "IVA LIBERADO – LEY Nº 19.640", Estado = true };
                context.paramCondicionesIva.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramCuentasCompras.Any())
            {
                var obj = new CuentasCompras { Id = Guid.NewGuid().ToString(), Codigo = "000", Descripcion = "SIN CUENTA DE COMPRAS", Estado = true };
                context.paramCuentasCompras.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramCuentasVentas.Any())
            {
                var obj = new CuentasVentas { Id = Guid.NewGuid().ToString(), Codigo = "000", Descripcion = "SIN CUENTA DE VENTAS", Estado = true };
                context.paramCuentasVentas.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramEstadosCiviles.Any())
            {
                var obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "001", Descripcion = "SOLTERO/A", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();

                obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "002", Descripcion = "COMPROMETIDO/A", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();

                obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "003", Descripcion = "CASADO/A", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();

                obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "004", Descripcion = "UNIÓN LIBRE O UNIÓN DE HECHO", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();

                obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "005", Descripcion = "SEPARADO/A", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();

                obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "006", Descripcion = "DIVORCIADO/A", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();

                obj = new EstadosCiviles { Id = Guid.NewGuid().ToString(), Codigo = "007", Descripcion = "VIUDO/A", Estado = true };
                context.paramEstadosCiviles.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramMarcas.Any())
            {
                var obj = new Marcas { Id = Guid.NewGuid().ToString(), Codigo = "000", Descripcion = "SIN MARCAS", Estado = true };
                context.paramMarcas.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramNacionalidades.Any())
            {
                var obj = new Nacionalidades { Id = Guid.NewGuid().ToString(), Codigo = "001", Descripcion = "ARGENTINA", Estado = true };
                context.paramNacionalidades.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramProvincias.Any())
            {
                var obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "0", Descripcion = "CIUDAD AUTÓNOMA DE BUENOS AIRES", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();

                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "1", Descripcion = "BUENOS AIRES", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "2", Descripcion = "CATAMARA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "3", Descripcion = "CÓRDOBA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "4", Descripcion = "CORRIENTES", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "5", Descripcion = "ENTRE RÍOS", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "6", Descripcion = "JUJUY", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "7", Descripcion = "MENDOZA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "8", Descripcion = "LA RIOJA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "9", Descripcion = "SALTA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "10", Descripcion = "SAN JUAN", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "11", Descripcion = "SAN LUIS", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "12", Descripcion = "SANTA FE", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "13", Descripcion = "SANTIAGO DEL ESTERO", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "14", Descripcion = "TUCUMÁN", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "16", Descripcion = "CHACO", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "17", Descripcion = "CHUBUT", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "18", Descripcion = "FORMOSA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "19", Descripcion = "MISIONES", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "20", Descripcion = "NEUQUÉN", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "21", Descripcion = "LA PAMPA", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "22", Descripcion = "RÍO NEGRO", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "23", Descripcion = "SANTA CRUZ", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();
                obj = new Provincias { Id = Guid.NewGuid().ToString(), Codigo = "24", Descripcion = "TIERRA DEL FUEGO", Estado = true };
                context.paramProvincias.Add(obj);
                await context.SaveChangesAsync();

            }

            if (!context.paramTiposDocumentos.Any())
            {
                var obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "0", Descripcion = "CI POLICÍA FEDERAL", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "1", Descripcion = "CI BUENOS AIRES", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "2", Descripcion = "CI CATAMARCA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "3", Descripcion = "CI CÓRDOBA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "4", Descripcion = "CI CORRIENTES", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "5", Descripcion = "CI ENTRE RÍOS", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "6", Descripcion = "CI JUJUY", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "7", Descripcion = "CI MENDOZA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "8", Descripcion = "CI LA RIOJA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "9", Descripcion = "CI SALTA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "10", Descripcion = "CI SAN JUAN", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "11", Descripcion = "CI SAN LUIS", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "12", Descripcion = "CI SANTA FE", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "13", Descripcion = "CI SANTIAGO DEL ESTERO", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "14", Descripcion = "CI TUCUMÁN", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "16", Descripcion = "CI CHACO", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "17", Descripcion = "CI CHUBUT", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "18", Descripcion = "CI FORMOSA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "19", Descripcion = "CI MISIONES", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "20", Descripcion = "CI NEUQUÉN", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "21", Descripcion = "CI LA PAMPA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "22", Descripcion = "CI RÍO NEGRO", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "23", Descripcion = "CI SANTA CRUZ", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "24", Descripcion = "CI TIERRA DEL FUEGO", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "80", Descripcion = "CUIT", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "86", Descripcion = "CUIL", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "87", Descripcion = "CDI", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "89", Descripcion = "LE", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "90", Descripcion = "LC", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "91", Descripcion = "CI EXTRANJERA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "92", Descripcion = "EN TRÁMITE", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "93", Descripcion = "ACTA NACIMIENTO", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "94", Descripcion = "PASAPORTE", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "95", Descripcion = "CI BS. AS.RNP", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "96", Descripcion = "DNI", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "99", Descripcion = "SIN IDENTIFICAR/ VENTA GLOBAL DIARIA", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "30", Descripcion = "CERTIFICADO DE MIGRACIÓN", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
                obj = new TiposDocumentos { Id = Guid.NewGuid().ToString(), Codigo = "88", Descripcion = "USADO POR ANSES PARA PADRÓN", Estado = true };
                context.paramTiposDocumentos.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramTiposProductos.Any())
            {
                var obj = new TiposProductos { Id = Guid.NewGuid().ToString(), Codigo = "1", Descripcion = "PRODUCTO / EXPORTACIÓN DEFINITIVA DE BIENES", Estado = true };
                context.paramTiposProductos.Add(obj);
                await context.SaveChangesAsync();

                obj = new TiposProductos { Id = Guid.NewGuid().ToString(), Codigo = "2", Descripcion = "SERVICIOS", Estado = true };
                context.paramTiposProductos.Add(obj);
                await context.SaveChangesAsync();

                obj = new TiposProductos { Id = Guid.NewGuid().ToString(), Codigo = "3", Descripcion = "PRODUCTOS Y SERVICIOS", Estado = true };
                context.paramTiposProductos.Add(obj);
                await context.SaveChangesAsync();

                obj = new TiposProductos { Id = Guid.NewGuid().ToString(), Codigo = "4", Descripcion = "OTRO", Estado = true };
                context.paramTiposProductos.Add(obj);
                await context.SaveChangesAsync();
            }

            if (!context.paramUnidadesMedidas.Any())
            {
                var obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "00", Descripcion = "SIN DESCRIPCION", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "01", Descripcion = "KILOGRAMO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "02", Descripcion = "METROS", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "03", Descripcion = "METRO CUADRADO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "04", Descripcion = "METRO CUBICO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "05", Descripcion = "LITROS", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "06", Descripcion = "1000 KILOWATT HORA", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "07", Descripcion = "UNIDAD", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "08", Descripcion = "PAR", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "09", Descripcion = "DOCENA", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "10", Descripcion = "QUILATE", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "11", Descripcion = "MILLAR", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "12", Descripcion = "MEGA U. INTER.ACT.ANTIB", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "13", Descripcion = "UNIDAD INT. ACT.INMUNG", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "14", Descripcion = "GRAMO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "15", Descripcion = "MILIMETRO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "16", Descripcion = "MILIMETRO CUBICO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "17", Descripcion = "KILOMETRO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "18", Descripcion = "HECTOLITRO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "19", Descripcion = "MEGA UNIDAD INT.ACT.INMUNG", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "20", Descripcion = "CENTIMETRO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "21", Descripcion = "KILOGRAMO ACTIVO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "22", Descripcion = "GRAMO ACTIVO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "23", Descripcion = "GRAMO BASE", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "24", Descripcion = "UIACTHOR", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "25", Descripcion = "JGO.PQT.MAZO NAIPES", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "26", Descripcion = "MUIACTHOR", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "27", Descripcion = "CENTIMETRO CUBICO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "28", Descripcion = "UIACTANT", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "29", Descripcion = "TONELADA", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "30", Descripcion = "DECAMETRO CUBICO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "31", Descripcion = "HECTOMETRO CUBICO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "32", Descripcion = "KILOMETRO CUBICO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "33", Descripcion = "MICROGRAMO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "34", Descripcion = "NANOGRAMO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "35", Descripcion = "PICOGRAMO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "36", Descripcion = "MUIACTANT", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "37", Descripcion = "UIACTIG", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "41", Descripcion = "MILIGRAMO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "47", Descripcion = "MILILITRO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "48", Descripcion = "CURIE", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "49", Descripcion = "MILICURIE", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "50", Descripcion = "MICROCURIE", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "51", Descripcion = "U.INTER.ACT.HORMONAL", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "52", Descripcion = "MEGA U. INTER.ACT.HOR.", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "53", Descripcion = "KILOGRAMO BASE", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "54", Descripcion = "GRUESA", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "55", Descripcion = "MUIACTIG", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "61", Descripcion = "KILOGRAMO BRUTO", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "62", Descripcion = "PACK", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "63", Descripcion = "HORMA", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "97", Descripcion = "SEÑAS / ANTICIPOS", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "98", Descripcion = "OTRAS UNIDADES", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();
                obj = new UnidadesMedidas { Id = Guid.NewGuid().ToString(), Codigo = "99", Descripcion = "BONIFICACION +", Estado = true };
                context.paramUnidadesMedidas.Add(obj);
                await context.SaveChangesAsync();

            }

            if (!context.sucursales.Any())
            {
                var obj = new Sucursales { Id = Guid.NewGuid().ToString(), Codigo = "01", Nombre = "BELGRANO", Estado = true };
                context.sucursales.Add(obj);
                await context.SaveChangesAsync();

                obj = new Sucursales { Id = Guid.NewGuid().ToString(), Codigo = "02", Nombre = "SAN JUAN", Estado = true };
                context.sucursales.Add(obj);
                await context.SaveChangesAsync();

                obj = new Sucursales { Id = Guid.NewGuid().ToString(), Codigo = "03", Nombre = "YERBA BUENA", Estado = true };
                context.sucursales.Add(obj);
                await context.SaveChangesAsync();
            }
        }
    }
}
