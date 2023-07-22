using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {
        public AlumnoDC ConsultarAlumno(int id)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                AlumnoDC objAlumnoDC = new AlumnoDC();

                //Obtenemos con LINQ el alumno consultado
                vw_VistaAlumnos objConsulta = (from miAlumno in MisMatriculas.vw_VistaAlumnos
                                               where miAlumno.Id_alum == id
                                               select miAlumno).FirstOrDefault();

                //Cargamos la instancia AlumnoDC
                objAlumnoDC.Id_alum = objConsulta.Id_alum;
                objAlumnoDC.Nom_alum = objConsulta.Nom_alum;
                objAlumnoDC.Ape_Alum = objConsulta.Ape_alum;
                objAlumnoDC.Dni_alum = objConsulta.Dni_alum;
                objAlumnoDC.Dir_alum = objConsulta.Dir_alum;
                objAlumnoDC.Email_alum = objConsulta.Email_alum;
                objAlumnoDC.Fec_nac = Convert.ToDateTime(objConsulta.Fec_nac);
                objAlumnoDC.Sexo = objConsulta.Sexo;
                objAlumnoDC.Tel_alum = objConsulta.Tel_alum;
                objAlumnoDC.Est_alum = Convert.ToInt16(objConsulta.Est_alum);
                objAlumnoDC.Estado = objConsulta.Estado;

                objAlumnoDC.Foto_alum = objConsulta.Foto_alum;

                objAlumnoDC.Id_Ubigeo = objConsulta.Id_Ubigeo;
                objAlumnoDC.Provincia = objConsulta.Provincia;
                objAlumnoDC.Distrito = objConsulta.Distrito;
                objAlumnoDC.Departamento = objConsulta.Departamento;

                objAlumnoDC.Usu_Registro = objConsulta.Usu_Registro;
                objAlumnoDC.Fec_reg = Convert.ToDateTime(objConsulta.Fec_reg);
                objAlumnoDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                objAlumnoDC.Fec_Ult_Mod = Convert.ToDateTime(objConsulta.Fec_Ult_Mod);


                return objAlumnoDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoDC> ListarAlumnos()
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<AlumnoDC> objLista = new List<AlumnoDC>();

                //Con LINQ obtenemos el listado...
                var query = (from miAlumno in MisMatriculas.vw_VistaAlumnos
                             orderby miAlumno.Id_alum
                             select miAlumno
                             );

                foreach (var objConsulta in query)
                {

                    AlumnoDC objAlumnoDC = new AlumnoDC();

                    objAlumnoDC.Id_alum = objConsulta.Id_alum;
                    objAlumnoDC.Nom_alum = objConsulta.Nom_alum;
                    objAlumnoDC.Ape_Alum = objConsulta.Ape_alum;
                    objAlumnoDC.Dni_alum = objConsulta.Dni_alum;
                    objAlumnoDC.Dir_alum = objConsulta.Dir_alum;
                    objAlumnoDC.Email_alum = objConsulta.Email_alum;
                    objAlumnoDC.Fec_nac = Convert.ToDateTime(objConsulta.Fec_nac);
                    objAlumnoDC.Sexo = objConsulta.Sexo;
                    objAlumnoDC.Tel_alum = objConsulta.Tel_alum;
                    objAlumnoDC.Estado = objConsulta.Estado;

                    objAlumnoDC.Foto_alum = objConsulta.Foto_alum;

                    objAlumnoDC.Id_Ubigeo = objConsulta.Id_Ubigeo;
                    objAlumnoDC.Provincia = objConsulta.Provincia;
                    objAlumnoDC.Distrito = objConsulta.Distrito;
                    objAlumnoDC.Departamento = objConsulta.Departamento;

                    objAlumnoDC.Usu_Registro = objConsulta.Usu_Registro;
                    objAlumnoDC.Fec_reg = Convert.ToDateTime(objConsulta.Fec_reg);
                    objAlumnoDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                    objAlumnoDC.Fec_Ult_Mod = Convert.ToDateTime(objConsulta.Fec_Ult_Mod);

                    objLista.Add(objAlumnoDC);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarAlumno(AlumnoDC objAlumnoDC)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();

				        MisMatriculas.usp_insert_alumno(objAlumnoDC.Id_Ubigeo, objAlumnoDC.Dni_alum, objAlumnoDC.Foto_alum, objAlumnoDC.Fec_nac, objAlumnoDC.Sexo,
                    objAlumnoDC.Nom_alum, objAlumnoDC.Ape_Alum, objAlumnoDC.Dir_alum, objAlumnoDC.Tel_alum, objAlumnoDC.Email_alum,
                    objAlumnoDC.Usu_Registro, objAlumnoDC.Est_alum);
                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarAlumno(AlumnoDC objAlumnoDC)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                MisMatriculas.usp_update_alumno(objAlumnoDC.Id_alum, objAlumnoDC.Id_Ubigeo, objAlumnoDC.Dni_alum, objAlumnoDC.Foto_alum, objAlumnoDC.Fec_nac,
                    objAlumnoDC.Sexo, objAlumnoDC.Nom_alum, objAlumnoDC.Ape_Alum, objAlumnoDC.Dir_alum, objAlumnoDC.Tel_alum,
                    objAlumnoDC.Email_alum, objAlumnoDC.Usu_Ult_Mod, objAlumnoDC.Est_alum);
                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarAlumno(int id)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                MisMatriculas.usp_delete_alumno(id);
                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
