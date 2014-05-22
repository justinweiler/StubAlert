﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTests.SendAlertWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alert", Namespace="http://schemas.datacontract.org/2004/07/StubAlerts")]
    [System.SerializableAttribute()]
    public partial class Alert : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlertMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AlertTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] ReceiversField;
        
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
        public string AlertMessage {
            get {
                return this.AlertMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AlertMessageField, value) != true)) {
                    this.AlertMessageField = value;
                    this.RaisePropertyChanged("AlertMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AlertTime {
            get {
                return this.AlertTimeField;
            }
            set {
                if ((this.AlertTimeField.Equals(value) != true)) {
                    this.AlertTimeField = value;
                    this.RaisePropertyChanged("AlertTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Receivers {
            get {
                return this.ReceiversField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceiversField, value) != true)) {
                    this.ReceiversField = value;
                    this.RaisePropertyChanged("Receivers");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SendAlertWebService.ISendAlert")]
    public interface ISendAlert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISendAlert/SendAlert", ReplyAction="http://tempuri.org/ISendAlert/SendAlertResponse")]
        string SendAlert(UnitTests.SendAlertWebService.Alert alert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISendAlert/SendAlert", ReplyAction="http://tempuri.org/ISendAlert/SendAlertResponse")]
        System.Threading.Tasks.Task<string> SendAlertAsync(UnitTests.SendAlertWebService.Alert alert);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISendAlertChannel : UnitTests.SendAlertWebService.ISendAlert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendAlertClient : System.ServiceModel.ClientBase<UnitTests.SendAlertWebService.ISendAlert>, UnitTests.SendAlertWebService.ISendAlert {
        
        public SendAlertClient() {
        }
        
        public SendAlertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendAlertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendAlertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendAlertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SendAlert(UnitTests.SendAlertWebService.Alert alert) {
            return base.Channel.SendAlert(alert);
        }
        
        public System.Threading.Tasks.Task<string> SendAlertAsync(UnitTests.SendAlertWebService.Alert alert) {
            return base.Channel.SendAlertAsync(alert);
        }
    }
}
