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
        ProxyCarrera.ServicioCarreraClient carreraService = new ProxyCarrera.ServicioCarreraClient();


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
            ViewBag.Alumnos = AlumnosLista();

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


        public ActionResult Consulta3()
        {
            List<ProxyConsultas.BloqueDC> bloques = new List<ProxyConsultas.BloqueDC>();
            return View(bloques);
        }

        [HttpPost]
        public ActionResult Consulta3(Int16 Vacantes)
        {

            List<ProxyConsultas.BloqueDC> listaResultado = consultasService.ListarBloquesVacantes(Vacantes).ToList();


            return View("Consulta3", listaResultado);
        }


        public ActionResult Consulta4()
        {
            List<ProxyConsultas.MatriculadoDC> matriculados = new List<ProxyConsultas.MatriculadoDC>();

            List<ProxyCarrera.CarreraDC> listaCarreras = carreraService.ListarCarrera().ToList();

            ViewBag.Carreras = listaCarreras;


            return View(matriculados);
        }

        [HttpPost]
        public ActionResult Consulta4(int Id_carrera)
        {

            List<ProxyConsultas.MatriculadoDC> listaResultado = consultasService.ListarAlumnosCarrera(Id_carrera).ToList();

            List<ProxyCarrera.CarreraDC> listaCarreras = carreraService.ListarCarrera().ToList();
            ViewBag.Carreras = listaCarreras;


            return View("Consulta4", listaResultado);
        }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        }

        // POST: Consultas/Edit/5
        [HttpPost]
            {
                // TODO: Add update logic here



        // POST: Consultas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

        }

    }
}
