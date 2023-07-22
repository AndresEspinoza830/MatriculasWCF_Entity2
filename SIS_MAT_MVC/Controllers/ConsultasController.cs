using SIS_MAT_MVC.ProxyConsultas;
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


				public ActionResult Index()
        {

			         ViewBag.Alumnos = AlumnosLista();
               ViewBag.Cuotas = new List<CuotaDC>();
			      return View();
        }


        private List<SelectListItem> AlumnosLista() {
			      List<ProxyAlumno.AlumnoDC> alumnosDC = new List<ProxyAlumno.AlumnoDC>();
			      alumnosDC = alumnoService.ListarAlumnos().ToList();

			      List<SelectListItem> listaAlumnos = alumnosDC
				      .Select(a => new SelectListItem
				      {
					      Value = a.Id_alum.ToString(),
					      Text = a.Nom_alum + " " + a.Ape_Alum
				      })
				      .ToList();

             return listaAlumnos;
		      }


				public ActionResult CuotasPendientes(CuotaDC model)
        {

			      ViewBag.Cuotas = consultasService.ListarCuotasPendientesAlumnos(Convert.ToInt16(model.Id_alum)).ToList();
            ViewBag.Alumnos =AlumnosLista();

			     return View("Index");
        }

     
        public ActionResult Matriculados()
        {

			      ViewBag.Matriculados = new List<MatriculadoDC>();
			      return View();
        }


        public ActionResult ConsultaMatriculados(DateTime fechaInicio, DateTime fechaFin) {


			    if (fechaInicio != null && fechaFin != null)
			    {
				    ViewBag.Matriculados = consultasService.ListarMatriculadosFechas(fechaInicio, fechaFin).ToList();
			    }

          return View("Matriculados");
        }


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
