﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIS_MAT_MVC.ProxyCurso {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CursoDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Matriculas")]
    [System.SerializableAttribute()]
    public partial class CursoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Des_cursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Est_cursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_Ult_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_cursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_RegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_Ult_ModField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Des_curso {
            get {
                return this.Des_cursoField;
            }
            set {
                if ((object.ReferenceEquals(this.Des_cursoField, value) != true)) {
                    this.Des_cursoField = value;
                    this.RaisePropertyChanged("Des_curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Est_curso {
            get {
                return this.Est_cursoField;
            }
            set {
                if ((this.Est_cursoField.Equals(value) != true)) {
                    this.Est_cursoField = value;
                    this.RaisePropertyChanged("Est_curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Ult_Mod {
            get {
                return this.Fec_Ult_ModField;
            }
            set {
                if ((this.Fec_Ult_ModField.Equals(value) != true)) {
                    this.Fec_Ult_ModField = value;
                    this.RaisePropertyChanged("Fec_Ult_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_reg {
            get {
                return this.Fec_regField;
            }
            set {
                if ((this.Fec_regField.Equals(value) != true)) {
                    this.Fec_regField = value;
                    this.RaisePropertyChanged("Fec_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_curso {
            get {
                return this.Id_cursoField;
            }
            set {
                if ((this.Id_cursoField.Equals(value) != true)) {
                    this.Id_cursoField = value;
                    this.RaisePropertyChanged("Id_curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Registro {
            get {
                return this.Usu_RegistroField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_RegistroField, value) != true)) {
                    this.Usu_RegistroField = value;
                    this.RaisePropertyChanged("Usu_Registro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Ult_Mod {
            get {
                return this.Usu_Ult_ModField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_Ult_ModField, value) != true)) {
                    this.Usu_Ult_ModField = value;
                    this.RaisePropertyChanged("Usu_Ult_Mod");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCurso.IServicioCurso")]
    public interface IServicioCurso {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/ConsultarCurso", ReplyAction="http://tempuri.org/IServicioCurso/ConsultarCursoResponse")]
        SIS_MAT_MVC.ProxyCurso.CursoDC ConsultarCurso(int idCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/ConsultarCurso", ReplyAction="http://tempuri.org/IServicioCurso/ConsultarCursoResponse")]
        System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyCurso.CursoDC> ConsultarCursoAsync(int idCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/ListarCursos", ReplyAction="http://tempuri.org/IServicioCurso/ListarCursosResponse")]
        SIS_MAT_MVC.ProxyCurso.CursoDC[] ListarCursos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/ListarCursos", ReplyAction="http://tempuri.org/IServicioCurso/ListarCursosResponse")]
        System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyCurso.CursoDC[]> ListarCursosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/EliminarCurso", ReplyAction="http://tempuri.org/IServicioCurso/EliminarCursoResponse")]
        bool EliminarCurso(int idCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/EliminarCurso", ReplyAction="http://tempuri.org/IServicioCurso/EliminarCursoResponse")]
        System.Threading.Tasks.Task<bool> EliminarCursoAsync(int idCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/InsertarCurso", ReplyAction="http://tempuri.org/IServicioCurso/InsertarCursoResponse")]
        bool InsertarCurso(SIS_MAT_MVC.ProxyCurso.CursoDC curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/InsertarCurso", ReplyAction="http://tempuri.org/IServicioCurso/InsertarCursoResponse")]
        System.Threading.Tasks.Task<bool> InsertarCursoAsync(SIS_MAT_MVC.ProxyCurso.CursoDC curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/ActualizarCurso", ReplyAction="http://tempuri.org/IServicioCurso/ActualizarCursoResponse")]
        bool ActualizarCurso(SIS_MAT_MVC.ProxyCurso.CursoDC curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCurso/ActualizarCurso", ReplyAction="http://tempuri.org/IServicioCurso/ActualizarCursoResponse")]
        System.Threading.Tasks.Task<bool> ActualizarCursoAsync(SIS_MAT_MVC.ProxyCurso.CursoDC curso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioCursoChannel : SIS_MAT_MVC.ProxyCurso.IServicioCurso, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioCursoClient : System.ServiceModel.ClientBase<SIS_MAT_MVC.ProxyCurso.IServicioCurso>, SIS_MAT_MVC.ProxyCurso.IServicioCurso {
        
        public ServicioCursoClient() {
        }
        
        public ServicioCursoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioCursoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCursoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCursoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SIS_MAT_MVC.ProxyCurso.CursoDC ConsultarCurso(int idCurso) {
            return base.Channel.ConsultarCurso(idCurso);
        }
        
        public System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyCurso.CursoDC> ConsultarCursoAsync(int idCurso) {
            return base.Channel.ConsultarCursoAsync(idCurso);
        }
        
        public SIS_MAT_MVC.ProxyCurso.CursoDC[] ListarCursos() {
            return base.Channel.ListarCursos();
        }
        
        public System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyCurso.CursoDC[]> ListarCursosAsync() {
            return base.Channel.ListarCursosAsync();
        }
        
        public bool EliminarCurso(int idCurso) {
            return base.Channel.EliminarCurso(idCurso);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCursoAsync(int idCurso) {
            return base.Channel.EliminarCursoAsync(idCurso);
        }
        
        public bool InsertarCurso(SIS_MAT_MVC.ProxyCurso.CursoDC curso) {
            return base.Channel.InsertarCurso(curso);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarCursoAsync(SIS_MAT_MVC.ProxyCurso.CursoDC curso) {
            return base.Channel.InsertarCursoAsync(curso);
        }
        
        public bool ActualizarCurso(SIS_MAT_MVC.ProxyCurso.CursoDC curso) {
            return base.Channel.ActualizarCurso(curso);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarCursoAsync(SIS_MAT_MVC.ProxyCurso.CursoDC curso) {
            return base.Channel.ActualizarCursoAsync(curso);
        }
    }
}
