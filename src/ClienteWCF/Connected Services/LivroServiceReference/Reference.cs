﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWCF.LivroServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Livro", Namespace="http://schemas.datacontract.org/2004/07/ServicoWCF.Model")]
    [System.SerializableAttribute()]
    public partial class Livro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LivroServiceReference.ILivroService")]
    public interface ILivroService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILivroService/Obter", ReplyAction="http://tempuri.org/ILivroService/ObterResponse")]
        ClienteWCF.LivroServiceReference.Livro[] Obter(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILivroService/Obter", ReplyAction="http://tempuri.org/ILivroService/ObterResponse")]
        System.Threading.Tasks.Task<ClienteWCF.LivroServiceReference.Livro[]> ObterAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILivroService/Inserir", ReplyAction="http://tempuri.org/ILivroService/InserirResponse")]
        int Inserir(ClienteWCF.LivroServiceReference.Livro livro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILivroService/Inserir", ReplyAction="http://tempuri.org/ILivroService/InserirResponse")]
        System.Threading.Tasks.Task<int> InserirAsync(ClienteWCF.LivroServiceReference.Livro livro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILivroService/Remover", ReplyAction="http://tempuri.org/ILivroService/RemoverResponse")]
        bool Remover(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILivroService/Remover", ReplyAction="http://tempuri.org/ILivroService/RemoverResponse")]
        System.Threading.Tasks.Task<bool> RemoverAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILivroServiceChannel : ClienteWCF.LivroServiceReference.ILivroService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LivroServiceClient : System.ServiceModel.ClientBase<ClienteWCF.LivroServiceReference.ILivroService>, ClienteWCF.LivroServiceReference.ILivroService {
        
        public LivroServiceClient() {
        }
        
        public LivroServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LivroServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LivroServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LivroServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteWCF.LivroServiceReference.Livro[] Obter(System.Nullable<int> id) {
            return base.Channel.Obter(id);
        }
        
        public System.Threading.Tasks.Task<ClienteWCF.LivroServiceReference.Livro[]> ObterAsync(System.Nullable<int> id) {
            return base.Channel.ObterAsync(id);
        }
        
        public int Inserir(ClienteWCF.LivroServiceReference.Livro livro) {
            return base.Channel.Inserir(livro);
        }
        
        public System.Threading.Tasks.Task<int> InserirAsync(ClienteWCF.LivroServiceReference.Livro livro) {
            return base.Channel.InserirAsync(livro);
        }
        
        public bool Remover(int id) {
            return base.Channel.Remover(id);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverAsync(int id) {
            return base.Channel.RemoverAsync(id);
        }
    }
}
