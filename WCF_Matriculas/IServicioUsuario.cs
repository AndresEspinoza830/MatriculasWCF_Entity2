using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        Boolean ConsultarUsuario(String Username, String password);
    }

    [DataContract]
    [Serializable]
    public class UsuarioDC
    {
        [DataMember]
        public String Username { get; set; }
        [DataMember]
        public String password { get; set; }
        [DataMember]
        public Int16 Est_usuario { get; set; }
    }
}
