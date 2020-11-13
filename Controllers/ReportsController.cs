using ProyectoASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoASPMVC.Controllers
{
    public class ReportsController : Controller
    {
        UniversidadEntities db = new UniversidadEntities();
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resumen()
        {
            ViewBag.cantAlumnos = db.Alumno.Count();
            ViewBag.minPromedio = db.Alumno.Min(alumno => alumno.PromedioNota);
            ViewBag.maxPromedio = db.Alumno.Max(alumno => alumno.PromedioNota);
            ViewBag.proPromedio = db.Alumno.Average(alumno => alumno.PromedioNota);
            ViewBag.tocayo = db.Alumno.Where(alumno => alumno.Nombre.Contains("Mateo")).Count();

            ViewBag.Datos = "Datos para el reporte";
            return View();
        }
    }
}