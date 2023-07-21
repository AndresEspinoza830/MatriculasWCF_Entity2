using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public Boolean ConsultarUsuario(String Username, String password)
        {

            SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
            UsuarioDC objUsuarioDC = new UsuarioDC();

            Tb_USUARIO_SISTEMA objConsulta = (from miUsuario in MisMatriculas.Tb_USUARIO_SISTEMA
                                              where miUsuario.Username.Equals(Username) && miUsuario.password.Equals(password)
                                              select miUsuario).FirstOrDefault();

            if (objConsulta != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
