using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIS_MAT_MVC.Controllers
{
    public class ConsultasController : Controller
    {



        ProxyConsultas.ServicioConsultasClient consultasService = new ProxyConsultas.ServicioConsultasClient();
        ProxyAlumno.ServicioAlumnoClient alumnoService = new ProxyAlumno.ServicioAlumnoClient();


        // GET: Consultas
        public ActionResult Index()
        {
			        List<ProxyAlumno.AlumnoDC> alumnos = alumnoService.ListarAlumnos().ToList();

			        List<SelectListItem> listaAlumnos = alumnos
                .Select(a => new SelectListItem
                {
	                Value = a.Id_alum.ToString(),
	                Text = a.Nom_alum + " " + a.Ape_Alum
                })
                .ToList();

			         ViewBag.Alumnos = listaAlumnos;
			      return View();
        }

        // GET: Consultas/Details/5
        public ActionResult ConsultarCuotasPendientes(int id)
        {
            return View();
        }

        // GET: Consultas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consultas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Consultas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consultas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Consultas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
