using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestion.Controllers
{
    public class ColoresController : Controller
    {
        // GET: ColoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ColoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ColoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ColoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ColoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ColoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ColoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
