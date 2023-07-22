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
using System.Globalization;

namespace SIS_MAT_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        ProxyAlumno.ServicioAlumnoClient alumnoService = new ProxyAlumno.ServicioAlumnoClient();
        ProxyUbigeo.ServicioUbigeoClient ubigeoService = new ProxyUbigeo.ServicioUbigeoClient();

        public ActionResult Alumnos()
        {
            List<ProxyAlumno.AlumnoDC> alumnos = alumnoService.ListarAlumnos().ToList();

            return View(alumnos);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {

            Ubigeo ubigeo = new Ubigeo();

            ubigeo.Departamentos = ubigeoService.Ubigeo_Departamentos().ToList();
            ubigeo.Provincias = ubigeoService.Ubigeo_ProvinciasDepartamento("14").ToList();
            ubigeo.Distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento("14", "01").ToList();


            AlumnoModel model = new AlumnoModel();
            AlumnoDC alumno = alumnoService.ConsultarAlumno(id);

            model.Alumno = alumno;
            model.Ubigeo = ubigeo;

            return View(model);
        }



        public JsonResult Ubigeo_ProvinciasDepartamento(string strIdDepartamento)
        {
            try
            {

                List<Ubigeo_ProvinciasDepartamentoDC> provincias = ubigeoService.Ubigeo_ProvinciasDepartamento(strIdDepartamento).ToList();
                return Json(provincias, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Ubigeo_DistritosProvinciaDepartamento(string strIdDepartamento, string strIdProvincia)
        {
            try
            {
                List<Ubigeo_DistritosProvinciaDepartamentoDC> distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia).ToList();
                return Json(distritos, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }



        // GET: Alumno/Create

        public ActionResult Create()
        {

            Ubigeo ubigeo = new Ubigeo();

            ubigeo.Departamentos = ubigeoService.Ubigeo_Departamentos().ToList();
            ubigeo.Provincias = ubigeoService.Ubigeo_ProvinciasDepartamento("14").ToList();
            ubigeo.Distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento("14", "01").ToList();

            AlumnoModel model = new AlumnoModel();
            model.Alumno = new AlumnoDC();
            model.Ubigeo = ubigeo;

            return View(model);
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(AlumnoModel model, HttpPostedFileBase foto, FormCollection collection)
        {
            try
            {

                model.Alumno.Usu_Registro = "ADMIN";
                model.Alumno.Id_Ubigeo = Request.Form["Ubigeo.IdDepa"] + Request.Form["Ubigeo.IdProv"] + Request.Form["Ubigeo.IdDis"];
                model.Alumno.Fec_nac = Convert.ToDateTime(model.Alumno.Fec_nac);
                model.Alumno.Est_alum = Convert.ToInt16(model.Alumno.Est_alum);

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
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", "Ocurrio un error al crear al Alumno: " + ex.Message);
            }
            return View(model);
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int Id)
        {

            Ubigeo ubigeo = new Ubigeo();

            ubigeo.Departamentos = ubigeoService.Ubigeo_Departamentos().ToList();
            ubigeo.Provincias = ubigeoService.Ubigeo_ProvinciasDepartamento("14").ToList();
            ubigeo.Distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento("14", "01").ToList();


            AlumnoModel model = new AlumnoModel();
            AlumnoDC alumno = alumnoService.ConsultarAlumno(Id);

            ubigeo.IdDepa = alumno.Id_Ubigeo?.Substring(0, 2);
            ubigeo.IdProv = alumno.Id_Ubigeo?.Substring(2, 2);
            ubigeo.IdDis = alumno.Id_Ubigeo?.Substring(4, 2);



            model.Alumno = alumno;
            model.Ubigeo = ubigeo;
            return View(model);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(AlumnoModel model, HttpPostedFileBase foto)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    AlumnoDC alumno = alumnoService.ConsultarAlumno(model.Alumno.Id_alum);
                    alumno.Usu_Ult_Mod = "ADMIN";
                    alumno.Nom_alum = model.Alumno.Nom_alum;
                    alumno.Dir_alum = model.Alumno.Dir_alum;
                    alumno.Ape_Alum = model.Alumno.Ape_Alum;
                    alumno.Email_alum = model.Alumno.Email_alum;
                    alumno.Tel_alum = model.Alumno.Tel_alum;
                    alumno.Est_alum = Convert.ToInt16(model.Alumno.Est_alum);
                    alumno.Dni_alum = model.Alumno.Dni_alum;
                    alumno.Fec_nac = Convert.ToDateTime(model.Alumno.Fec_nac);
                    alumno.Id_Ubigeo = model.Ubigeo?.IdDepa + "" + model.Ubigeo?.IdProv + "" + model.Ubigeo?.IdDis;

                    if (foto != null && foto?.ContentLength > 0)
                    {
                        using (var binaryReader = new BinaryReader(foto.InputStream))
                        {
                            alumno.Foto_alum = binaryReader.ReadBytes(foto.ContentLength);
                        }
                    }

                    alumnoService.ActualizarAlumno(alumno);

                }
                else
                {
                    ModelState.AddModelError("", "No se puede editar, contacte IT");
                }


                return RedirectToAction("Alumnos");
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

                alumnoService.EliminarAlumno(id);

                return RedirectToAction("Alumnos");
            }
            catch
            {
                return View();
            }
        }
    }
}
