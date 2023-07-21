using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCarrera" en el código y en el archivo de configuración a la vez.
    public class ServicioCarrera : IServicioCarrera
    {
        public List<CarreraDC> ListarCarrera()
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<CarreraDC> objLista = new List<CarreraDC>();

                var query = (from miCarrera in MisMatriculas.Tb_CARRERA
                             orderby miCarrera.Id_carrera
                             select miCarrera
                             );

                foreach (var objConsulta in query)
                {

                    CarreraDC objCarreraDC = new CarreraDC();

                    objCarreraDC.Id_carrera = objConsulta.Id_carrera;
                    objCarreraDC.Nom_carrera = objConsulta.Nom_carrera;
                    objLista.Add(objCarreraDC);
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
