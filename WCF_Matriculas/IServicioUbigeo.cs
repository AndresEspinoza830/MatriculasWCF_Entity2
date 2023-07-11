using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoDepartamentoDC> Ubigeo_Departamentos();
        [OperationContract]
        List<Ubigeo_ProvinciasDepartamentoDC> Ubigeo_ProvinciasDepartamento(String strIdDepartamento);
        [OperationContract]
        List<Ubigeo_DistritosProvinciaDepartamentoDC> Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia);
    }

    [DataContract]
    [Serializable]
    public class UbigeoDepartamentoDC
    {
        [DataMember]
        public string IdDepa { get; set; }
        [DataMember]
        public string Departamento { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Ubigeo_ProvinciasDepartamentoDC
    {
        [DataMember]
        public string IdProv { get; set; }
        [DataMember]
        public string Provincia { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Ubigeo_DistritosProvinciaDepartamentoDC
    {
        [DataMember]
        public string IdDis { get; set; }
        [DataMember]
        public string Distrito { get; set; }
    }
}
