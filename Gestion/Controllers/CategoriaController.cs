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

        public IActionResult Editar(string id)
        {
            ViewBag.Categorias = Categorias();
            var categoria = new ParamCategorias();

            using (var db = new WebGestionDBContext())
            {
                categoria = (from c in db.ParamCategorias
                             where c.Id == id
                             select c
                              ).FirstOrDefault();

            }
            return View(categoria);
        }

        [HttpPost]
        public IActionResult Guardar(ParamCategorias categorias)
        {
            string vista = "";
            if (categorias.Id == null) 
                vista = "Nuevo";
            else 
                vista = "Editar";

            if (!ModelState.IsValid)
            {
                ViewBag.Categorias = Categorias();
                return View(vista, categorias);
            }
            else
            {
                try
                {
                    using (var db = new WebGestionDBContext())
                    {
                        if (categorias.Id == null)
                        {
                            ParamCategorias obj = new ParamCategorias();
                            obj.Id = Guid.NewGuid().ToString();
                            obj.Codigo = categorias.Codigo;
                            obj.Descripcion = categorias.Descripcion;
                            obj.ParentId = categorias.ParentId ?? "";
                            obj.Estado = true;

                            db.ParamCategorias.Add(obj);
                            db.SaveChanges();                 
                        }
                        else
                        {
                            ParamCategorias obj = db.ParamCategorias.Where(x => x.Id == categorias.Id).FirstOrDefault();
                            obj.Id = categorias.Id;
                            obj.Codigo = categorias.Codigo;
                            obj.Descripcion = categorias.Descripcion;
                            obj.ParentId = categorias.ParentId ?? "";
                            obj.Estado = true;
                            db.SaveChanges();                 
                        }
                    }
                }
                catch (Exception)
                {
                    ViewBag.Categorias = Categorias();
                    return View(vista, categorias);
                }                
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public int Eliminar(string id)
        {
            try
            {
                using (var db = new WebGestionDBContext())
                {
                    ParamCategorias obj = db.ParamCategorias.Where(x => x.Id == id).FirstOrDefault();
                    obj.Estado = false;
                    db.SaveChanges();                    
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        [HttpPost]
        public List<ParamCategorias> Categorias(string buscar = "")
        {
            List<ParamCategorias> categorias = new List<ParamCategorias>();
            using (var db = new WebGestionDBContext())
            {
                if (buscar == "" || buscar == null)
                {
                    categorias = (from c in db.ParamCategorias
                                  where c.Estado == true 
                                  select c
                                  ).ToList();
                }
                else {
                    categorias = (from c in db.ParamCategorias
                                  where c.Estado == true &&
                                    (c.Codigo.Contains(buscar) ||
                                    c.Descripcion.Contains(buscar))
                                  select c
                                  ).ToList();
                }
                
            }
            return categorias;
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

        [HttpPost]
        public RespuestaViewModel GuardarCambios(ParamCategorias categorias)
        {
            RespuestaViewModel resp = new RespuestaViewModel();
            string respuesta = "";
            if (!ModelState.IsValid)
            {
                var errores = (from s in ModelState.Values
                               from e in s.Errors
                               select e.ErrorMessage
                               ).ToList();
                respuesta += "<ul class='list-group'>";
                foreach (var item in errores) 
                {
                    respuesta += "<li class='list-group-item list-group-item-danger'>";
                    respuesta += item;
                    respuesta += "</li>";
                }
                respuesta += "</ul>";                
                
                resp.Codigo = 0;
                resp.Error = respuesta; ;
                return resp;
            }
            else
            {
                try
                {
                    using (var db = new WebGestionDBContext())
                    {
                        if (categorias.Id == null)
                        {
                            ParamCategorias obj = new ParamCategorias();
                            obj.Id = Guid.NewGuid().ToString();
                            obj.Codigo = categorias.Codigo;
                            obj.Descripcion = categorias.Descripcion;
                            obj.ParentId = categorias.ParentId ?? "";
                            obj.Estado = true;

                            db.ParamCategorias.Add(obj);
                            db.SaveChanges();
                        }
                        else
                        {
                            ParamCategorias obj = db.ParamCategorias.Where(x => x.Id == categorias.Id).FirstOrDefault();
                            obj.Id = categorias.Id;
                            obj.Codigo = categorias.Codigo;
                            obj.Descripcion = categorias.Descripcion;
                            obj.ParentId = categorias.ParentId ?? "";
                            obj.Estado = true;
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception e)
                {
                    respuesta += "<ul class='list-group'>";
                    respuesta += "<li class='list-group-item list-group-item-danger'>";
                    if (e.InnerException != null &&
                        e.InnerException.Message.Contains("IX_"))
                    {
                        if (e.InnerException.Message.Contains("Codigo"))
                            respuesta += "Codigo Duplicado";
                        else
                            respuesta += "Descripcion Duplicada";
                    }
                    else
                    {
                        respuesta += e.Message;
                    }                    
                    respuesta += "</li>";
                    respuesta += "</ul>";
                    resp.Codigo = 0;
                    resp.Error = respuesta; ;
                    return resp;
                }
            }
            resp.Codigo = 1;
            resp.Error = "";
            return resp;
        }

    }
}
