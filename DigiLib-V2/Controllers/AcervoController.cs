using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DigiLibV2.Controllers 
    {

         [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class AcervoController : Controller 
        {
        private readonly Contexto db;
        public AcervoController(Contexto contexto) {
            db = contexto;
        }

        public IActionResult Index() {
            return View();
        }
    }
}
