using SIS_MAT_MVC.Models;
using SIS_MAT_MVC.ProxyAlumno;
using SIS_MAT_MVC.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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


			Console.WriteLine("aaaaaaaaaaaaa");
			Trace.WriteLine("trace");


			Debug.WriteLine("debuggg");

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


            AlumnoModel alumno = new AlumnoModel
            {
              Alumno = new ProxyAlumno.AlumnoDCINSERTS(),
              Ubigeo = ubigeo
            };

            return View(alumno);
        }




		// POST: Alumno/Create
		[HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
				/*
						AlumnoDCINSERTS alumno = new AlumnoDCINSERTS();
						alumno.Ape_Alum = collection["Ape_alum"];
						alumno.Nom_alum = collection["Nom_alum"];
						alumno.Dir_alum = collection["Dir_alum"];
						alumno.Id_Ubigeo = collection["IdDepa"] + collection["IdProv"] + collection["IdDis"];
						alumno.Dni_alum = collection["Dni_alum"];
						alumno.Foto_alum = null;
						alumno.Fec_nac = Convert.ToDateTime(alumno.Fec_nac);
						alumno.Sexo = collection["Sexo"];
						alumno.Tel_alum = collection["Tel_alum"];
						alumno.Email_alum = collection["Email_alum"];
						alumno.Usu_Registro = "ADMIN";
						alumno.Est_alum = 1; */

				     AlumnoDCINSERTS alumno = new AlumnoDCINSERTS();
				     alumno.Ape_Alum = "Apellido";
				     alumno.Nom_alum = "Nombre";
				     alumno.Dir_alum = "Dirección";
				     alumno.Id_Ubigeo = "140101";
            
				     alumno.Dni_alum = "12345678";

				
				     alumno.Fec_nac = DateTime.Now; // Fecha actual
				     alumno.Sexo = "M";
				     alumno.Tel_alum = "123456789";
				     alumno.Email_alum = "correo@example.com";
				     alumno.Usu_Registro = "ADMIN";
				     alumno.Est_alum = 1;


				string basePath = AppDomain.CurrentDomain.BaseDirectory;
				string filePath = Path.Combine(basePath, @"..\Img\defaultUser.jpeg");

				alumno.Foto_alum = System.IO.File.ReadAllBytes(filePath);

				        alumnoService.InsertarAlumno(alumno);

				        return RedirectToAction("Alumnos");
            }
            catch
            {
                return View();
            }
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
