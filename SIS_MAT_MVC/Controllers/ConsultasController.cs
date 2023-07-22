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
        ProxyCarrera.ServicioCarreraClient carreraService = new ProxyCarrera.ServicioCarreraClient();

        // GET: Consultas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta1()
        {
            // Lógica para la consulta 1
            return View();
        }

        public ActionResult Consulta2()
        {
            // Lógica para la consulta 2
            return View();
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

    }
}