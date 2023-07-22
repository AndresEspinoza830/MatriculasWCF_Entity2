using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlumno
    {
        [OperationContract]
        AlumnoDC ConsultarAlumno(int id);

        [OperationContract]
        List<AlumnoDC> ListarAlumnos();

        [OperationContract]
        Boolean ActualizarAlumno(AlumnoDC objAlumnoDC);

        [OperationContract]
        Boolean EliminarAlumno(int id);

        [OperationContract]
        Boolean InsertarAlumno(AlumnoDC objAlumnoDC);
    }

    [DataContract]
    [Serializable]
    public class AlumnoDC
    {
        [DataMember]
        public int Id_alum { get; set; }
		    [DataMember]
		    public String Nom_alum { get; set; }
        [DataMember]
        public String Ape_Alum { get; set; }
        [DataMember]
        public String Dni_alum { get; set; }
        [DataMember]
        public String Dir_alum { get; set; }
        [DataMember]
        public DateTime Fec_nac { get; set; }
        [DataMember]
        public String Email_alum { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String Tel_alum { get; set; }
        [DataMember]
        public int Est_alum { get; set; }
        [DataMember]
        public String Estado { get; set; }

        //IMG
        [DataMember]
        public byte[] Foto_alum { get; set; }


        //UBIGEO
        [DataMember]
        public String Id_Ubigeo { get; set; }
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
    public class AlumnoDCINSERTS
    {
		    [DataMember]
        public String Id_Ubigeo { get; set; }

		    [DisplayName("Nombres")]
		    [DataMember]
        public String Nom_alum { get; set; }

		    [DisplayName("Apellidos")]
		    [DataMember]
        public String Ape_Alum { get; set; }
		  
        [DisplayName("DNI")]
				[DataMember]
        public String Dni_alum { get; set; }

		    [DisplayName("Direccion")]
		    [DataMember]
        public String Dir_alum { get; set; }

		    [DisplayName("Fecha de Nacimiento")]
		    [DataMember]
        public DateTime Fec_nac { get; set; }

		    [DisplayName("Email")]
		    [DataMember]
        public String Email_alum { get; set; }

		    [DisplayName("Sexo")]
		    [DataMember]
        public String Sexo { get; set; }

		    [DisplayName("Telefono")]
		    [DataMember]
        public String Tel_alum { get; set; }


		    [DisplayName("Estado")]
		    [DataMember]
        public int Est_alum { get; set; }

        //IMG
        [DataMember]
        public byte[] Foto_alum { get; set; }

        //AUDITORIA
        [DataMember]
        public String Usu_Registro { get; set; }

    }

    [DataContract]
    [Serializable]
    public class AlumnoDCUPDATES
    {
        [DataMember]
        public int Id_alum { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public String Nom_alum { get; set; }
        [DataMember]
        public String Ape_Alum { get; set; }
        [DataMember]
        public String Dni_alum { get; set; }
        [DataMember]
        public String Dir_alum { get; set; }
        [DataMember]
        public DateTime Fec_nac { get; set; }
        [DataMember]
        public String Email_alum { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String Tel_alum { get; set; }
        [DataMember]
        public int Est_alum { get; set; }

        //IMG
        [DataMember]
        public byte[] Foto_alum { get; set; }

        //AUDITORIA
        [DataMember]
        public String Usu_Ult_Mod { get; set; }

    }
}
