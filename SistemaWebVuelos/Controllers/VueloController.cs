using SistemaWebVuelos.Data;
using SistemaWebVuelos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebVuelos.Controllers
{
    public class VueloController : Controller
    {

        VueloDbContext context = new VueloDbContext();
        
        public ActionResult Index()
        {
            
            var vuelos = context.Vuelos.ToList();
            return View(vuelos);
        }

        
        public ActionResult Detail(string matricula)
        {
            var vuelo = (from v in context.Vuelos.ToList() where v.Matricula == matricula select v).FirstOrDefault();

            if(vuelo != null)
            {
                return View("Detail", vuelo);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Create()
        {
            Vuelo newVuelo = new Vuelo();
            return View("Create", newVuelo);
        }

        [HttpPost]
        public ActionResult Create(Vuelo vuelo)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", vuelo);
            }
            context.Vuelos.Add(vuelo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);
            if (vuelo == null)
            {
                return HttpNotFound();
            }
            return View("Delete", vuelo);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);
            context.Vuelos.Remove(vuelo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            return View(vuelo);
        }

        [HttpPost]
        public ActionResult Edit(Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                context.Entry(vuelo).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult TraerPorDestino(string destino)
        {
            var vuelo = (from v in context.Vuelos.ToList() where v.Destino == destino select v);

            if (vuelo != null)
            {
                return View("TraerPorDestino", vuelo);
            }
            else
            {
                return HttpNotFound();
            }
        }

    }
}