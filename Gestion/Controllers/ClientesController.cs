using Gestion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            using (var db = new WebGestionDBContext())
            {
                var clientes = await db.Clientes.Include(c => c.EstadoCivil)
                                        .Include(c => c.Nacionalidad)
                                        .Include(c => c.Provincia)
                                        .Include(c => c.TipoDocumento).ToListAsync();
                return View(clientes);
            }
            
        }

        //// GET: Clientes/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var clientes = await _context.Clientes
        //        .Include(c => c.EstadoCivil)
        //        .Include(c => c.Nacionalidad)
        //        .Include(c => c.Provincia)
        //        .Include(c => c.TipoDocumento)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (clientes == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(clientes);
        //}

        // GET: Clientes/Create
        public IActionResult Create()
        {
            //ViewData["EstadoCivilId"] = new SelectList(_context.ParamEstadosCiviles, "Id", "Id");
            //ViewData["NacionalidadId"] = new SelectList(_context.ParamNacionalidades, "Id", "Id");
            //ViewData["ProvinciaId"] = new SelectList(_context.ParamProvincias, "Id", "Id");
            //ViewData["TipoDocumentoId"] = new SelectList(_context.ParamTiposDocumentos, "Id", "Id");
            return View();
        }

        //// POST: Clientes/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Codigo,Apellido,Nombre,RazonSocial,TipoDocumentoId,NroDocumento,CuilCuit,Foto,FechaNacimiento,EstadoCivilId,NacionalidadId,EsPersonaJuridica,ProvinciaId,Localidad,CodigoPostal,Calle,CalleNro,PisoDpto,OtrasReferencias,Telefono,Celular,Email,Estado,FechaAlta,UsuarioAlta")] Clientes clientes)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(clientes);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoCivilId"] = new SelectList(_context.ParamEstadosCiviles, "Id", "Id", clientes.EstadoCivilId);
        //    ViewData["NacionalidadId"] = new SelectList(_context.ParamNacionalidades, "Id", "Id", clientes.NacionalidadId);
        //    ViewData["ProvinciaId"] = new SelectList(_context.ParamProvincias, "Id", "Id", clientes.ProvinciaId);
        //    ViewData["TipoDocumentoId"] = new SelectList(_context.ParamTiposDocumentos, "Id", "Id", clientes.TipoDocumentoId);
        //    return View(clientes);
        //}

        //// GET: Clientes/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var clientes = await _context.Clientes.FindAsync(id);
        //    if (clientes == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["EstadoCivilId"] = new SelectList(_context.ParamEstadosCiviles, "Id", "Id", clientes.EstadoCivilId);
        //    ViewData["NacionalidadId"] = new SelectList(_context.ParamNacionalidades, "Id", "Id", clientes.NacionalidadId);
        //    ViewData["ProvinciaId"] = new SelectList(_context.ParamProvincias, "Id", "Id", clientes.ProvinciaId);
        //    ViewData["TipoDocumentoId"] = new SelectList(_context.ParamTiposDocumentos, "Id", "Id", clientes.TipoDocumentoId);
        //    return View(clientes);
        //}

        //// POST: Clientes/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("Id,Codigo,Apellido,Nombre,RazonSocial,TipoDocumentoId,NroDocumento,CuilCuit,Foto,FechaNacimiento,EstadoCivilId,NacionalidadId,EsPersonaJuridica,ProvinciaId,Localidad,CodigoPostal,Calle,CalleNro,PisoDpto,OtrasReferencias,Telefono,Celular,Email,Estado,FechaAlta,UsuarioAlta")] Clientes clientes)
        //{
        //    if (id != clientes.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(clientes);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ClientesExists(clientes.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstadoCivilId"] = new SelectList(_context.ParamEstadosCiviles, "Id", "Id", clientes.EstadoCivilId);
        //    ViewData["NacionalidadId"] = new SelectList(_context.ParamNacionalidades, "Id", "Id", clientes.NacionalidadId);
        //    ViewData["ProvinciaId"] = new SelectList(_context.ParamProvincias, "Id", "Id", clientes.ProvinciaId);
        //    ViewData["TipoDocumentoId"] = new SelectList(_context.ParamTiposDocumentos, "Id", "Id", clientes.TipoDocumentoId);
        //    return View(clientes);
        //}

        //// GET: Clientes/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var clientes = await _context.Clientes
        //        .Include(c => c.EstadoCivil)
        //        .Include(c => c.Nacionalidad)
        //        .Include(c => c.Provincia)
        //        .Include(c => c.TipoDocumento)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (clientes == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(clientes);
        //}

        //// POST: Clientes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var clientes = await _context.Clientes.FindAsync(id);
        //    _context.Clientes.Remove(clientes);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ClientesExists(string id)
        //{
        //    return _context.Clientes.Any(e => e.Id == id);
        //}
    }
}
