using SIS_MAT_MVC.Models;
using SIS_MAT_MVC.ProxyCurso;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIS_MAT_MVC.Controllers
{
    public class CursoController : Controller
    {

        ProxyCurso.ServicioCursoClient cursoService = new ProxyCurso.ServicioCursoClient();

        // GET: Curso
        public ActionResult Cursos()
        {
            List<ProxyCurso.CursoDC> cursos = cursoService.ListarCursos().ToList();

            return View(cursos);
        }

        // GET: Curso/Details/5
        public ActionResult Details(int id)
        {
            CursoModel model = new CursoModel();
            CursoDC curso = cursoService.ConsultarCurso(id);

            model.Curso = curso;

            return View(model);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            CursoModel model = new CursoModel();
            model.Curso = new CursoDC();


            return View(model);
        }

        // POST: Curso/Create
        [HttpPost]
        public ActionResult Create(CursoModel model, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                model.Curso.Usu_Registro = "ADMIN";
                model.Curso.Est_curso = 1;
                model.Curso.Fec_reg = DateTime.Now;

                bool isInserted = cursoService.InsertarCurso(model.Curso);
                if (isInserted)
                {
                    return RedirectToAction("Cursos");
                }
                else
                {
                    ModelState.AddModelError("", "Fallo al crear el curso.");
                }

                return RedirectToAction("Cursos");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", "Ocurrio un error al crear el Curso: " + ex.Message);
            }
            return View(model);
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int id)
        {

            CursoModel model = new CursoModel();
            CursoDC curso = cursoService.ConsultarCurso(id);

            model.Curso = curso;
            return View(model);
        }

        // POST: Curso/Edit/5
        [HttpPost]
        public ActionResult Edit(CursoModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {

                    CursoDC curso = cursoService.ConsultarCurso(model.Curso.Id_curso);
                    curso.Usu_Ult_Mod = "ADMIN";
                    curso.Fec_Ult_Mod = DateTime.Now;
                    curso.Des_curso = model.Curso.Des_curso;
                    curso.Est_curso = Convert.ToInt16(model.Curso.Est_curso);
                    cursoService.ActualizarCurso(curso);

                }
                else
                {
                    ModelState.AddModelError("", "No se puede editar, contacte IT");
                }
                return RedirectToAction("Cursos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Curso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                cursoService.EliminarCurso(id);

                return RedirectToAction("Cursos");
            }
            catch
            {
                return View();
            }
        }
    }
}
