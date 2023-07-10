using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    [ServiceContract]
    public interface IServicioCurso
    {
        [OperationContract]
        CursoDC ConsultarCurso(int idCurso);

        [OperationContract]
        List<CursoDC> ListarCursos();

        [OperationContract]
        Boolean EliminarCurso(int idCurso);

        [OperationContract]
        Boolean InsertarCurso(CursoDC curso);

        [OperationContract]
        Boolean ActualizarCurso(CursoDC curso);

    }

    [DataContract]
    [Serializable]
    public class CursoDC
    {
        [DataMember]
        public int Id_curso { get; set; }

        [DataMember]
        public String Des_curso { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public DateTime Fec_reg { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public int Est_curso { get; set; }
        [DataMember]
        public String Estado { get; set; }
    }
}
