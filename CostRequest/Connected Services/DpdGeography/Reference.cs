﻿//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace DpdGeography
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class WSFault
    {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class extraServiceParam
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class extraService
    {
        
        private string esCodeField;
        
        private extraServiceParam[] paramsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string esCode
        {
            get
            {
                return this.esCodeField;
            }
            set
            {
                this.esCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("params", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public extraServiceParam[] @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class timetable
    {
        
        private string weekDaysField;
        
        private string workTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string weekDays
        {
            get
            {
                return this.weekDaysField;
            }
            set
            {
                this.weekDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string workTime
        {
            get
            {
                return this.workTimeField;
            }
            set
            {
                this.workTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class schedule
    {
        
        private string operationField;
        
        private timetable[] timetableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timetable", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public timetable[] timetable
        {
            get
            {
                return this.timetableField;
            }
            set
            {
                this.timetableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class geoCoordinates
    {
        
        private decimal latitudeField;
        
        private bool latitudeFieldSpecified;
        
        private decimal longitudeField;
        
        private bool longitudeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool latitudeSpecified
        {
            get
            {
                return this.latitudeFieldSpecified;
            }
            set
            {
                this.latitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool longitudeSpecified
        {
            get
            {
                return this.longitudeFieldSpecified;
            }
            set
            {
                this.longitudeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class address
    {
        
        private long cityIdField;
        
        private bool cityIdFieldSpecified;
        
        private string countryCodeField;
        
        private string regionCodeField;
        
        private string regionNameField;
        
        private string cityCodeField;
        
        private string cityNameField;
        
        private string indexField;
        
        private string streetField;
        
        private string streetAbbrField;
        
        private string houseNoField;
        
        private string buildingField;
        
        private string structureField;
        
        private string ownershipField;
        
        private string descriptField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long cityId
        {
            get
            {
                return this.cityIdField;
            }
            set
            {
                this.cityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cityIdSpecified
        {
            get
            {
                return this.cityIdFieldSpecified;
            }
            set
            {
                this.cityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string regionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string regionName
        {
            get
            {
                return this.regionNameField;
            }
            set
            {
                this.regionNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string cityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string streetAbbr
        {
            get
            {
                return this.streetAbbrField;
            }
            set
            {
                this.streetAbbrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string houseNo
        {
            get
            {
                return this.houseNoField;
            }
            set
            {
                this.houseNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string building
        {
            get
            {
                return this.buildingField;
            }
            set
            {
                this.buildingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string structure
        {
            get
            {
                return this.structureField;
            }
            set
            {
                this.structureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string ownership
        {
            get
            {
                return this.ownershipField;
            }
            set
            {
                this.ownershipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string descript
        {
            get
            {
                return this.descriptField;
            }
            set
            {
                this.descriptField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class terminalSelf
    {
        
        private string terminalCodeField;
        
        private string terminalNameField;
        
        private address addressField;
        
        private geoCoordinates geoCoordinatesField;
        
        private schedule[] scheduleField;
        
        private extraService[] extraServiceField;
        
        private string[] servicesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string terminalCode
        {
            get
            {
                return this.terminalCodeField;
            }
            set
            {
                this.terminalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string terminalName
        {
            get
            {
                return this.terminalNameField;
            }
            set
            {
                this.terminalNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public address address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public geoCoordinates geoCoordinates
        {
            get
            {
                return this.geoCoordinatesField;
            }
            set
            {
                this.geoCoordinatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schedule", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public schedule[] schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extraService", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public extraService[] extraService
        {
            get
            {
                return this.extraServiceField;
            }
            set
            {
                this.extraServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("serviceCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class auth
    {
        
        private long clientNumberField;
        
        private string clientKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long clientNumber
        {
            get
            {
                return this.clientNumberField;
            }
            set
            {
                this.clientNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string clientKey
        {
            get
            {
                return this.clientKeyField;
            }
            set
            {
                this.clientKeyField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", ConfigurationName="DpdGeography.DPDGeography2")]
    public interface DPDGeography2
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getTerminalsSelfDelivery2Requ" +
            "est", ReplyAction="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getTerminalsSelfDelivery2Resp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdGeography.WSFault), Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getTerminalsSelfDelivery2/Fau" +
            "lt/WSFault", Name="WSFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdGeography.getTerminalsSelfDelivery2Response> getTerminalsSelfDelivery2Async(DpdGeography.getTerminalsSelfDelivery2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getPossibleExtraServiceReques" +
            "t", ReplyAction="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getPossibleExtraServiceRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdGeography.WSFault), Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getPossibleExtraService/Fault" +
            "/WSFault", Name="WSFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdGeography.getPossibleExtraServiceResponse> getPossibleExtraServiceAsync(DpdGeography.getPossibleExtraServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getCitiesCashPayRequest", ReplyAction="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getCitiesCashPayResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdGeography.WSFault), Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getCitiesCashPay/Fault/WSFaul" +
            "t", Name="WSFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdGeography.getCitiesCashPayResponse> getCitiesCashPayAsync(DpdGeography.getCitiesCashPayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getStoragePeriodRequest", ReplyAction="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getStoragePeriodResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdGeography.WSFault), Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getStoragePeriod/Fault/WSFaul" +
            "t", Name="WSFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdGeography.getStoragePeriodResponse> getStoragePeriodAsync(DpdGeography.getStoragePeriodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getParcelShopsRequest", ReplyAction="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getParcelShopsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdGeography.WSFault), Action="http://dpd.ru/ws/geography/2015-05-20/DPDGeography2/getParcelShops/Fault/WSFault", Name="WSFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdGeography.getParcelShopsResponse> getParcelShopsAsync(DpdGeography.getParcelShopsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTerminalsSelfDelivery2", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getTerminalsSelfDelivery2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.auth auth;
        
        public getTerminalsSelfDelivery2Request()
        {
        }
        
        public getTerminalsSelfDelivery2Request(DpdGeography.auth auth)
        {
            this.auth = auth;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTerminalsSelfDelivery2Response", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getTerminalsSelfDelivery2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("terminal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.terminalSelf[] @return;
        
        public getTerminalsSelfDelivery2Response()
        {
        }
        
        public getTerminalsSelfDelivery2Response(DpdGeography.terminalSelf[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class dpdPossibleESRequest
    {
        
        private auth authField;
        
        private dpdPossibleESPickupDelivery pickupField;
        
        private dpdPossibleESPickupDelivery deliveryField;
        
        private bool selfPickupField;
        
        private bool selfDeliveryField;
        
        private string serviceCodeField;
        
        private System.DateTime pickupDateField;
        
        private bool pickupDateFieldSpecified;
        
        private string[] optionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public auth auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public dpdPossibleESPickupDelivery pickup
        {
            get
            {
                return this.pickupField;
            }
            set
            {
                this.pickupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public dpdPossibleESPickupDelivery delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool selfPickup
        {
            get
            {
                return this.selfPickupField;
            }
            set
            {
                this.selfPickupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool selfDelivery
        {
            get
            {
                return this.selfDeliveryField;
            }
            set
            {
                this.selfDeliveryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string serviceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=6)]
        public System.DateTime pickupDate
        {
            get
            {
                return this.pickupDateField;
            }
            set
            {
                this.pickupDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pickupDateSpecified
        {
            get
            {
                return this.pickupDateFieldSpecified;
            }
            set
            {
                this.pickupDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("option", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class dpdPossibleESPickupDelivery
    {
        
        private decimal cityIdField;
        
        private bool cityIdFieldSpecified;
        
        private string terminalCodeField;
        
        private decimal indexField;
        
        private bool indexFieldSpecified;
        
        private string cityNameField;
        
        private string regionCodeField;
        
        private string countryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal cityId
        {
            get
            {
                return this.cityIdField;
            }
            set
            {
                this.cityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cityIdSpecified
        {
            get
            {
                return this.cityIdFieldSpecified;
            }
            set
            {
                this.cityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string terminalCode
        {
            get
            {
                return this.terminalCodeField;
            }
            set
            {
                this.terminalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indexSpecified
        {
            get
            {
                return this.indexFieldSpecified;
            }
            set
            {
                this.indexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string cityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string regionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class dpdPossibleESResult
    {
        
        private string resultCodeField;
        
        private string resultMessageField;
        
        private possibleExtraService[] extraServiceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string resultCode
        {
            get
            {
                return this.resultCodeField;
            }
            set
            {
                this.resultCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string resultMessage
        {
            get
            {
                return this.resultMessageField;
            }
            set
            {
                this.resultMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extraService", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public possibleExtraService[] extraService
        {
            get
            {
                return this.extraServiceField;
            }
            set
            {
                this.extraServiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class possibleExtraService
    {
        
        private string codeField;
        
        private string nameField;
        
        private bool isPaidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool isPaid
        {
            get
            {
                return this.isPaidField;
            }
            set
            {
                this.isPaidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPossibleExtraService", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getPossibleExtraServiceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.dpdPossibleESRequest request;
        
        public getPossibleExtraServiceRequest()
        {
        }
        
        public getPossibleExtraServiceRequest(DpdGeography.dpdPossibleESRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPossibleExtraServiceResponse", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getPossibleExtraServiceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.dpdPossibleESResult @return;
        
        public getPossibleExtraServiceResponse()
        {
        }
        
        public getPossibleExtraServiceResponse(DpdGeography.dpdPossibleESResult @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class dpdCitiesCashPayRequest
    {
        
        private auth authField;
        
        private string countryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public auth auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class city
    {
        
        private long cityIdField;
        
        private bool cityIdFieldSpecified;
        
        private string countryCodeField;
        
        private string countryNameField;
        
        private int regionCodeField;
        
        private bool regionCodeFieldSpecified;
        
        private string regionNameField;
        
        private string cityCodeField;
        
        private string cityNameField;
        
        private string abbreviationField;
        
        private string indexMinField;
        
        private string indexMaxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long cityId
        {
            get
            {
                return this.cityIdField;
            }
            set
            {
                this.cityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cityIdSpecified
        {
            get
            {
                return this.cityIdFieldSpecified;
            }
            set
            {
                this.cityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string countryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int regionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool regionCodeSpecified
        {
            get
            {
                return this.regionCodeFieldSpecified;
            }
            set
            {
                this.regionCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string regionName
        {
            get
            {
                return this.regionNameField;
            }
            set
            {
                this.regionNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string cityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string abbreviation
        {
            get
            {
                return this.abbreviationField;
            }
            set
            {
                this.abbreviationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string indexMin
        {
            get
            {
                return this.indexMinField;
            }
            set
            {
                this.indexMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string indexMax
        {
            get
            {
                return this.indexMaxField;
            }
            set
            {
                this.indexMaxField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCitiesCashPay", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getCitiesCashPayRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.dpdCitiesCashPayRequest request;
        
        public getCitiesCashPayRequest()
        {
        }
        
        public getCitiesCashPayRequest(DpdGeography.dpdCitiesCashPayRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCitiesCashPayResponse", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getCitiesCashPayResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.city[] @return;
        
        public getCitiesCashPayResponse()
        {
        }
        
        public getCitiesCashPayResponse(DpdGeography.city[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class storagePeriodRequest
    {
        
        private auth authField;
        
        private string terminalCodeField;
        
        private string serviceCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public auth auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string terminalCode
        {
            get
            {
                return this.terminalCodeField;
            }
            set
            {
                this.terminalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string serviceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class terminalStoragePeriods
    {
        
        private string terminalCodeField;
        
        private storagePeriod[] servicesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string terminalCode
        {
            get
            {
                return this.terminalCodeField;
            }
            set
            {
                this.terminalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("services", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public storagePeriod[] services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class storagePeriod
    {
        
        private string serviceCodeField;
        
        private int daysField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string serviceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int days
        {
            get
            {
                return this.daysField;
            }
            set
            {
                this.daysField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStoragePeriod", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getStoragePeriodRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.storagePeriodRequest request;
        
        public getStoragePeriodRequest()
        {
        }
        
        public getStoragePeriodRequest(DpdGeography.storagePeriodRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStoragePeriodResponse", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getStoragePeriodResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("terminal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.terminalStoragePeriods[] @return;
        
        public getStoragePeriodResponse()
        {
        }
        
        public getStoragePeriodResponse(DpdGeography.terminalStoragePeriods[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class dpdParcelShopRequest
    {
        
        private auth authField;
        
        private string countryCodeField;
        
        private string regionCodeField;
        
        private string cityCodeField;
        
        private string cityNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public auth auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string regionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string cityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class parcelShop
    {
        
        private string codeField;
        
        private string parcelShopTypeField;
        
        private string stateField;
        
        private address addressField;
        
        private string brandField;
        
        private string clientDepartmentNumField;
        
        private geoCoordinates geoCoordinatesField;
        
        private limits limitsField;
        
        private schedule[] scheduleField;
        
        private extraService[] extraServiceField;
        
        private string[] servicesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string parcelShopType
        {
            get
            {
                return this.parcelShopTypeField;
            }
            set
            {
                this.parcelShopTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public address address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string clientDepartmentNum
        {
            get
            {
                return this.clientDepartmentNumField;
            }
            set
            {
                this.clientDepartmentNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public geoCoordinates geoCoordinates
        {
            get
            {
                return this.geoCoordinatesField;
            }
            set
            {
                this.geoCoordinatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public limits limits
        {
            get
            {
                return this.limitsField;
            }
            set
            {
                this.limitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schedule", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public schedule[] schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extraService", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=9)]
        public extraService[] extraService
        {
            get
            {
                return this.extraServiceField;
            }
            set
            {
                this.extraServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("serviceCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20")]
    public partial class limits
    {
        
        private decimal maxShipmentWeightField;
        
        private bool maxShipmentWeightFieldSpecified;
        
        private decimal maxWeightField;
        
        private bool maxWeightFieldSpecified;
        
        private decimal maxLengthField;
        
        private bool maxLengthFieldSpecified;
        
        private decimal maxWidthField;
        
        private bool maxWidthFieldSpecified;
        
        private decimal maxHeightField;
        
        private bool maxHeightFieldSpecified;
        
        private decimal dimensionSumField;
        
        private bool dimensionSumFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal maxShipmentWeight
        {
            get
            {
                return this.maxShipmentWeightField;
            }
            set
            {
                this.maxShipmentWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxShipmentWeightSpecified
        {
            get
            {
                return this.maxShipmentWeightFieldSpecified;
            }
            set
            {
                this.maxShipmentWeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal maxWeight
        {
            get
            {
                return this.maxWeightField;
            }
            set
            {
                this.maxWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxWeightSpecified
        {
            get
            {
                return this.maxWeightFieldSpecified;
            }
            set
            {
                this.maxWeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal maxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxLengthSpecified
        {
            get
            {
                return this.maxLengthFieldSpecified;
            }
            set
            {
                this.maxLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal maxWidth
        {
            get
            {
                return this.maxWidthField;
            }
            set
            {
                this.maxWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxWidthSpecified
        {
            get
            {
                return this.maxWidthFieldSpecified;
            }
            set
            {
                this.maxWidthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal maxHeight
        {
            get
            {
                return this.maxHeightField;
            }
            set
            {
                this.maxHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxHeightSpecified
        {
            get
            {
                return this.maxHeightFieldSpecified;
            }
            set
            {
                this.maxHeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public decimal dimensionSum
        {
            get
            {
                return this.dimensionSumField;
            }
            set
            {
                this.dimensionSumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dimensionSumSpecified
        {
            get
            {
                return this.dimensionSumFieldSpecified;
            }
            set
            {
                this.dimensionSumFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getParcelShops", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getParcelShopsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.dpdParcelShopRequest request;
        
        public getParcelShopsRequest()
        {
        }
        
        public getParcelShopsRequest(DpdGeography.dpdParcelShopRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getParcelShopsResponse", WrapperNamespace="http://dpd.ru/ws/geography/2015-05-20", IsWrapped=true)]
    public partial class getParcelShopsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/geography/2015-05-20", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdGeography.parcelShop[] @return;
        
        public getParcelShopsResponse()
        {
        }
        
        public getParcelShopsResponse(DpdGeography.parcelShop[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface DPDGeography2Channel : DpdGeography.DPDGeography2, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class DPDGeography2Client : System.ServiceModel.ClientBase<DpdGeography.DPDGeography2>, DpdGeography.DPDGeography2
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DPDGeography2Client() : 
                base(DPDGeography2Client.GetDefaultBinding(), DPDGeography2Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.DPDGeography2Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDGeography2Client(EndpointConfiguration endpointConfiguration) : 
                base(DPDGeography2Client.GetBindingForEndpoint(endpointConfiguration), DPDGeography2Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDGeography2Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DPDGeography2Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDGeography2Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DPDGeography2Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDGeography2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdGeography.getTerminalsSelfDelivery2Response> DpdGeography.DPDGeography2.getTerminalsSelfDelivery2Async(DpdGeography.getTerminalsSelfDelivery2Request request)
        {
            return base.Channel.getTerminalsSelfDelivery2Async(request);
        }
        
        public System.Threading.Tasks.Task<DpdGeography.getTerminalsSelfDelivery2Response> getTerminalsSelfDelivery2Async(DpdGeography.auth auth)
        {
            DpdGeography.getTerminalsSelfDelivery2Request inValue = new DpdGeography.getTerminalsSelfDelivery2Request();
            inValue.auth = auth;
            return ((DpdGeography.DPDGeography2)(this)).getTerminalsSelfDelivery2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdGeography.getPossibleExtraServiceResponse> DpdGeography.DPDGeography2.getPossibleExtraServiceAsync(DpdGeography.getPossibleExtraServiceRequest request)
        {
            return base.Channel.getPossibleExtraServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdGeography.getPossibleExtraServiceResponse> getPossibleExtraServiceAsync(DpdGeography.dpdPossibleESRequest request)
        {
            DpdGeography.getPossibleExtraServiceRequest inValue = new DpdGeography.getPossibleExtraServiceRequest();
            inValue.request = request;
            return ((DpdGeography.DPDGeography2)(this)).getPossibleExtraServiceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdGeography.getCitiesCashPayResponse> DpdGeography.DPDGeography2.getCitiesCashPayAsync(DpdGeography.getCitiesCashPayRequest request)
        {
            return base.Channel.getCitiesCashPayAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdGeography.getCitiesCashPayResponse> getCitiesCashPayAsync(DpdGeography.dpdCitiesCashPayRequest request)
        {
            DpdGeography.getCitiesCashPayRequest inValue = new DpdGeography.getCitiesCashPayRequest();
            inValue.request = request;
            return ((DpdGeography.DPDGeography2)(this)).getCitiesCashPayAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdGeography.getStoragePeriodResponse> DpdGeography.DPDGeography2.getStoragePeriodAsync(DpdGeography.getStoragePeriodRequest request)
        {
            return base.Channel.getStoragePeriodAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdGeography.getStoragePeriodResponse> getStoragePeriodAsync(DpdGeography.storagePeriodRequest request)
        {
            DpdGeography.getStoragePeriodRequest inValue = new DpdGeography.getStoragePeriodRequest();
            inValue.request = request;
            return ((DpdGeography.DPDGeography2)(this)).getStoragePeriodAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdGeography.getParcelShopsResponse> DpdGeography.DPDGeography2.getParcelShopsAsync(DpdGeography.getParcelShopsRequest request)
        {
            return base.Channel.getParcelShopsAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdGeography.getParcelShopsResponse> getParcelShopsAsync(DpdGeography.dpdParcelShopRequest request)
        {
            DpdGeography.getParcelShopsRequest inValue = new DpdGeography.getParcelShopsRequest();
            inValue.request = request;
            return ((DpdGeography.DPDGeography2)(this)).getParcelShopsAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.DPDGeography2Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.DPDGeography2Port))
            {
                return new System.ServiceModel.EndpointAddress("http://ws.dpd.ru/services/geography2");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DPDGeography2Client.GetBindingForEndpoint(EndpointConfiguration.DPDGeography2Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DPDGeography2Client.GetEndpointAddress(EndpointConfiguration.DPDGeography2Port);
        }
        
        public enum EndpointConfiguration
        {
            
            DPDGeography2Port,
        }
    }
}
