using Ejemplo1Asp.Models;
using Ejemplo1Asp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class OperasBasController : Controller
    {
        // GET: OperasBas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var PeliculasService=new PeliculasServices();
            var model = PeliculasService.ObtenerPelicula();
            return View(model);
        }

        public ActionResult Sumar()
        {
            var tem = new Calculos();
            return View(tem);
        }

        [HttpPost]
        public ActionResult Sumar(Calculos calculos)
        {
            var tem= new Calculos();
            tem = calculos;
            tem.Toperacion();
            ViewBag.res=tem.Resultado;
            return View();
        }

        public RedirectToRouteResult Temporal()
        {
            /*var alumno = new Alumno() { Nombre = "Iza", edad = 65 };
            var alumno2 = new Alumno() { Nombre = "Sofia", edad = 35 };
            return Json(new List<Alumno>() { alumno, alumno2 }, JsonRequestBehavior.AllowGet);*/
            return RedirectToAction("About","Home");
        }
        public ActionResult vista()
        {
            ViewBag.Nombre = "Sofia";
            ViewData["Nom"]="Iza";
            return View();
        }
    }
}