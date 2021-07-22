using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebVuelos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FechaHora = DateTime.Now.ToLongDateString();
            ViewData["msj"] = "Hola Bienvenido al Sistema Web Vuelos";
            return View("Index");
        }
    }
}