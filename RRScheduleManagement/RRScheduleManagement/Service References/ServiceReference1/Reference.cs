﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRScheduleManagement.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://UserService.org/", ConfigurationName="ServiceReference1.UserServiceSoap")]
    public interface UserServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://UserService.org/JsonData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string JsonData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://UserService.org/JsonData", ReplyAction="*")]
        System.Threading.Tasks.Task<string> JsonDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://UserService.org/AddUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserLogin))]
        void AddUsers(RRScheduleManagement.ServiceReference1.Users user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://UserService.org/AddUsers", ReplyAction="*")]
        System.Threading.Tasks.Task AddUsersAsync(RRScheduleManagement.ServiceReference1.Users user);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://UserService.org/")]
    public partial class Users : UserLogin {
        
        private int idField;
        
        private string firstnameField;
        
        private string lastnameField;
        
        private string genderField;
        
        private int isActiveField;
        
        private string userImageField;
        
        private int ruleIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Firstname {
            get {
                return this.firstnameField;
            }
            set {
                this.firstnameField = value;
                this.RaisePropertyChanged("Firstname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Lastname {
            get {
                return this.lastnameField;
            }
            set {
                this.lastnameField = value;
                this.RaisePropertyChanged("Lastname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
                this.RaisePropertyChanged("Gender");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
                this.RaisePropertyChanged("IsActive");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string UserImage {
            get {
                return this.userImageField;
            }
            set {
                this.userImageField = value;
                this.RaisePropertyChanged("UserImage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int RuleId {
            get {
                return this.ruleIdField;
            }
            set {
                this.ruleIdField = value;
                this.RaisePropertyChanged("RuleId");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Users))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://UserService.org/")]
    public partial class UserLogin : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string emailField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
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
    public interface UserServiceSoapChannel : RRScheduleManagement.ServiceReference1.UserServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceSoapClient : System.ServiceModel.ClientBase<RRScheduleManagement.ServiceReference1.UserServiceSoap>, RRScheduleManagement.ServiceReference1.UserServiceSoap {
        
        public UserServiceSoapClient() {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string JsonData() {
            return base.Channel.JsonData();
        }
        
        public System.Threading.Tasks.Task<string> JsonDataAsync() {
            return base.Channel.JsonDataAsync();
        }
        
        public void AddUsers(RRScheduleManagement.ServiceReference1.Users user) {
            base.Channel.AddUsers(user);
        }
        
        public System.Threading.Tasks.Task AddUsersAsync(RRScheduleManagement.ServiceReference1.Users user) {
            return base.Channel.AddUsersAsync(user);
        }
    }
}
