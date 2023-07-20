using SIS_MAT_MVC.Models;
using SIS_MAT_MVC.ProxyEspecialidad;
using SIS_MAT_MVC.ProxyProfesor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIS_MAT_MVC.Controllers
{
    public class ProfesorController : Controller
    {
        
        ProxyProfesor.ServicioProfesorClient profesorService = new ProxyProfesor.ServicioProfesorClient();
		    ProxyEspecialidad.ServicioEspecialidadClient especialidadService = new ProxyEspecialidad.ServicioEspecialidadClient();
		    ProxyUbigeo.ServicioUbigeoClient ubigeoService = new ProxyUbigeo.ServicioUbigeoClient();
	

		public ActionResult Index()
        {

            List<ProfesorDC> profes = profesorService.ListarProfesores().ToList();
            return View(profes);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {

            Especialidad especialidad = new Especialidad();
			      Ubigeo ubigeo = new Ubigeo();

			      ubigeo.Departamentos = ubigeoService.Ubigeo_Departamentos().ToList();
			      ubigeo.Provincias = ubigeoService.Ubigeo_ProvinciasDepartamento("14").ToList();
			      ubigeo.Distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento("14", "01").ToList();

			      especialidad.Especialidades = especialidadService.ListarEspecialidad().ToList();


			      ProfesorModel profesor = new ProfesorModel();
			      profesor.Profesor = new ProfesorDC();
			      profesor.Especialidad = especialidad;
            profesor.Ubigeo = ubigeo;

            return View(profesor);
        }

        // POST: Profesor/Create
        [HttpPost]
        public ActionResult Create(ProfesorModel model, HttpPostedFileBase foto, FormCollection collection)
        {
            try
            {
				        model.Profesor.Usu_Registro = "ADMIN";
                model.Profesor.Id_esp =1;


				        if (foto != null && foto.ContentLength > 0)
				        {
					        using (var binaryReader = new BinaryReader(foto.InputStream))
					        {
						        model.Profesor.Foto_profe = binaryReader.ReadBytes(foto.ContentLength);
					        }
				        }
				        else
				        {
					        string basePath = AppDomain.CurrentDomain.BaseDirectory;
					        string defaultImagePath = Path.Combine(basePath, @".\Img\defaultUser.jpeg");
					        model.Profesor.Foto_profe = System.IO.File.ReadAllBytes(defaultImagePath);
				        }


                if (profesorService.InsertarProfesor(model.Profesor)) {
                  return RedirectToAction("Index");
				        } else {
                  ModelState.AddModelError("", "Error, no se puede crear profesor contacte IT");
                }

				        return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profesor/Edit/5
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

        // GET: Profesor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profesor/Delete/5
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
