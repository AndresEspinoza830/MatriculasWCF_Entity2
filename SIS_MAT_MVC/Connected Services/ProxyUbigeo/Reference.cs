﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIS_MAT_MVC.ProxyUbigeo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UbigeoDepartamentoDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Matriculas")]
    [System.SerializableAttribute()]
    public partial class UbigeoDepartamentoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdDepaField;
        
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
        public string Departamento {
            get {
                return this.DepartamentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartamentoField, value) != true)) {
                    this.DepartamentoField = value;
                    this.RaisePropertyChanged("Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDepa {
            get {
                return this.IdDepaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdDepaField, value) != true)) {
                    this.IdDepaField = value;
                    this.RaisePropertyChanged("IdDepa");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ubigeo_ProvinciasDepartamentoDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Matriculas")]
    [System.SerializableAttribute()]
    public partial class Ubigeo_ProvinciasDepartamentoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdProvField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinciaField;
        
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
        public string IdProv {
            get {
                return this.IdProvField;
            }
            set {
                if ((object.ReferenceEquals(this.IdProvField, value) != true)) {
                    this.IdProvField = value;
                    this.RaisePropertyChanged("IdProv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Provincia {
            get {
                return this.ProvinciaField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinciaField, value) != true)) {
                    this.ProvinciaField = value;
                    this.RaisePropertyChanged("Provincia");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ubigeo_DistritosProvinciaDepartamentoDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Matriculas")]
    [System.SerializableAttribute()]
    public partial class Ubigeo_DistritosProvinciaDepartamentoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdDisField;
        
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
        public string Distrito {
            get {
                return this.DistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.DistritoField, value) != true)) {
                    this.DistritoField = value;
                    this.RaisePropertyChanged("Distrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDis {
            get {
                return this.IdDisField;
            }
            set {
                if ((object.ReferenceEquals(this.IdDisField, value) != true)) {
                    this.IdDisField = value;
                    this.RaisePropertyChanged("IdDis");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyUbigeo.IServicioUbigeo")]
    public interface IServicioUbigeo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUbigeo/Ubigeo_Departamentos", ReplyAction="http://tempuri.org/IServicioUbigeo/Ubigeo_DepartamentosResponse")]
        SIS_MAT_MVC.ProxyUbigeo.UbigeoDepartamentoDC[] Ubigeo_Departamentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUbigeo/Ubigeo_Departamentos", ReplyAction="http://tempuri.org/IServicioUbigeo/Ubigeo_DepartamentosResponse")]
        System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyUbigeo.UbigeoDepartamentoDC[]> Ubigeo_DepartamentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUbigeo/Ubigeo_ProvinciasDepartamento", ReplyAction="http://tempuri.org/IServicioUbigeo/Ubigeo_ProvinciasDepartamentoResponse")]
        SIS_MAT_MVC.ProxyUbigeo.Ubigeo_ProvinciasDepartamentoDC[] Ubigeo_ProvinciasDepartamento(string strIdDepartamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUbigeo/Ubigeo_ProvinciasDepartamento", ReplyAction="http://tempuri.org/IServicioUbigeo/Ubigeo_ProvinciasDepartamentoResponse")]
        System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyUbigeo.Ubigeo_ProvinciasDepartamentoDC[]> Ubigeo_ProvinciasDepartamentoAsync(string strIdDepartamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUbigeo/Ubigeo_DistritosProvinciaDepartamento", ReplyAction="http://tempuri.org/IServicioUbigeo/Ubigeo_DistritosProvinciaDepartamentoResponse")]
        SIS_MAT_MVC.ProxyUbigeo.Ubigeo_DistritosProvinciaDepartamentoDC[] Ubigeo_DistritosProvinciaDepartamento(string strIdDepartamento, string strIdProvincia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUbigeo/Ubigeo_DistritosProvinciaDepartamento", ReplyAction="http://tempuri.org/IServicioUbigeo/Ubigeo_DistritosProvinciaDepartamentoResponse")]
        System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyUbigeo.Ubigeo_DistritosProvinciaDepartamentoDC[]> Ubigeo_DistritosProvinciaDepartamentoAsync(string strIdDepartamento, string strIdProvincia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioUbigeoChannel : SIS_MAT_MVC.ProxyUbigeo.IServicioUbigeo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioUbigeoClient : System.ServiceModel.ClientBase<SIS_MAT_MVC.ProxyUbigeo.IServicioUbigeo>, SIS_MAT_MVC.ProxyUbigeo.IServicioUbigeo {
        
        public ServicioUbigeoClient() {
        }
        
        public ServicioUbigeoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioUbigeoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUbigeoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUbigeoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SIS_MAT_MVC.ProxyUbigeo.UbigeoDepartamentoDC[] Ubigeo_Departamentos() {
            return base.Channel.Ubigeo_Departamentos();
        }
        
        public System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyUbigeo.UbigeoDepartamentoDC[]> Ubigeo_DepartamentosAsync() {
            return base.Channel.Ubigeo_DepartamentosAsync();
        }
        
        public SIS_MAT_MVC.ProxyUbigeo.Ubigeo_ProvinciasDepartamentoDC[] Ubigeo_ProvinciasDepartamento(string strIdDepartamento) {
            return base.Channel.Ubigeo_ProvinciasDepartamento(strIdDepartamento);
        }
        
        public System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyUbigeo.Ubigeo_ProvinciasDepartamentoDC[]> Ubigeo_ProvinciasDepartamentoAsync(string strIdDepartamento) {
            return base.Channel.Ubigeo_ProvinciasDepartamentoAsync(strIdDepartamento);
        }
        
        public SIS_MAT_MVC.ProxyUbigeo.Ubigeo_DistritosProvinciaDepartamentoDC[] Ubigeo_DistritosProvinciaDepartamento(string strIdDepartamento, string strIdProvincia) {
            return base.Channel.Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia);
        }
        
        public System.Threading.Tasks.Task<SIS_MAT_MVC.ProxyUbigeo.Ubigeo_DistritosProvinciaDepartamentoDC[]> Ubigeo_DistritosProvinciaDepartamentoAsync(string strIdDepartamento, string strIdProvincia) {
            return base.Channel.Ubigeo_DistritosProvinciaDepartamentoAsync(strIdDepartamento, strIdProvincia);
        }
    }
}
