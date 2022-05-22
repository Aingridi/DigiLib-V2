using DigiLib_V2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLib_V2.Controllers
{
    public class LivrosController : Controller
    {
        public static List<Livro> lsLivros = new List<Livro>();
        public IActionResult Index()
        {
            return View(lsLivros);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Livro objeto) 
        {
            lsLivros.Add(objeto);
            return RedirectToAction("Index");

        }
    }
}
