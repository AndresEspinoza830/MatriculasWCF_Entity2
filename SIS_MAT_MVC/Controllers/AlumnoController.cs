using SIS_MAT_MVC.Models;
using SIS_MAT_MVC.ProxyAlumno;
using SIS_MAT_MVC.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using SIS_MAT_MVC.Models;

namespace SIS_MAT_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        ProxyAlumno.ServicioAlumnoClient alumnoService = new ProxyAlumno.ServicioAlumnoClient();
        ProxyUbigeo.ServicioUbigeoClient ubigeoService = new ProxyUbigeo.ServicioUbigeoClient();
        ProxyAlumno.AlumnoDCINSERTS alumnoToInsert = new ProxyAlumno.AlumnoDCINSERTS();

        public ActionResult Alumnos()
        {
            List<ProxyAlumno.AlumnoDC> alumnos = alumnoService.ListarAlumnos().ToList();


            return View(alumnos);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {

            Ubigeo ubigeo = new Ubigeo();

            ubigeo.Departamentos = ubigeoService.Ubigeo_Departamentos().ToList();
            ubigeo.Provincias = ubigeoService.Ubigeo_ProvinciasDepartamento("14").ToList();
            ubigeo.Distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento("14", "01").ToList();


            AlumnoModel model = new AlumnoModel();
            model.Alumno = new AlumnoDCINSERTS();

            return View(model);
        }




        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(AlumnoModel model, HttpPostedFileBase foto)
        {
            try
            {
						  AlumnoDCINSERTS alumno = new AlumnoDCINSERTS();
				      string[] array = collection["Ubigeo"].Split(',');

			        alumno.Ape_Alum = collection["Alumno.Ape_alum"];
						  alumno.Nom_alum = collection["Alumno.Nom_alum"];
						  alumno.Dir_alum = collection["Alumno.Dir_alum"];
						  alumno.Id_Ubigeo = array[0] + array[1] + array[2];
						  alumno.Dni_alum = collection["Alumno.Dni_alum"];
						  alumno.Foto_alum = null;
						  alumno.Fec_nac = Convert.ToDateTime(alumno.Fec_nac);
						  alumno.Sexo = collection["Alumno.Sexo"];
						  alumno.Tel_alum = collection["Alumno.Tel_alum"];
						  alumno.Email_alum = collection["Alumno.Email_alum"];
						  alumno.Usu_Registro = "ADMIN";
						  alumno.Est_alum = 1;


				      HttpPostedFileBase file = Request.Files["Foto_alum"];

              if (file != null && file.ContentLength > 0)
              {
                byte[] fotoBytes;
                using (var binaryReader = new BinaryReader(file.InputStream))
                {
                  fotoBytes = binaryReader.ReadBytes(file.ContentLength);
                }

				alumno.Foto_alum = System.IO.File.ReadAllBytes(filePath);

				        alumnoService.InsertarAlumno(alumno);

				        return RedirectToAction("Alumnos");
            }
            catch
            {
                ModelState.AddModelError("Error", "Ocurrio un error al crear al Alumno: " + ex.Message);
            }
            return View(model);
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alumno/Edit/5
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

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumno/Delete/5
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
