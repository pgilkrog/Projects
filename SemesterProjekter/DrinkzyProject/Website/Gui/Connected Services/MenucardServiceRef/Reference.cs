﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gui.MenucardServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MenuCard", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class MenuCard : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.MenucardServiceRef.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.MenucardServiceRef.Drink[] DrinksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.MenucardServiceRef.Alchohol[] alchoholsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.MenucardServiceRef.HelFlask[] helflasksField;
        
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
        public Gui.MenucardServiceRef.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.MenucardServiceRef.Drink[] Drinks {
            get {
                return this.DrinksField;
            }
            set {
                if ((object.ReferenceEquals(this.DrinksField, value) != true)) {
                    this.DrinksField = value;
                    this.RaisePropertyChanged("Drinks");
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
        public Gui.MenucardServiceRef.Alchohol[] alchohols {
            get {
                return this.alchoholsField;
            }
            set {
                if ((object.ReferenceEquals(this.alchoholsField, value) != true)) {
                    this.alchoholsField = value;
                    this.RaisePropertyChanged("alchohols");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.MenucardServiceRef.HelFlask[] helflasks {
            get {
                return this.helflasksField;
            }
            set {
                if ((object.ReferenceEquals(this.helflasksField, value) != true)) {
                    this.helflasksField = value;
                    this.RaisePropertyChanged("helflasks");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CusNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CusPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegionField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CusName {
            get {
                return this.CusNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CusNameField, value) != true)) {
                    this.CusNameField = value;
                    this.RaisePropertyChanged("CusName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CusPassword {
            get {
                return this.CusPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.CusPasswordField, value) != true)) {
                    this.CusPasswordField = value;
                    this.RaisePropertyChanged("CusPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public string Img {
            get {
                return this.ImgField;
            }
            set {
                if ((object.ReferenceEquals(this.ImgField, value) != true)) {
                    this.ImgField = value;
                    this.RaisePropertyChanged("Img");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region {
            get {
                return this.RegionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionField, value) != true)) {
                    this.RegionField = value;
                    this.RaisePropertyChanged("Region");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Drink", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Drink : Gui.MenucardServiceRef.SuperAlchohol {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.MenucardServiceRef.Ingredient[] IngredientsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.MenucardServiceRef.Ingredient[] Ingredients {
            get {
                return this.IngredientsField;
            }
            set {
                if ((object.ReferenceEquals(this.IngredientsField, value) != true)) {
                    this.IngredientsField = value;
                    this.RaisePropertyChanged("Ingredients");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alchohol", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Alchohol : Gui.MenucardServiceRef.SuperAlchohol {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProcentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Procent {
            get {
                return this.ProcentField;
            }
            set {
                if ((this.ProcentField.Equals(value) != true)) {
                    this.ProcentField = value;
                    this.RaisePropertyChanged("Procent");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HelFlask", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class HelFlask : Gui.MenucardServiceRef.SuperAlchohol {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProcentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Procent {
            get {
                return this.ProcentField;
            }
            set {
                if ((this.ProcentField.Equals(value) != true)) {
                    this.ProcentField = value;
                    this.RaisePropertyChanged("Procent");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SuperAlchohol", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gui.MenucardServiceRef.Alchohol))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gui.MenucardServiceRef.HelFlask))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gui.MenucardServiceRef.Drink))]
    public partial class SuperAlchohol : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public string Img {
            get {
                return this.ImgField;
            }
            set {
                if ((object.ReferenceEquals(this.ImgField, value) != true)) {
                    this.ImgField = value;
                    this.RaisePropertyChanged("Img");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ingredient", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Ingredient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProcentField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Procent {
            get {
                return this.ProcentField;
            }
            set {
                if ((this.ProcentField.Equals(value) != true)) {
                    this.ProcentField = value;
                    this.RaisePropertyChanged("Procent");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MenucardServiceRef.IMenuCardService")]
    public interface IMenuCardService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/createMenuCard", ReplyAction="http://tempuri.org/IMenuCardService/createMenuCardResponse")]
        void createMenuCard(int CuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/createMenuCard", ReplyAction="http://tempuri.org/IMenuCardService/createMenuCardResponse")]
        System.Threading.Tasks.Task createMenuCardAsync(int CuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/addDrink", ReplyAction="http://tempuri.org/IMenuCardService/addDrinkResponse")]
        void addDrink(Gui.MenucardServiceRef.MenuCard mc, int drinkID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/addDrink", ReplyAction="http://tempuri.org/IMenuCardService/addDrinkResponse")]
        System.Threading.Tasks.Task addDrinkAsync(Gui.MenucardServiceRef.MenuCard mc, int drinkID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/GetMenuByCustomerID", ReplyAction="http://tempuri.org/IMenuCardService/GetMenuByCustomerIDResponse")]
        Gui.MenucardServiceRef.MenuCard GetMenuByCustomerID(int cusId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/GetMenuByCustomerID", ReplyAction="http://tempuri.org/IMenuCardService/GetMenuByCustomerIDResponse")]
        System.Threading.Tasks.Task<Gui.MenucardServiceRef.MenuCard> GetMenuByCustomerIDAsync(int cusId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/getAllDrinksByMenucard", ReplyAction="http://tempuri.org/IMenuCardService/getAllDrinksByMenucardResponse")]
        Gui.MenucardServiceRef.Drink[] getAllDrinksByMenucard(int menID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/getAllDrinksByMenucard", ReplyAction="http://tempuri.org/IMenuCardService/getAllDrinksByMenucardResponse")]
        System.Threading.Tasks.Task<Gui.MenucardServiceRef.Drink[]> getAllDrinksByMenucardAsync(int menID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/DeleteDrinkFromMenu", ReplyAction="http://tempuri.org/IMenuCardService/DeleteDrinkFromMenuResponse")]
        void DeleteDrinkFromMenu(int menuID, int drinkid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/DeleteDrinkFromMenu", ReplyAction="http://tempuri.org/IMenuCardService/DeleteDrinkFromMenuResponse")]
        System.Threading.Tasks.Task DeleteDrinkFromMenuAsync(int menuID, int drinkid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/getDrinksBySearchOnMenucard", ReplyAction="http://tempuri.org/IMenuCardService/getDrinksBySearchOnMenucardResponse")]
        Gui.MenucardServiceRef.Drink[] getDrinksBySearchOnMenucard(string search, int cusId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuCardService/getDrinksBySearchOnMenucard", ReplyAction="http://tempuri.org/IMenuCardService/getDrinksBySearchOnMenucardResponse")]
        System.Threading.Tasks.Task<Gui.MenucardServiceRef.Drink[]> getDrinksBySearchOnMenucardAsync(string search, int cusId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMenuCardServiceChannel : Gui.MenucardServiceRef.IMenuCardService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MenuCardServiceClient : System.ServiceModel.ClientBase<Gui.MenucardServiceRef.IMenuCardService>, Gui.MenucardServiceRef.IMenuCardService {
        
        public MenuCardServiceClient() {
        }
        
        public MenuCardServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MenuCardServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuCardServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuCardServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void createMenuCard(int CuID) {
            base.Channel.createMenuCard(CuID);
        }
        
        public System.Threading.Tasks.Task createMenuCardAsync(int CuID) {
            return base.Channel.createMenuCardAsync(CuID);
        }
        
        public void addDrink(Gui.MenucardServiceRef.MenuCard mc, int drinkID) {
            base.Channel.addDrink(mc, drinkID);
        }
        
        public System.Threading.Tasks.Task addDrinkAsync(Gui.MenucardServiceRef.MenuCard mc, int drinkID) {
            return base.Channel.addDrinkAsync(mc, drinkID);
        }
        
        public Gui.MenucardServiceRef.MenuCard GetMenuByCustomerID(int cusId) {
            return base.Channel.GetMenuByCustomerID(cusId);
        }
        
        public System.Threading.Tasks.Task<Gui.MenucardServiceRef.MenuCard> GetMenuByCustomerIDAsync(int cusId) {
            return base.Channel.GetMenuByCustomerIDAsync(cusId);
        }
        
        public Gui.MenucardServiceRef.Drink[] getAllDrinksByMenucard(int menID) {
            return base.Channel.getAllDrinksByMenucard(menID);
        }
        
        public System.Threading.Tasks.Task<Gui.MenucardServiceRef.Drink[]> getAllDrinksByMenucardAsync(int menID) {
            return base.Channel.getAllDrinksByMenucardAsync(menID);
        }
        
        public void DeleteDrinkFromMenu(int menuID, int drinkid) {
            base.Channel.DeleteDrinkFromMenu(menuID, drinkid);
        }
        
        public System.Threading.Tasks.Task DeleteDrinkFromMenuAsync(int menuID, int drinkid) {
            return base.Channel.DeleteDrinkFromMenuAsync(menuID, drinkid);
        }
        
        public Gui.MenucardServiceRef.Drink[] getDrinksBySearchOnMenucard(string search, int cusId) {
            return base.Channel.getDrinksBySearchOnMenucard(search, cusId);
        }
        
        public System.Threading.Tasks.Task<Gui.MenucardServiceRef.Drink[]> getDrinksBySearchOnMenucardAsync(string search, int cusId) {
            return base.Channel.getDrinksBySearchOnMenucardAsync(search, cusId);
        }
    }
}
