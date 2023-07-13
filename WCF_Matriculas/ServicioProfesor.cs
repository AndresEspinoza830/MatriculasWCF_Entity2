using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProfesor" en el código y en el archivo de configuración a la vez.
    public class ServicioProfesor : IServicioProfesor
    {
        public ProfesorDC ConsultarProfesor(int idProfe)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                ProfesorDC objProfesorDC = new ProfesorDC();

                vw_VistaProfesores objConsulta = (from MiProfesor in MisMatriculas.vw_VistaProfesores
                                                  where MiProfesor.Id_profe == idProfe
                                                  select MiProfesor
                                           ).FirstOrDefault();

                //Cargamos la instania ProfesorDC
                objProfesorDC.Id_profe = objConsulta.Id_profe;
                objProfesorDC.Id_Ubigeo = objConsulta.Id_Ubigeo;
                objProfesorDC.Nom_profe = objConsulta.Nom_profe;
                objProfesorDC.Ape_profe = objConsulta.Ape_profe;
                objProfesorDC.Sexo = objConsulta.Sexo;
                objProfesorDC.Id_esp = objConsulta.Id_esp;
                objProfesorDC.Des_esp = objConsulta.Des_esp;
                objProfesorDC.Foto_profe = objConsulta.Foto_profe;
                objProfesorDC.Dni_profe = objConsulta.Dni_profe;
                objProfesorDC.Tel_profe = objConsulta.Tel_profe;
                objProfesorDC.Email_profe = objConsulta.Email_profe;
                objProfesorDC.Fec_reg = Convert.ToDateTime(objConsulta.Fec_reg);
                objProfesorDC.Usu_Registro = objConsulta.Usu_Registro;
                objProfesorDC.Fec_Ult_Mod = Convert.ToDateTime(objConsulta.Fec_Ult_Mod);
                objProfesorDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                objProfesorDC.Est_prof = objConsulta.Est_prof;
                objProfesorDC.Estado = objConsulta.Estado;
                objProfesorDC.Provincia = objConsulta.Provincia;
                objProfesorDC.Distrito = objConsulta.Distrito;
                objProfesorDC.Departamento = objConsulta.Departamento;



                return objProfesorDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProfesorDC> ListarProfesores()
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<ProfesorDC> objLista = new List<ProfesorDC>();

                var query = (from miProfesor in MisMatriculas.vw_VistaProfesores
                             orderby miProfesor.Id_profe
                             select miProfesor
                             );

                foreach (var objConsulta in query)
                {

                    ProfesorDC objProfesorDC = new ProfesorDC();

                    objProfesorDC.Id_profe = objConsulta.Id_profe;
                    objProfesorDC.Id_Ubigeo = objConsulta.Id_Ubigeo;
                    objProfesorDC.Nom_profe = objConsulta.Nom_profe;
                    objProfesorDC.Ape_profe = objConsulta.Ape_profe;
                    objProfesorDC.Sexo = objConsulta.Sexo;
                    objProfesorDC.Id_esp = objConsulta.Id_esp;
                    objProfesorDC.Des_esp = objConsulta.Des_esp;
                    objProfesorDC.Foto_profe = objConsulta.Foto_profe;
                    objProfesorDC.Dni_profe = objConsulta.Dni_profe;
                    objProfesorDC.Tel_profe = objConsulta.Tel_profe;
                    objProfesorDC.Email_profe = objConsulta.Email_profe;
                    objProfesorDC.Fec_reg = Convert.ToDateTime(objConsulta.Fec_reg);
                    objProfesorDC.Usu_Registro = objConsulta.Usu_Registro;
                    objProfesorDC.Fec_Ult_Mod = Convert.ToDateTime(objConsulta.Fec_Ult_Mod);
                    objProfesorDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                    objProfesorDC.Estado = objConsulta.Estado;
                    objProfesorDC.Provincia = objConsulta.Provincia;
                    objProfesorDC.Distrito = objConsulta.Distrito;
                    objProfesorDC.Departamento = objConsulta.Departamento;

                    objLista.Add(objProfesorDC);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarProfesor(int idProfe)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                MisMatriculas.usp_delete_profesor(idProfe);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarProfesor(ProfesorDC objProfesorDC)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                MisMatriculas.usp_insert_profesor(objProfesorDC.Id_Ubigeo, objProfesorDC.Id_esp, objProfesorDC.Sexo,
                    objProfesorDC.Foto_profe, objProfesorDC.Dni_profe, objProfesorDC.Nom_profe, objProfesorDC.Ape_profe, objProfesorDC.Tel_profe,
                    objProfesorDC.Email_profe, objProfesorDC.Usu_Registro, objProfesorDC.Est_prof
                    );
                return true;
            }
            catch (EntityException ex)
            {
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
                throw new Exception(ex.Message);

            }
        }

        public Boolean ActualizarProfesor(ProfesorDC objProfesorDC)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                MisMatriculas.usp_update_profesor(objProfesorDC.Id_profe, objProfesorDC.Id_Ubigeo, objProfesorDC.Id_esp,
                    objProfesorDC.Sexo, objProfesorDC.Foto_profe, objProfesorDC.Dni_profe, objProfesorDC.Nom_profe, objProfesorDC.Ape_profe, objProfesorDC.Tel_profe,
                    objProfesorDC.Email_profe, objProfesorDC.Usu_Ult_Mod, objProfesorDC.Est_prof
                    );
                return true;
            }
            catch (EntityException ex)
            {
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
                throw new Exception(ex.Message);

            }
        }


    }
}
