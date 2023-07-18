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
                FormCollection collection = new FormCollection();
                if (ModelState.IsValid)
                {
                    //model.Alumno.Id_Ubigeo = collection["IdDepa"] + collection["IdProv"] + collection["IdDis"];
                    model.Alumno.Id_Ubigeo = "010114";
                    //Foto
                    if (foto != null && foto.ContentLength > 0)
                    {
                        using (var binaryReader = new BinaryReader(foto.InputStream))
                        {
                            model.Alumno.Foto_alum = binaryReader.ReadBytes(foto.ContentLength);
                        }
                    }
                    else
                    {
                        string basePath = AppDomain.CurrentDomain.BaseDirectory;
                        string defaultImagePath = Path.Combine(basePath, @".\Img\defaultUser.jpeg");
                        model.Alumno.Foto_alum = System.IO.File.ReadAllBytes(defaultImagePath);
                    }

                    model.Alumno.Usu_Registro = "ADMIN";

                    bool isInserted = alumnoService.InsertarAlumno(model.Alumno);


                    if (isInserted)
                    {
                        return RedirectToAction("Alumnos");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Fallo al crear al alumno.");
                    }
                }
            }
            catch (Exception ex)
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
