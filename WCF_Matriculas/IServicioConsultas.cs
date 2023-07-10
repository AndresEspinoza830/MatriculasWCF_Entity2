using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioConsultas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioConsultas
    {
        [OperationContract]
        List<CuotaDC> ListarCuotasPendientesAlumnos(int Id_Alum);

        [OperationContract]
        List<MatriculadoDC> ListarMatriculadosFechas(DateTime fecIni, DateTime fecFin);

        [OperationContract]
        List<MatriculadoDC> ListarAlumnosCarrera(int Id_carrera);

        [OperationContract]
        List<BloqueDC> ListarBloquesVacantes(Int16 Vacantes);
    }

    [DataContract]
    [Serializable]
    public class CuotaDC
    {
        [DataMember]
        public int Id_cuota { get; set; }
        [DataMember]
        public int Id_alum { get; set; }
        [DataMember]
        public String NombreCompleto { get; set; }
        [DataMember]
        public String Ndoc_cuota { get; set; }
        [DataMember]
        public DateTime Fecha_pago { get; set; }
        [DataMember]
        public int Est_cuota { get; set; }
        [DataMember]
        public String EstadoCuota { get; set; }
        [DataMember]
        public int Tip_cuota { get; set; }
        [DataMember]
        public String TipoCuota { get; set; }
        [DataMember]
        public DateTime Vencimiento { get; set; }
        [DataMember]
        public SqlMoney Precio_cuota { get; set; }

    }

    [DataContract]
    [Serializable]
    public class MatriculadoDC
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
        public String Nom_carrera { get; set; }
        [DataMember]
        public String Des_semestre { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public String Tel_alum { get; set; }
        [DataMember]
        public String Estado { get; set; }




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
    public class BloqueDC
    {
        [DataMember]
        public String Id_bloque { get; set; }
        [DataMember]
        public String Descripcion { get; set; }
        [DataMember]
        public String Nombre_Profesor { get; set; }
        [DataMember]
        public String Horario { get; set; }
        [DataMember]
        public String Tip_Bloque { get; set; }
        [DataMember]
        public Int16 Vacantes { get; set; }
        [DataMember]
        public Int16 Total_matriculados { get; set; }
        [DataMember]
        public String Estado { get; set; }
    }
}
