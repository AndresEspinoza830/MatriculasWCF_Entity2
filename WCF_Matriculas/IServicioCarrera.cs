using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCarrera" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCarrera
    {
        [OperationContract]
        List<CarreraDC> ListarCarrera();
    }

    [DataContract]
    [Serializable]
    public class CarreraDC
    {
        [DataMember]
        public int Id_carrera { get; set; }
        [DataMember]
        public String Nom_carrera { get; set; }
    }

}
