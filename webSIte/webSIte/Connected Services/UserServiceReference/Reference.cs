﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webSIte.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserClass", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class UserClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateRegisteredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserEmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int isUserRegisteredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userTypeField;
        
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
        public string ContactNumber {
            get {
                return this.ContactNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNumberField, value) != true)) {
                    this.ContactNumberField = value;
                    this.RaisePropertyChanged("ContactNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateRegistered {
            get {
                return this.DateRegisteredField;
            }
            set {
                if ((object.ReferenceEquals(this.DateRegisteredField, value) != true)) {
                    this.DateRegisteredField = value;
                    this.RaisePropertyChanged("DateRegistered");
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserEmailAddress {
            get {
                return this.UserEmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.UserEmailAddressField, value) != true)) {
                    this.UserEmailAddressField = value;
                    this.RaisePropertyChanged("UserEmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserLastName {
            get {
                return this.UserLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserLastNameField, value) != true)) {
                    this.UserLastNameField = value;
                    this.RaisePropertyChanged("UserLastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int isUserRegistered {
            get {
                return this.isUserRegisteredField;
            }
            set {
                if ((this.isUserRegisteredField.Equals(value) != true)) {
                    this.isUserRegisteredField = value;
                    this.RaisePropertyChanged("isUserRegistered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userType {
            get {
                return this.userTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.userTypeField, value) != true)) {
                    this.userTypeField = value;
                    this.RaisePropertyChanged("userType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserFunctionality")]
    public interface IUserFunctionality {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/registerNewUser", ReplyAction="http://tempuri.org/IUserFunctionality/registerNewUserResponse")]
        bool registerNewUser(webSIte.UserServiceReference.UserClass newUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/registerNewUser", ReplyAction="http://tempuri.org/IUserFunctionality/registerNewUserResponse")]
        System.Threading.Tasks.Task<bool> registerNewUserAsync(webSIte.UserServiceReference.UserClass newUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/updateReadyExistingUser", ReplyAction="http://tempuri.org/IUserFunctionality/updateReadyExistingUserResponse")]
        bool updateReadyExistingUser(webSIte.UserServiceReference.UserClass userUpdates);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/updateReadyExistingUser", ReplyAction="http://tempuri.org/IUserFunctionality/updateReadyExistingUserResponse")]
        System.Threading.Tasks.Task<bool> updateReadyExistingUserAsync(webSIte.UserServiceReference.UserClass userUpdates);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getIndividualUserBYID", ReplyAction="http://tempuri.org/IUserFunctionality/getIndividualUserBYIDResponse")]
        webSIte.UserServiceReference.UserClass getIndividualUserBYID(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getIndividualUserBYID", ReplyAction="http://tempuri.org/IUserFunctionality/getIndividualUserBYIDResponse")]
        System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass> getIndividualUserBYIDAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getUserByEmailNPass", ReplyAction="http://tempuri.org/IUserFunctionality/getUserByEmailNPassResponse")]
        webSIte.UserServiceReference.UserClass getUserByEmailNPass(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getUserByEmailNPass", ReplyAction="http://tempuri.org/IUserFunctionality/getUserByEmailNPassResponse")]
        System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass> getUserByEmailNPassAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getAllUsers", ReplyAction="http://tempuri.org/IUserFunctionality/getAllUsersResponse")]
        webSIte.UserServiceReference.UserClass[] getAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getAllUsers", ReplyAction="http://tempuri.org/IUserFunctionality/getAllUsersResponse")]
        System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass[]> getAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getActiveUsers", ReplyAction="http://tempuri.org/IUserFunctionality/getActiveUsersResponse")]
        webSIte.UserServiceReference.UserClass[] getActiveUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getActiveUsers", ReplyAction="http://tempuri.org/IUserFunctionality/getActiveUsersResponse")]
        System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass[]> getActiveUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getInactiveUsers", ReplyAction="http://tempuri.org/IUserFunctionality/getInactiveUsersResponse")]
        webSIte.UserServiceReference.UserClass[] getInactiveUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/getInactiveUsers", ReplyAction="http://tempuri.org/IUserFunctionality/getInactiveUsersResponse")]
        System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass[]> getInactiveUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/AuthoriseLogin", ReplyAction="http://tempuri.org/IUserFunctionality/AuthoriseLoginResponse")]
        bool AuthoriseLogin(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserFunctionality/AuthoriseLogin", ReplyAction="http://tempuri.org/IUserFunctionality/AuthoriseLoginResponse")]
        System.Threading.Tasks.Task<bool> AuthoriseLoginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserFunctionalityChannel : webSIte.UserServiceReference.IUserFunctionality, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserFunctionalityClient : System.ServiceModel.ClientBase<webSIte.UserServiceReference.IUserFunctionality>, webSIte.UserServiceReference.IUserFunctionality {
        
        public UserFunctionalityClient() {
        }
        
        public UserFunctionalityClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserFunctionalityClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserFunctionalityClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserFunctionalityClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool registerNewUser(webSIte.UserServiceReference.UserClass newUser) {
            return base.Channel.registerNewUser(newUser);
        }
        
        public System.Threading.Tasks.Task<bool> registerNewUserAsync(webSIte.UserServiceReference.UserClass newUser) {
            return base.Channel.registerNewUserAsync(newUser);
        }
        
        public bool updateReadyExistingUser(webSIte.UserServiceReference.UserClass userUpdates) {
            return base.Channel.updateReadyExistingUser(userUpdates);
        }
        
        public System.Threading.Tasks.Task<bool> updateReadyExistingUserAsync(webSIte.UserServiceReference.UserClass userUpdates) {
            return base.Channel.updateReadyExistingUserAsync(userUpdates);
        }
        
        public webSIte.UserServiceReference.UserClass getIndividualUserBYID(int Id) {
            return base.Channel.getIndividualUserBYID(Id);
        }
        
        public System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass> getIndividualUserBYIDAsync(int Id) {
            return base.Channel.getIndividualUserBYIDAsync(Id);
        }
        
        public webSIte.UserServiceReference.UserClass getUserByEmailNPass(string email, string password) {
            return base.Channel.getUserByEmailNPass(email, password);
        }
        
        public System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass> getUserByEmailNPassAsync(string email, string password) {
            return base.Channel.getUserByEmailNPassAsync(email, password);
        }
        
        public webSIte.UserServiceReference.UserClass[] getAllUsers() {
            return base.Channel.getAllUsers();
        }
        
        public System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass[]> getAllUsersAsync() {
            return base.Channel.getAllUsersAsync();
        }
        
        public webSIte.UserServiceReference.UserClass[] getActiveUsers() {
            return base.Channel.getActiveUsers();
        }
        
        public System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass[]> getActiveUsersAsync() {
            return base.Channel.getActiveUsersAsync();
        }
        
        public webSIte.UserServiceReference.UserClass[] getInactiveUsers() {
            return base.Channel.getInactiveUsers();
        }
        
        public System.Threading.Tasks.Task<webSIte.UserServiceReference.UserClass[]> getInactiveUsersAsync() {
            return base.Channel.getInactiveUsersAsync();
        }
        
        public bool AuthoriseLogin(string email, string password) {
            return base.Channel.AuthoriseLogin(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> AuthoriseLoginAsync(string email, string password) {
            return base.Channel.AuthoriseLoginAsync(email, password);
        }
    }
}
