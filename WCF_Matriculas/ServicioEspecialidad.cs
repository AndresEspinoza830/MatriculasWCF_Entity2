using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEspecialidad" en el código y en el archivo de configuración a la vez.
    public class ServicioEspecialidad : IServicioEspecialidad
    {
        public List<EspecialidadDC> ListarEspecialidad()
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<EspecialidadDC> objLista = new List<EspecialidadDC>();

                var query = (from miEspecialidad in MisMatriculas.Tb_ESPECIALIDAD
                             orderby miEspecialidad.Id_esp
                             select miEspecialidad
                             );

                foreach (var objConsulta in query)
                {

                    EspecialidadDC objEspecialidadDC = new EspecialidadDC();

                    objEspecialidadDC.Id_esp = objConsulta.Id_esp;
                    objEspecialidadDC.Des_esp = objConsulta.Des_esp;
                    objLista.Add(objEspecialidadDC);
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
