﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOA_RAC_Form_App.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerRequest", Namespace="http://schemas.datacontract.org/2004/07/SOAAssignment.RequestObjects")]
    [System.SerializableAttribute()]
    public partial class CustomerRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DriverAgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LicenceAgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public int DriverAge {
            get {
                return this.DriverAgeField;
            }
            set {
                if ((this.DriverAgeField.Equals(value) != true)) {
                    this.DriverAgeField = value;
                    this.RaisePropertyChanged("DriverAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LicenceAge {
            get {
                return this.LicenceAgeField;
            }
            set {
                if ((this.LicenceAgeField.Equals(value) != true)) {
                    this.LicenceAgeField = value;
                    this.RaisePropertyChanged("LicenceAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/SOAAssignment.Models")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DriverAgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LicenceAgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public int DriverAge {
            get {
                return this.DriverAgeField;
            }
            set {
                if ((this.DriverAgeField.Equals(value) != true)) {
                    this.DriverAgeField = value;
                    this.RaisePropertyChanged("DriverAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LicenceAge {
            get {
                return this.LicenceAgeField;
            }
            set {
                if ((this.LicenceAgeField.Equals(value) != true)) {
                    this.LicenceAgeField = value;
                    this.RaisePropertyChanged("LicenceAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService.ICustomers")]
    public interface ICustomers {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/ListCustomers", ReplyAction="http://tempuri.org/ICustomers/ListCustomersResponse")]
        SOA_RAC_Form_App.CustomerService.Customer[] ListCustomers(SOA_RAC_Form_App.CustomerService.CustomerRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/ListCustomers", ReplyAction="http://tempuri.org/ICustomers/ListCustomersResponse")]
        System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer[]> ListCustomersAsync(SOA_RAC_Form_App.CustomerService.CustomerRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/CreateCustomer", ReplyAction="http://tempuri.org/ICustomers/CreateCustomerResponse")]
        SOA_RAC_Form_App.CustomerService.Customer CreateCustomer(SOA_RAC_Form_App.CustomerService.Customer Entyity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/CreateCustomer", ReplyAction="http://tempuri.org/ICustomers/CreateCustomerResponse")]
        System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> CreateCustomerAsync(SOA_RAC_Form_App.CustomerService.Customer Entyity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/GetCustomer", ReplyAction="http://tempuri.org/ICustomers/GetCustomerResponse")]
        SOA_RAC_Form_App.CustomerService.Customer GetCustomer(int CustomerdId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/GetCustomer", ReplyAction="http://tempuri.org/ICustomers/GetCustomerResponse")]
        System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> GetCustomerAsync(int CustomerdId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomers/UpdateCustomerResponse")]
        SOA_RAC_Form_App.CustomerService.Customer UpdateCustomer(SOA_RAC_Form_App.CustomerService.Customer Entyity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomers/UpdateCustomerResponse")]
        System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> UpdateCustomerAsync(SOA_RAC_Form_App.CustomerService.Customer Entyity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomers/DeleteCustomerResponse")]
        SOA_RAC_Form_App.CustomerService.Customer DeleteCustomer(int CustomerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomers/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomers/DeleteCustomerResponse")]
        System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> DeleteCustomerAsync(int CustomerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomersChannel : SOA_RAC_Form_App.CustomerService.ICustomers, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomersClient : System.ServiceModel.ClientBase<SOA_RAC_Form_App.CustomerService.ICustomers>, SOA_RAC_Form_App.CustomerService.ICustomers {
        
        public CustomersClient() {
        }
        
        public CustomersClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomersClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomersClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomersClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOA_RAC_Form_App.CustomerService.Customer[] ListCustomers(SOA_RAC_Form_App.CustomerService.CustomerRequest Request) {
            return base.Channel.ListCustomers(Request);
        }
        
        public System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer[]> ListCustomersAsync(SOA_RAC_Form_App.CustomerService.CustomerRequest Request) {
            return base.Channel.ListCustomersAsync(Request);
        }
        
        public SOA_RAC_Form_App.CustomerService.Customer CreateCustomer(SOA_RAC_Form_App.CustomerService.Customer Entyity) {
            return base.Channel.CreateCustomer(Entyity);
        }
        
        public System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> CreateCustomerAsync(SOA_RAC_Form_App.CustomerService.Customer Entyity) {
            return base.Channel.CreateCustomerAsync(Entyity);
        }
        
        public SOA_RAC_Form_App.CustomerService.Customer GetCustomer(int CustomerdId) {
            return base.Channel.GetCustomer(CustomerdId);
        }
        
        public System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> GetCustomerAsync(int CustomerdId) {
            return base.Channel.GetCustomerAsync(CustomerdId);
        }
        
        public SOA_RAC_Form_App.CustomerService.Customer UpdateCustomer(SOA_RAC_Form_App.CustomerService.Customer Entyity) {
            return base.Channel.UpdateCustomer(Entyity);
        }
        
        public System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> UpdateCustomerAsync(SOA_RAC_Form_App.CustomerService.Customer Entyity) {
            return base.Channel.UpdateCustomerAsync(Entyity);
        }
        
        public SOA_RAC_Form_App.CustomerService.Customer DeleteCustomer(int CustomerId) {
            return base.Channel.DeleteCustomer(CustomerId);
        }
        
        public System.Threading.Tasks.Task<SOA_RAC_Form_App.CustomerService.Customer> DeleteCustomerAsync(int CustomerId) {
            return base.Channel.DeleteCustomerAsync(CustomerId);
        }
    }
}