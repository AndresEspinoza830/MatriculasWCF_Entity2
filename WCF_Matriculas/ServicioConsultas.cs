using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data.Entity.Core.EntityClient;
using System.Text;
using System.Data;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioConsultas" en el código y en el archivo de configuración a la vez.
    public class ServicioConsultas : IServicioConsultas
    {
        public List<CuotaDC> ListarCuotasPendientesAlumnos(int Id_Alum)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<CuotaDC> objLista = new List<CuotaDC>();

                var query = (from miCuota in MisMatriculas.vw_VistaCuotas
                             where miCuota.Id_alum == Id_Alum && miCuota.Est_cuota == 1
                             select miCuota);

                foreach (var resultado in query)
                {
                    CuotaDC objCuotaDC = new CuotaDC();

                    objCuotaDC.Id_cuota = resultado.Id_cuota;
                    objCuotaDC.Id_alum = resultado.Id_alum;
                    objCuotaDC.NombreCompleto = resultado.NombreCompleto;
                    objCuotaDC.Ndoc_cuota = resultado.Ndoc_cuota;
                    objCuotaDC.Fecha_pago = Convert.ToDateTime(resultado.Fecha_pago);
                    objCuotaDC.Est_cuota = resultado.Est_cuota;
                    objCuotaDC.EstadoCuota = resultado.EstadoCuota;
                    objCuotaDC.Tip_cuota = resultado.Tip_cuota;
                    objCuotaDC.TipoCuota = resultado.TipoCuota;
                    objCuotaDC.Vencimiento = Convert.ToDateTime(resultado.Vencimiento);
                    objCuotaDC.Precio_cuota = Convert.ToDecimal(resultado.Precio_cuota);

                    objLista.Add(objCuotaDC);
                }


                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MatriculadoDC> ListarMatriculadosFechas(DateTime fecIni, DateTime fecFin)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<MatriculadoDC> objLista = new List<MatriculadoDC>();

                var query = MisMatriculas.usp_ConsultarMatriculadosEntreFechas(fecIni, fecFin);
                foreach (var resultado in query)
                {
                    MatriculadoDC objMatriculadoDC = new MatriculadoDC();

                    objMatriculadoDC.Id_alum = resultado.Id_alum;
                    objMatriculadoDC.Nom_alum = resultado.Nom_alum;
                    objMatriculadoDC.Ape_Alum = resultado.Ape_alum;
                    objMatriculadoDC.Dni_alum = resultado.Dni_alum;
                    objMatriculadoDC.Dir_alum = resultado.Dir_alum;
                    objMatriculadoDC.Email_alum = resultado.Email_alum;
                    objMatriculadoDC.Nom_carrera = resultado.Nom_carrera;
                    objMatriculadoDC.Des_semestre = resultado.Des_semestre;
                    objMatriculadoDC.Fec_nac = Convert.ToDateTime(resultado.Fec_nac);
                    objMatriculadoDC.Sexo = resultado.Sexo;
                    objMatriculadoDC.Tel_alum = resultado.Tel_alum;
                    //objMatriculadoDC.Est_alum = Convert.ToInt32(resultado.Est_alum);
                    objMatriculadoDC.Estado = resultado.Estado;

                    objMatriculadoDC.Id_Ubigeo = resultado.Id_Ubigeo;
                    objMatriculadoDC.Provincia = resultado.Provincia;
                    objMatriculadoDC.Distrito = resultado.Distrito;
                    objMatriculadoDC.Departamento = resultado.Departamento;

                    objMatriculadoDC.Usu_Registro = resultado.Usu_Registro;
                    objMatriculadoDC.Fec_reg = Convert.ToDateTime(resultado.Fec_reg);
                    objMatriculadoDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objMatriculadoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);

                    objLista.Add(objMatriculadoDC);

                }
                return objLista;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<MatriculadoDC> ListarAlumnosCarrera(int Id_carrera)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<MatriculadoDC> objLista = new List<MatriculadoDC>();

                var query = MisMatriculas.usp_ListarAlumnosCarrera(Id_carrera);
                foreach (var resultado in query)
                {
                    MatriculadoDC objMatriculadoDC = new MatriculadoDC();

                    objMatriculadoDC.Id_alum = resultado.Id_alum;
                    objMatriculadoDC.Nom_alum = resultado.Nom_alum;
                    objMatriculadoDC.Ape_Alum = resultado.Ape_alum;
                    objMatriculadoDC.Dni_alum = resultado.Dni_alum;
                    objMatriculadoDC.Dir_alum = resultado.Dir_alum;
                    objMatriculadoDC.Email_alum = resultado.Email_alum;
                    objMatriculadoDC.Nom_carrera = resultado.Nom_carrera;
                    objMatriculadoDC.Des_semestre = resultado.Des_semestre;
                    objMatriculadoDC.Fec_nac = Convert.ToDateTime(resultado.Fec_nac);
                    objMatriculadoDC.Sexo = resultado.Sexo;
                    objMatriculadoDC.Tel_alum = resultado.Tel_alum;
                    //objMatriculadoDC.Est_alum = Convert.ToInt32(resultado.Est_alum);
                    objMatriculadoDC.Estado = resultado.Estado;

                    objMatriculadoDC.Foto_alum = resultado.Foto_alum;

                    objMatriculadoDC.Id_Ubigeo = resultado.Id_Ubigeo;
                    objMatriculadoDC.Provincia = resultado.Provincia;
                    objMatriculadoDC.Distrito = resultado.Distrito;
                    objMatriculadoDC.Departamento = resultado.Departamento;

                    objMatriculadoDC.Usu_Registro = resultado.Usu_Registro;
                    objMatriculadoDC.Fec_reg = Convert.ToDateTime(resultado.Fec_reg);
                    objMatriculadoDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objMatriculadoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);

                    objLista.Add(objMatriculadoDC);

                }
                return objLista;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<BloqueDC> ListarBloquesVacantes(Int16 Vacantes)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<BloqueDC> objLista = new List<BloqueDC>();

                var query = MisMatriculas.usp_ListarBloquesVacantes(Vacantes);
                foreach (var resultado in query)
                {
                    BloqueDC objBloqueDC = new BloqueDC();

                    objBloqueDC.Id_bloque = resultado.Id_bloque;
                    objBloqueDC.Descripcion = resultado.Descripcion_Curso;
                    objBloqueDC.Nombre_Profesor = resultado.Nombre_Profesor;
                    objBloqueDC.Horario = resultado.Horario;
                    objBloqueDC.Tip_Bloque = resultado.Tip_bloque;
                    objBloqueDC.Vacantes = Convert.ToInt16(resultado.Vacantes);
                    objBloqueDC.Total_matriculados = Convert.ToInt16(resultado.Total_matriculados);
                    objBloqueDC.Estado = resultado.Estado;

                    objLista.Add(objBloqueDC);

                }
                return objLista;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
