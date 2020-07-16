using Gestion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gestion.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            List<ParamCategorias> categorias = new List<ParamCategorias>();
            using (var db = new WebGestionDBContext())
            {
                categorias = (from c in db.ParamCategorias
                              where c.Estado == true
                              select c
                              ).ToList();
            }
            return View(categorias);
        }

        public IActionResult Nuevo()
        {
            ViewBag.Categorias = Categorias();
            return View();
        }
        
        [HttpPost]
        public IActionResult Nuevo(ParamCategorias categorias)
        {
            try
            {
                using (var db = new WebGestionDBContext())
                {
                    if (!ModelState.IsValid)
                    {
                        ViewBag.Categorias = Categorias();
                        return View(categorias);
                    }
                    else 
                    {
                        ParamCategorias obj = new ParamCategorias();
                        obj.Id = Guid.NewGuid().ToString();
                        obj.Codigo = categorias.Codigo;
                        obj.Descripcion = categorias.Descripcion;
                        obj.ParentId = categorias.ParentId;
                        obj.Estado = true;

                        db.ParamCategorias.Add(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                ViewBag.Categorias = Categorias();
                return View(categorias);
            }
            return RedirectToAction("Index");
        }

        public List<SelectListItem> Categorias()
        {
            List<SelectListItem> categorias = new List<SelectListItem>();
            using (var db = new WebGestionDBContext())
            {
                categorias = (from c in db.ParamCategorias
                              where c.Estado == true
                              select new SelectListItem { 
                                Text = c.Descripcion,
                                Value = c.Id
                              }).ToList();
                categorias.Insert(0, new SelectListItem("--Seleccione--",""));
            }
            return categorias;
        }
    }
}
