using DigiLib_V2.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLib_V2.Controllers
{
    public class LivrosController : Controller
    {
        private readonly Contexto db;

        public LivrosController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: LivrosController
        public ActionResult Index()
        {
            return View( db.LIVROS.ToList());
        }

        // GET: LivrosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LivrosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LivrosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Livros collection)
        {
            try
            {
                db.LIVROS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivrosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LivrosController/Edit/5
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

        // GET: LivrosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LivrosController/Delete/5
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
