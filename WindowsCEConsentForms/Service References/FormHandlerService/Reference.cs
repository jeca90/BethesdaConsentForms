﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsCEConsentForms.FormHandlerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientDetail", Namespace="http://schemas.datacontract.org/2004/07/Consent.sp.wcf")]
    [System.SerializableAttribute()]
    public partial class PatientDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AdmDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AssociatedDoctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AttnDrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MRHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrimaryDoctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProcedureNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsCEConsentForms.FormHandlerService.StatementOfConsent StatementOfConsentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TranslatedbyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnableToSignReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public System.DateTime AdmDate {
            get {
                return this.AdmDateField;
            }
            set {
                if ((this.AdmDateField.Equals(value) != true)) {
                    this.AdmDateField = value;
                    this.RaisePropertyChanged("AdmDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AssociatedDoctorId {
            get {
                return this.AssociatedDoctorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AssociatedDoctorIdField, value) != true)) {
                    this.AssociatedDoctorIdField = value;
                    this.RaisePropertyChanged("AssociatedDoctorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AttnDr {
            get {
                return this.AttnDrField;
            }
            set {
                if ((object.ReferenceEquals(this.AttnDrField, value) != true)) {
                    this.AttnDrField = value;
                    this.RaisePropertyChanged("AttnDr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((this.DOBField.Equals(value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MRHash {
            get {
                return this.MRHashField;
            }
            set {
                if ((object.ReferenceEquals(this.MRHashField, value) != true)) {
                    this.MRHashField = value;
                    this.RaisePropertyChanged("MRHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrimaryDoctorId {
            get {
                return this.PrimaryDoctorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PrimaryDoctorIdField, value) != true)) {
                    this.PrimaryDoctorIdField = value;
                    this.RaisePropertyChanged("PrimaryDoctorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProcedureName {
            get {
                return this.ProcedureNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcedureNameField, value) != true)) {
                    this.ProcedureNameField = value;
                    this.RaisePropertyChanged("ProcedureName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsCEConsentForms.FormHandlerService.StatementOfConsent StatementOfConsent {
            get {
                return this.StatementOfConsentField;
            }
            set {
                if ((object.ReferenceEquals(this.StatementOfConsentField, value) != true)) {
                    this.StatementOfConsentField = value;
                    this.RaisePropertyChanged("StatementOfConsent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Translatedby {
            get {
                return this.TranslatedbyField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedbyField, value) != true)) {
                    this.TranslatedbyField = value;
                    this.RaisePropertyChanged("Translatedby");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UnableToSignReason {
            get {
                return this.UnableToSignReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.UnableToSignReasonField, value) != true)) {
                    this.UnableToSignReasonField = value;
                    this.RaisePropertyChanged("UnableToSignReason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                if ((object.ReferenceEquals(this.genderField, value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StatementOfConsent", Namespace="http://schemas.datacontract.org/2004/07/Consent.sp.wcf")]
    [System.SerializableAttribute()]
    public partial class StatementOfConsent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AutologousUnitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DirectedUnitsField;
        
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
        public bool AutologousUnits {
            get {
                return this.AutologousUnitsField;
            }
            set {
                if ((this.AutologousUnitsField.Equals(value) != true)) {
                    this.AutologousUnitsField = value;
                    this.RaisePropertyChanged("AutologousUnits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DirectedUnits {
            get {
                return this.DirectedUnitsField;
            }
            set {
                if ((this.DirectedUnitsField.Equals(value) != true)) {
                    this.DirectedUnitsField = value;
                    this.RaisePropertyChanged("DirectedUnits");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DoctorDetails", Namespace="http://schemas.datacontract.org/2004/07/Consent.sp.wcf")]
    [System.SerializableAttribute()]
    public partial class DoctorDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPrimaryDoctorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LnameField;
        
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
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPrimaryDoctor {
            get {
                return this.IsPrimaryDoctorField;
            }
            set {
                if ((this.IsPrimaryDoctorField.Equals(value) != true)) {
                    this.IsPrimaryDoctorField = value;
                    this.RaisePropertyChanged("IsPrimaryDoctor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TrackingInfo", Namespace="http://schemas.datacontract.org/2004/07/Consent.sp.wcf")]
    [System.SerializableAttribute()]
    public partial class TrackingInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeviceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IPField;
        
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
        public string Device {
            get {
                return this.DeviceField;
            }
            set {
                if ((object.ReferenceEquals(this.DeviceField, value) != true)) {
                    this.DeviceField = value;
                    this.RaisePropertyChanged("Device");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IP {
            get {
                return this.IPField;
            }
            set {
                if ((object.ReferenceEquals(this.IPField, value) != true)) {
                    this.IPField = value;
                    this.RaisePropertyChanged("IP");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DoctorAndProcedure", Namespace="http://schemas.datacontract.org/2004/07/Consent.sp.wcf")]
    [System.SerializableAttribute()]
    public partial class DoctorAndProcedure : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _preceduresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _primaryDoctorIdField;
        
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
        public string _precedures {
            get {
                return this._preceduresField;
            }
            set {
                if ((object.ReferenceEquals(this._preceduresField, value) != true)) {
                    this._preceduresField = value;
                    this.RaisePropertyChanged("_precedures");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _primaryDoctorId {
            get {
                return this._primaryDoctorIdField;
            }
            set {
                if ((object.ReferenceEquals(this._primaryDoctorIdField, value) != true)) {
                    this._primaryDoctorIdField = value;
                    this.RaisePropertyChanged("_primaryDoctorId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FormHandlerService.IFormHandlerService")]
    public interface IFormHandlerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientDetails", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientDetailsResponse")]
        System.Xml.Linq.XElement GetPatientDetails(string patientNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientfromLocation", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientfromLocationResponse")]
        System.Data.DataTable GetPatientfromLocation(string Location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientNumbers", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientNumbersResponse")]
        System.Xml.Linq.XElement GetPatientNumbers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientIdsList", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientIdsListResponse")]
        string[] GetPatientIdsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientDetail", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientDetailResponse")]
        WindowsCEConsentForms.FormHandlerService.PatientDetail GetPatientDetail(string patientNumber, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/SavePatientSignature", ReplyAction="http://tempuri.org/IFormHandlerService/SavePatientSignatureResponse")]
        bool SavePatientSignature(string PatientNumber, string SignaturesContent, string FormType, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/UpdateTranslatedby", ReplyAction="http://tempuri.org/IFormHandlerService/UpdateTranslatedbyResponse")]
        bool UpdateTranslatedby(string PatientNumber, string ConsentFormType, string Translatedby);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientSignature", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientSignatureResponse")]
        string GetPatientSignature(string PatientNumber, string FormType, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientList", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientListResponse")]
        System.Data.DataTable GetPatientList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPrimaryPhysiciansList", ReplyAction="http://tempuri.org/IFormHandlerService/GetPrimaryPhysiciansListResponse")]
        System.Data.DataTable GetPrimaryPhysiciansList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetAssociatedPhysiciansList", ReplyAction="http://tempuri.org/IFormHandlerService/GetAssociatedPhysiciansListResponse")]
        System.Data.DataTable GetAssociatedPhysiciansList(string primaryPhysicianId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/UpdateDoctorAssociation", ReplyAction="http://tempuri.org/IFormHandlerService/UpdateDoctorAssociationResponse")]
        void UpdateDoctorAssociation(string patientId, string primaryDoctorId, string associatedDoctorId, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPrimaryDoctorDetail", ReplyAction="http://tempuri.org/IFormHandlerService/GetPrimaryDoctorDetailResponse")]
        WindowsCEConsentForms.FormHandlerService.DoctorDetails GetPrimaryDoctorDetail(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetAssociateDoctorDetail", ReplyAction="http://tempuri.org/IFormHandlerService/GetAssociateDoctorDetailResponse")]
        WindowsCEConsentForms.FormHandlerService.DoctorDetails GetAssociateDoctorDetail(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/UpdateTrackingInfo", ReplyAction="http://tempuri.org/IFormHandlerService/UpdateTrackingInfoResponse")]
        void UpdateTrackingInfo(string PatientId, WindowsCEConsentForms.FormHandlerService.TrackingInfo trackingInfo, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GenerateAndUploadPDFtoSharePoint", ReplyAction="http://tempuri.org/IFormHandlerService/GenerateAndUploadPDFtoSharePointResponse")]
        void GenerateAndUploadPDFtoSharePoint(string RelativeUrl, string PatientId, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/UpdateConsentFormStatementType", ReplyAction="http://tempuri.org/IFormHandlerService/UpdateConsentFormStatementTypeResponse")]
        void UpdateConsentFormStatementType(string PatientNumber, WindowsCEConsentForms.FormHandlerService.StatementOfConsent StatementType, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/SaveDoctorsDetails", ReplyAction="http://tempuri.org/IFormHandlerService/SaveDoctorsDetailsResponse")]
        void SaveDoctorsDetails(string PatientID, string ConsentFormType, WindowsCEConsentForms.FormHandlerService.DoctorAndProcedure[] _doctorAndPrcedures);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetDoctorsDetails", ReplyAction="http://tempuri.org/IFormHandlerService/GetDoctorsDetailsResponse")]
        WindowsCEConsentForms.FormHandlerService.DoctorAndProcedure[] GetDoctorsDetails(string PatientID, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetProcedurenameList", ReplyAction="http://tempuri.org/IFormHandlerService/GetProcedurenameListResponse")]
        string[] GetProcedurenameList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetEndoscopyProcedurenameList", ReplyAction="http://tempuri.org/IFormHandlerService/GetEndoscopyProcedurenameListResponse")]
        string[] GetEndoscopyProcedurenameList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetCardiovascularProcedurenameList", ReplyAction="http://tempuri.org/IFormHandlerService/GetCardiovascularProcedurenameListResponse" +
            "")]
        string[] GetCardiovascularProcedurenameList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/UpdatePatientUnableSignReason", ReplyAction="http://tempuri.org/IFormHandlerService/UpdatePatientUnableSignReasonResponse")]
        void UpdatePatientUnableSignReason(string PatientId, string Reason, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientIds", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientIdsResponse")]
        System.Xml.Linq.XElement GetPatientIds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientID", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientIDResponse")]
        System.Xml.Linq.XElement GetPatientID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetAssociateDRDetails", ReplyAction="http://tempuri.org/IFormHandlerService/GetAssociateDRDetailsResponse")]
        System.Xml.Linq.XElement GetAssociateDRDetails(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetAssociateDRDetail", ReplyAction="http://tempuri.org/IFormHandlerService/GetAssociateDRDetailResponse")]
        System.Data.DataSet GetAssociateDRDetail(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/GetPatientDetailWithDS", ReplyAction="http://tempuri.org/IFormHandlerService/GetPatientDetailWithDSResponse")]
        System.Data.DataSet GetPatientDetailWithDS(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/UpdatePatientProcedures", ReplyAction="http://tempuri.org/IFormHandlerService/UpdatePatientProceduresResponse")]
        void UpdatePatientProcedures(string PatientId, string Procedures, string ConsentFormType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormHandlerService/SendSignatures", ReplyAction="http://tempuri.org/IFormHandlerService/SendSignaturesResponse")]
        void SendSignatures(int id, string signatures);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFormHandlerServiceChannel : WindowsCEConsentForms.FormHandlerService.IFormHandlerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FormHandlerServiceClient : System.ServiceModel.ClientBase<WindowsCEConsentForms.FormHandlerService.IFormHandlerService>, WindowsCEConsentForms.FormHandlerService.IFormHandlerService {
        
        public FormHandlerServiceClient() {
        }
        
        public FormHandlerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FormHandlerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FormHandlerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FormHandlerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Xml.Linq.XElement GetPatientDetails(string patientNumber) {
            return base.Channel.GetPatientDetails(patientNumber);
        }
        
        public System.Data.DataTable GetPatientfromLocation(string Location) {
            return base.Channel.GetPatientfromLocation(Location);
        }
        
        public System.Xml.Linq.XElement GetPatientNumbers() {
            return base.Channel.GetPatientNumbers();
        }
        
        public string[] GetPatientIdsList() {
            return base.Channel.GetPatientIdsList();
        }
        
        public WindowsCEConsentForms.FormHandlerService.PatientDetail GetPatientDetail(string patientNumber, string ConsentFormType) {
            return base.Channel.GetPatientDetail(patientNumber, ConsentFormType);
        }
        
        public bool SavePatientSignature(string PatientNumber, string SignaturesContent, string FormType, string type) {
            return base.Channel.SavePatientSignature(PatientNumber, SignaturesContent, FormType, type);
        }
        
        public bool UpdateTranslatedby(string PatientNumber, string ConsentFormType, string Translatedby) {
            return base.Channel.UpdateTranslatedby(PatientNumber, ConsentFormType, Translatedby);
        }
        
        public string GetPatientSignature(string PatientNumber, string FormType, string type) {
            return base.Channel.GetPatientSignature(PatientNumber, FormType, type);
        }
        
        public System.Data.DataTable GetPatientList() {
            return base.Channel.GetPatientList();
        }
        
        public System.Data.DataTable GetPrimaryPhysiciansList() {
            return base.Channel.GetPrimaryPhysiciansList();
        }
        
        public System.Data.DataTable GetAssociatedPhysiciansList(string primaryPhysicianId) {
            return base.Channel.GetAssociatedPhysiciansList(primaryPhysicianId);
        }
        
        public void UpdateDoctorAssociation(string patientId, string primaryDoctorId, string associatedDoctorId, string ConsentFormType) {
            base.Channel.UpdateDoctorAssociation(patientId, primaryDoctorId, associatedDoctorId, ConsentFormType);
        }
        
        public WindowsCEConsentForms.FormHandlerService.DoctorDetails GetPrimaryDoctorDetail(string id) {
            return base.Channel.GetPrimaryDoctorDetail(id);
        }
        
        public WindowsCEConsentForms.FormHandlerService.DoctorDetails GetAssociateDoctorDetail(string id) {
            return base.Channel.GetAssociateDoctorDetail(id);
        }
        
        public void UpdateTrackingInfo(string PatientId, WindowsCEConsentForms.FormHandlerService.TrackingInfo trackingInfo, string ConsentFormType) {
            base.Channel.UpdateTrackingInfo(PatientId, trackingInfo, ConsentFormType);
        }
        
        public void GenerateAndUploadPDFtoSharePoint(string RelativeUrl, string PatientId, string ConsentFormType) {
            base.Channel.GenerateAndUploadPDFtoSharePoint(RelativeUrl, PatientId, ConsentFormType);
        }
        
        public void UpdateConsentFormStatementType(string PatientNumber, WindowsCEConsentForms.FormHandlerService.StatementOfConsent StatementType, string ConsentFormType) {
            base.Channel.UpdateConsentFormStatementType(PatientNumber, StatementType, ConsentFormType);
        }
        
        public void SaveDoctorsDetails(string PatientID, string ConsentFormType, WindowsCEConsentForms.FormHandlerService.DoctorAndProcedure[] _doctorAndPrcedures) {
            base.Channel.SaveDoctorsDetails(PatientID, ConsentFormType, _doctorAndPrcedures);
        }
        
        public WindowsCEConsentForms.FormHandlerService.DoctorAndProcedure[] GetDoctorsDetails(string PatientID, string ConsentFormType) {
            return base.Channel.GetDoctorsDetails(PatientID, ConsentFormType);
        }
        
        public string[] GetProcedurenameList() {
            return base.Channel.GetProcedurenameList();
        }
        
        public string[] GetEndoscopyProcedurenameList() {
            return base.Channel.GetEndoscopyProcedurenameList();
        }
        
        public string[] GetCardiovascularProcedurenameList() {
            return base.Channel.GetCardiovascularProcedurenameList();
        }
        
        public void UpdatePatientUnableSignReason(string PatientId, string Reason, string ConsentFormType) {
            base.Channel.UpdatePatientUnableSignReason(PatientId, Reason, ConsentFormType);
        }
        
        public System.Xml.Linq.XElement GetPatientIds() {
            return base.Channel.GetPatientIds();
        }
        
        public System.Xml.Linq.XElement GetPatientID() {
            return base.Channel.GetPatientID();
        }
        
        public System.Xml.Linq.XElement GetAssociateDRDetails(int id) {
            return base.Channel.GetAssociateDRDetails(id);
        }
        
        public System.Data.DataSet GetAssociateDRDetail(int id) {
            return base.Channel.GetAssociateDRDetail(id);
        }
        
        public System.Data.DataSet GetPatientDetailWithDS(string id) {
            return base.Channel.GetPatientDetailWithDS(id);
        }
        
        public void UpdatePatientProcedures(string PatientId, string Procedures, string ConsentFormType) {
            base.Channel.UpdatePatientProcedures(PatientId, Procedures, ConsentFormType);
        }
        
        public void SendSignatures(int id, string signatures) {
            base.Channel.SendSignatures(id, signatures);
        }
    }
}
