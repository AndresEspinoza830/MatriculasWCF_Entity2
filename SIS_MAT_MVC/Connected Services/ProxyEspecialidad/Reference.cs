﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIS_MAT_MVC.ProxyEspecialidad {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EspecialidadDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Matriculas")]
    [System.SerializableAttribute()]
    public partial class EspecialidadDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Des_espField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_espField;
        
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
        public string Des_esp {
            get {
                return this.Des_espField;
            }
            set {
                if ((object.ReferenceEquals(this.Des_espField, value) != true)) {
                    this.Des_espField = value;
                    this.RaisePropertyChanged("Des_esp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_esp {
            get {
                return this.Id_espField;
            }
            set {
                if ((this.Id_espField.Equals(value) != true)) {
                    this.Id_espField = value;
                    this.RaisePropertyChanged("Id_esp");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyEspecialidad.IServicioEspecialidad")]
    public interface IServicioEspecialidad {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEspecialidad/ListarEspecialidad", ReplyAction="http://tempuri.org/IServicioEspecialidad/ListarEspecialidadResponse")]
        SIS_MAT_MVC.ProxyEspecialidad.EspecialidadDC[] ListarEspecialidad();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEspecialidad/ListarEspecialidad", ReplyAction="http://tempuri.org/IServicioEspecialidad/ListarEspecialidadResponse")]
        System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyEspecialidad.EspecialidadDC[]> ListarEspecialidadAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioEspecialidadChannel : SIS_MAT_MVC.ProxyEspecialidad.IServicioEspecialidad, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioEspecialidadClient : System.ServiceModel.ClientBase<SIS_MAT_MVC.ProxyEspecialidad.IServicioEspecialidad>, SIS_MAT_MVC.ProxyEspecialidad.IServicioEspecialidad {
        
        public ServicioEspecialidadClient() {
        }
        
        public ServicioEspecialidadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioEspecialidadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEspecialidadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEspecialidadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SIS_MAT_MVC.ProxyEspecialidad.EspecialidadDC[] ListarEspecialidad() {
            return base.Channel.ListarEspecialidad();
        }
        
        public System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyEspecialidad.EspecialidadDC[]> ListarEspecialidadAsync() {
            return base.Channel.ListarEspecialidadAsync();
        }
    }
}
