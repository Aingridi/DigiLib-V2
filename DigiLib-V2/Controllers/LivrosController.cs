using DigiLibV2;
using DigiLibV2.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DigiLibV2.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class LivrosController : Controller
    {
        private readonly Contexto db;

        public LivrosController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: LivrosController
        public ActionResult Index(string query, string tipoPesquisa) {
            if (string.IsNullOrEmpty(query)) {
                return View(db.LIVROS.ToList());
            } else if (tipoPesquisa == "Todos") {
                return View(db.LIVROS.Where(a => a.Titulo.Contains(query) || a.Autor.Contains(query) || a.Editora.Contains(query)));
            } else if (tipoPesquisa == "PorNome") {
                return View(db.LIVROS.Where(a => a.Titulo.Contains(query)));
            } else if (tipoPesquisa == "PorAutor") {
                return View(db.LIVROS.Where(a => a.Autor.Contains(query)));
            } else if (tipoPesquisa == "PorEditora") {
                return View(db.LIVROS.Where(a => a.Editora.Contains(query)));
            }
            return View();
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
            return View( db.LIVROS.Where(a=> a.Id == id).FirstOrDefault() );
        }

        // POST: LivrosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Livros collection)
        {
            try
            {
                db.LIVROS.Update(collection);
                db.SaveChanges();
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
            db.LIVROS.Remove(db.LIVROS.Where(a => a.Id == id).FirstOrDefault() );
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
