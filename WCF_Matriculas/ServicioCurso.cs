using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    public class ServicioCurso : IServicioCurso
    {
        public List<CursoDC> ListarCursos()
        {
            try
            {
                SISTEMA_MATRICULASEntities db = new SISTEMA_MATRICULASEntities();
                List<CursoDC> cursos = new List<CursoDC>();

                //var query = (from curso in db.Tb_CURSO select curso);
                var query = db.usp_consultar_cursos();

                foreach (var curso in query)
                {
                    CursoDC cursoDC = new CursoDC();

                    cursoDC.Id_curso = curso.Id_curso;
                    cursoDC.Des_curso = curso.Des_curso;
                    cursoDC.Usu_Registro = curso.Usu_Registro;
                    //cursoDC.Est_curso = Convert.ToInt16(curso.Est_curso);
                    cursoDC.Fec_reg = Convert.ToDateTime(curso.Fec_reg);
                    cursoDC.Fec_Ult_Mod = Convert.ToDateTime(curso.Fec_Ult_Mod);
                    cursoDC.Estado = curso.Estado;
                    cursoDC.Est_curso = (cursoDC.Estado == "Activo") ? 1 : 0;
                    cursos.Add(cursoDC);
                }

                return cursos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean InsertarCurso(CursoDC cursoEntrie)
        {
            try
            {
                SISTEMA_MATRICULASEntities db = new SISTEMA_MATRICULASEntities();
                db.usp_insert_curso(cursoEntrie.Des_curso, cursoEntrie.Usu_Registro, cursoEntrie.Fec_reg, cursoEntrie.Est_curso);
                db.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean ActualizarCurso(CursoDC cursoEntrie)
        {
            try
            {
                SISTEMA_MATRICULASEntities db = new SISTEMA_MATRICULASEntities();
                db.usp_update_curso(cursoEntrie.Id_curso, cursoEntrie.Des_curso, cursoEntrie.Usu_Ult_Mod, cursoEntrie.Fec_Ult_Mod, cursoEntrie.Est_curso);
                db.SaveChanges();

                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public CursoDC ConsultarCurso(int idCurso)
        {
            SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
            CursoDC objCursoDC = new CursoDC();

            vw_VistaCursos objConsulta = (from MiCurso in MisMatriculas.vw_VistaCursos
                                          where MiCurso.Id_curso == idCurso
                                          select MiCurso
                                       ).FirstOrDefault();

            //Cargamos la instancia CursoDC
            objCursoDC.Id_curso = objConsulta.Id_curso;
            objCursoDC.Des_curso = objConsulta.Des_curso;
            objCursoDC.Fec_reg = Convert.ToDateTime(objConsulta.Fec_reg);
            objCursoDC.Usu_Ult_Mod = (objConsulta.Usu_Ult_Mod);
            objCursoDC.Fec_Ult_Mod = Convert.ToDateTime(objConsulta.Fec_Ult_Mod);
            objCursoDC.Estado = objConsulta.Estado;
            objCursoDC.Usu_Registro = objConsulta.Usu_Registro;
            objCursoDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
            objCursoDC.Est_curso = (objConsulta.Estado == "Activo") ? 1 : 0;



            return objCursoDC;
        }

        public bool EliminarCurso(int idCurso)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                MisMatriculas.usp_delete_curso(idCurso);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
    }
}
