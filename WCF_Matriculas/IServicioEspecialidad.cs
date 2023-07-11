using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEspecialidad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEspecialidad
    {
        [OperationContract]
        List<EspecialidadDC> ListarEspecialidad();
    }

    [DataContract]
    [Serializable]
    public class EspecialidadDC
    {
        [DataMember]
        public int Id_esp { get; set; }
        [DataMember]
        public String Des_esp { get; set; }
    }
}
