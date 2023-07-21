using SIS_MAT_MVC.Models;
using SIS_MAT_MVC.ProxyEspecialidad;
using SIS_MAT_MVC.ProxyProfesor;
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
			    ProfesorDC profesor = profesorService.ConsultarProfesor(id);

			    return View(profesor);
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



        // POST: Profesor/Create
        [HttpPost]
        public ActionResult Create(ProfesorModel model, HttpPostedFileBase foto, FormCollection collection)
        {
            try
            {
                model.Profesor.Usu_Registro = "ADMIN";
                model.Profesor.Id_esp = Convert.ToInt16(collection["Especialidad.Especialidades"]);
                model.Profesor.Id_Ubigeo = Request.Form["Ubigeo.IdDepa"] + Request.Form["Ubigeo.IdProv"] + Request.Form["Ubigeo.IdDis"];


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


                if (profesorService.InsertarProfesor(model.Profesor))
                {
                    return RedirectToAction("Index");
                }
                else
                {
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
            ProfesorModel profesor = new ProfesorModel();
            ProfesorDC profesorDC = profesorService.ConsultarProfesor(id);


            Especialidad especialidad = new Especialidad();
            Ubigeo ubigeo = new Ubigeo();

            ubigeo.Departamentos = ubigeoService.Ubigeo_Departamentos().ToList();
            ubigeo.Provincias = ubigeoService.Ubigeo_ProvinciasDepartamento("14").ToList();
            ubigeo.Distritos = ubigeoService.Ubigeo_DistritosProvinciaDepartamento("14", "01").ToList();


            ubigeo.IdDepa = profesorDC.Id_Ubigeo?.Substring(0, 2);
            ubigeo.IdProv = profesorDC.Id_Ubigeo?.Substring(2, 2);
            ubigeo.IdDis = profesorDC.Id_Ubigeo?.Substring(4, 2);

            especialidad.Especialidades = especialidadService.ListarEspecialidad().ToList();

            profesor.Profesor = profesorDC;
            profesor.Ubigeo = ubigeo;
            profesor.Especialidad = especialidad;

            return View(profesor);
        }

        // POST: Profesor/Edit/5
        [HttpPost]
        public ActionResult Edit(ProfesorModel model, HttpPostedFileBase foto)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    ProfesorDC profe = profesorService.ConsultarProfesor(model.Profesor.Id_profe);

                    profe.Nom_profe = model.Profesor.Nom_profe;
                    profe.Email_profe = model.Profesor.Email_profe;
                    profe.Ape_profe = model.Profesor.Ape_profe;
                    profe.Est_prof = Convert.ToInt16(model.Profesor.Est_prof);
                    profe.Sexo = model.Profesor.Sexo;
                    profe.Tel_profe = model.Profesor.Tel_profe;
                    profe.Usu_Registro = "ADMIN";
                    profe.Id_Ubigeo = model.Ubigeo.IdDepa + model.Ubigeo.IdProv + model.Ubigeo.IdDis;
                    profe.Id_esp = model.Profesor.Id_esp;



                    if (foto != null && foto?.ContentLength > 0)
                    {
                        using (var binaryReader = new BinaryReader(foto.InputStream))
                        {
                            profe.Foto_profe = binaryReader.ReadBytes(foto.ContentLength);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "No se puede editar, contacte IT");
                    }

                    profesorService.ActualizarProfesor(profe);


                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "No se puede editar, contacte IT");
                    return RedirectToAction("Index");
                }
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

                profesorService.EliminarProfesor(id);

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
