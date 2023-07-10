using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProfesor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProfesor
    {
        [OperationContract]
        ProfesorDC ConsultarProfesor(int idProfe);

        [OperationContract]
        List<ProfesorDC> ListarProfesores();

        [OperationContract]
        Boolean EliminarProfesor(int idProfe);

        [OperationContract]
        Boolean InsertarProfesor(ProfesorDCINSERTS objProfesorDC);

        [OperationContract]
        Boolean ActualizarProfesor(ProfesorDCUPDATES objProfesorDC);
    }

    [DataContract]
    [Serializable]
    public class ProfesorDC {
        [DataMember]
        public int Id_profe { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public int Id_esp { get; set; }
        [DataMember]
        public String Des_esp { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String Dni_profe { get; set; }
        [DataMember]
        public String Nom_profe { get; set; }
        [DataMember]
        public String Ape_profe { get; set; }
        [DataMember]
        public String Tel_profe { get; set; }
        [DataMember]
        public String Email_profe { get; set; }
        [DataMember]
        public String Estado { get; set; }

        //UBIGEO
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public String Departamento { get; set; }

        //AUDITORIA
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime Fec_reg { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }
    }

    [DataContract]
    [Serializable]
    public class ProfesorDCINSERTS
    {
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public int Id_esp { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String Dni_profe { get; set; }
        [DataMember]
        public String Nom_profe { get; set; }
        [DataMember]
        public String Ape_profe { get; set; }
        [DataMember]
        public String Tel_profe { get; set; }
        [DataMember]
        public String Email_profe { get; set; }
        [DataMember]
        public int Est_prof { get; set; }

        //AUDITORIA
        [DataMember]
        public String Usu_Registro { get; set; }
    }

    [DataContract]
    [Serializable]
    public class ProfesorDCUPDATES
    {
        [DataMember]
        public int Id_profe { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public int Id_esp { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String Dni_profe { get; set; }
        [DataMember]
        public String Nom_profe { get; set; }
        [DataMember]
        public String Ape_profe { get; set; }
        [DataMember]
        public String Tel_profe { get; set; }
        [DataMember]
        public String Email_profe { get; set; }
        [DataMember]
        public int Est_prof { get; set; }

        //AUDITORIA

        [DataMember]
        public String Usu_Ult_Mod { get; set; }
    }
}
