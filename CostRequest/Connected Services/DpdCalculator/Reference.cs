//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace DpdCalculator
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class ServiceCostFault
    {
        
        private string codeField;
        
        private city[] deliveryDupsField;
        
        private string messageField;
        
        private city[] pickupDupsField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("deliveryDups", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public city[] deliveryDups
        {
            get
            {
                return this.deliveryDupsField;
            }
            set
            {
                this.deliveryDupsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pickupDups", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public city[] pickupDups
        {
            get
            {
                return this.pickupDupsField;
            }
            set
            {
                this.pickupDupsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class city
    {
        
        private long cityIdField;
        
        private bool cityIdFieldSpecified;
        
        private string countryCodeField;
        
        private string countryNameField;
        
        private int regionCodeField;
        
        private bool regionCodeFieldSpecified;
        
        private string regionNameField;
        
        private string cityNameField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class serviceCost
    {
        
        private string serviceCodeField;
        
        private string serviceNameField;
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private int daysField;
        
        private bool daysFieldSpecified;
        
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
        public string serviceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool daysSpecified
        {
            get
            {
                return this.daysFieldSpecified;
            }
            set
            {
                this.daysFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class parcelRequest
    {
        
        private double weightField;
        
        private double lengthField;
        
        private double widthField;
        
        private double heightField;
        
        private int quantityField;
        
        public parcelRequest()
        {
            this.quantityField = 1;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class cityRequest
    {
        
        private long cityIdField;
        
        private bool cityIdFieldSpecified;
        
        private string indexField;
        
        private string cityNameField;
        
        private int regionCodeField;
        
        private bool regionCodeFieldSpecified;
        
        private string countryCodeField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class serviceCostParcelsRequest
    {
        
        private auth authField;
        
        private cityRequest pickupField;
        
        private cityRequest deliveryField;
        
        private bool selfPickupField;
        
        private bool selfDeliveryField;
        
        private string serviceCodeField;
        
        private System.DateTime pickupDateField;
        
        private bool pickupDateFieldSpecified;
        
        private int maxDaysField;
        
        private bool maxDaysFieldSpecified;
        
        private double maxCostField;
        
        private bool maxCostFieldSpecified;
        
        private double declaredValueField;
        
        private bool declaredValueFieldSpecified;
        
        private parcelRequest[] parcelField;
        
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
        public cityRequest pickup
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
        public cityRequest delivery
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int maxDays
        {
            get
            {
                return this.maxDaysField;
            }
            set
            {
                this.maxDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxDaysSpecified
        {
            get
            {
                return this.maxDaysFieldSpecified;
            }
            set
            {
                this.maxDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double maxCost
        {
            get
            {
                return this.maxCostField;
            }
            set
            {
                this.maxCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxCostSpecified
        {
            get
            {
                return this.maxCostFieldSpecified;
            }
            set
            {
                this.maxCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public double declaredValue
        {
            get
            {
                return this.declaredValueField;
            }
            set
            {
                this.declaredValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool declaredValueSpecified
        {
            get
            {
                return this.declaredValueFieldSpecified;
            }
            set
            {
                this.declaredValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parcel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public parcelRequest[] parcel
        {
            get
            {
                return this.parcelField;
            }
            set
            {
                this.parcelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class ServiceCostFault2
    {
        
        private string codeField;
        
        private cityIndex[] deliveryDupsField;
        
        private string messageField;
        
        private cityIndex[] pickupDupsField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("deliveryDups", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public cityIndex[] deliveryDups
        {
            get
            {
                return this.deliveryDupsField;
            }
            set
            {
                this.deliveryDupsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pickupDups", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public cityIndex[] pickupDups
        {
            get
            {
                return this.pickupDupsField;
            }
            set
            {
                this.pickupDupsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class cityIndex
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", ConfigurationName="DpdCalculator.DPDCalculator")]
    public interface DPDCalculator
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostByParcelsReque" +
            "st", ReplyAction="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostByParcelsRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdCalculator.ServiceCostFault), Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostByParcels/Faul" +
            "t/ServiceCostFault", Name="ServiceCostFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostByParcelsResponse> getServiceCostByParcelsAsync(DpdCalculator.getServiceCostByParcelsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostByParcels2Requ" +
            "est", ReplyAction="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostByParcels2Resp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdCalculator.ServiceCostFault2), Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostByParcels2/Fau" +
            "lt/ServiceCostFault2", Name="ServiceCostFault2")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostByParcels2Response> getServiceCostByParcels2Async(DpdCalculator.getServiceCostByParcels2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostInternationalR" +
            "equest", ReplyAction="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostInternationalR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdCalculator.ServiceCostFault), Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostInternational/" +
            "Fault/ServiceCostFault", Name="ServiceCostFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostInternationalResponse> getServiceCostInternationalAsync(DpdCalculator.getServiceCostInternationalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostRequest", ReplyAction="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCostResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdCalculator.ServiceCostFault), Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCost/Fault/Service" +
            "CostFault", Name="ServiceCostFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostResponse> getServiceCostAsync(DpdCalculator.getServiceCostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCost2Request", ReplyAction="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCost2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(DpdCalculator.ServiceCostFault2), Action="http://dpd.ru/ws/calculator/2012-03-20/DPDCalculator/getServiceCost2/Fault/Servic" +
            "eCostFault2", Name="ServiceCostFault2")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCost2Response> getServiceCost2Async(DpdCalculator.getServiceCost2Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostByParcels", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostByParcelsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCostParcelsRequest request;
        
        public getServiceCostByParcelsRequest()
        {
        }
        
        public getServiceCostByParcelsRequest(DpdCalculator.serviceCostParcelsRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostByParcelsResponse", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostByParcelsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCost[] @return;
        
        public getServiceCostByParcelsResponse()
        {
        }
        
        public getServiceCostByParcelsResponse(DpdCalculator.serviceCost[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostByParcels2", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostByParcels2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCostParcelsRequest request;
        
        public getServiceCostByParcels2Request()
        {
        }
        
        public getServiceCostByParcels2Request(DpdCalculator.serviceCostParcelsRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostByParcels2Response", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostByParcels2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCost[] @return;
        
        public getServiceCostByParcels2Response()
        {
        }
        
        public getServiceCostByParcels2Response(DpdCalculator.serviceCost[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class serviceCostInternationalRequest
    {
        
        private auth authField;
        
        private cityInternationalRequest pickupField;
        
        private cityInternationalRequest deliveryField;
        
        private bool selfPickupField;
        
        private bool selfDeliveryField;
        
        private double weightField;
        
        private long lengthField;
        
        private long widthField;
        
        private long heightField;
        
        private double declaredValueField;
        
        private bool declaredValueFieldSpecified;
        
        private bool insuranceField;
        
        private bool insuranceFieldSpecified;
        
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
        public cityInternationalRequest pickup
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
        public cityInternationalRequest delivery
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
        public double weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public long length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public long width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public double declaredValue
        {
            get
            {
                return this.declaredValueField;
            }
            set
            {
                this.declaredValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool declaredValueSpecified
        {
            get
            {
                return this.declaredValueFieldSpecified;
            }
            set
            {
                this.declaredValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public bool insurance
        {
            get
            {
                return this.insuranceField;
            }
            set
            {
                this.insuranceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insuranceSpecified
        {
            get
            {
                return this.insuranceFieldSpecified;
            }
            set
            {
                this.insuranceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class cityInternationalRequest
    {
        
        private string countryNameField;
        
        private string cityNameField;
        
        private long cityIdField;
        
        private bool cityIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class serviceCostInternational
    {
        
        private string serviceCodeField;
        
        private string serviceNameField;
        
        private string daysField;
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private double costPinField;
        
        private bool costPinFieldSpecified;
        
        private double weightField;
        
        private bool weightFieldSpecified;
        
        private double volumeField;
        
        private bool volumeFieldSpecified;
        
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
        public string serviceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string days
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double costPin
        {
            get
            {
                return this.costPinField;
            }
            set
            {
                this.costPinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costPinSpecified
        {
            get
            {
                return this.costPinFieldSpecified;
            }
            set
            {
                this.costPinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightSpecified
        {
            get
            {
                return this.weightFieldSpecified;
            }
            set
            {
                this.weightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool volumeSpecified
        {
            get
            {
                return this.volumeFieldSpecified;
            }
            set
            {
                this.volumeFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostInternational", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostInternationalRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCostInternationalRequest request;
        
        public getServiceCostInternationalRequest()
        {
        }
        
        public getServiceCostInternationalRequest(DpdCalculator.serviceCostInternationalRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostInternationalResponse", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostInternationalResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCostInternational[] @return;
        
        public getServiceCostInternationalResponse()
        {
        }
        
        public getServiceCostInternationalResponse(DpdCalculator.serviceCostInternational[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20")]
    public partial class serviceCostRequest
    {
        
        private auth authField;
        
        private cityRequest pickupField;
        
        private cityRequest deliveryField;
        
        private bool selfPickupField;
        
        private bool selfDeliveryField;
        
        private double weightField;
        
        private double volumeField;
        
        private bool volumeFieldSpecified;
        
        private string serviceCodeField;
        
        private System.DateTime pickupDateField;
        
        private bool pickupDateFieldSpecified;
        
        private int maxDaysField;
        
        private bool maxDaysFieldSpecified;
        
        private double maxCostField;
        
        private bool maxCostFieldSpecified;
        
        private double declaredValueField;
        
        private bool declaredValueFieldSpecified;
        
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
        public cityRequest pickup
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
        public cityRequest delivery
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
        public double weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool volumeSpecified
        {
            get
            {
                return this.volumeFieldSpecified;
            }
            set
            {
                this.volumeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int maxDays
        {
            get
            {
                return this.maxDaysField;
            }
            set
            {
                this.maxDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxDaysSpecified
        {
            get
            {
                return this.maxDaysFieldSpecified;
            }
            set
            {
                this.maxDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public double maxCost
        {
            get
            {
                return this.maxCostField;
            }
            set
            {
                this.maxCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxCostSpecified
        {
            get
            {
                return this.maxCostFieldSpecified;
            }
            set
            {
                this.maxCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public double declaredValue
        {
            get
            {
                return this.declaredValueField;
            }
            set
            {
                this.declaredValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool declaredValueSpecified
        {
            get
            {
                return this.declaredValueFieldSpecified;
            }
            set
            {
                this.declaredValueFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCost", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCostRequest request;
        
        public getServiceCostRequest()
        {
        }
        
        public getServiceCostRequest(DpdCalculator.serviceCostRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCostResponse", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCostResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCost[] @return;
        
        public getServiceCostResponse()
        {
        }
        
        public getServiceCostResponse(DpdCalculator.serviceCost[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCost2", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCost2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCostRequest request;
        
        public getServiceCost2Request()
        {
        }
        
        public getServiceCost2Request(DpdCalculator.serviceCostRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getServiceCost2Response", WrapperNamespace="http://dpd.ru/ws/calculator/2012-03-20", IsWrapped=true)]
    public partial class getServiceCost2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dpd.ru/ws/calculator/2012-03-20", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdCalculator.serviceCost[] @return;
        
        public getServiceCost2Response()
        {
        }
        
        public getServiceCost2Response(DpdCalculator.serviceCost[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface DPDCalculatorChannel : DpdCalculator.DPDCalculator, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class DPDCalculatorClient : System.ServiceModel.ClientBase<DpdCalculator.DPDCalculator>, DpdCalculator.DPDCalculator
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DPDCalculatorClient() : 
                base(DPDCalculatorClient.GetDefaultBinding(), DPDCalculatorClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.DPDCalculatorPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDCalculatorClient(EndpointConfiguration endpointConfiguration) : 
                base(DPDCalculatorClient.GetBindingForEndpoint(endpointConfiguration), DPDCalculatorClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDCalculatorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DPDCalculatorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDCalculatorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DPDCalculatorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DPDCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostByParcelsResponse> DpdCalculator.DPDCalculator.getServiceCostByParcelsAsync(DpdCalculator.getServiceCostByParcelsRequest request)
        {
            return base.Channel.getServiceCostByParcelsAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdCalculator.getServiceCostByParcelsResponse> getServiceCostByParcelsAsync(DpdCalculator.serviceCostParcelsRequest request)
        {
            DpdCalculator.getServiceCostByParcelsRequest inValue = new DpdCalculator.getServiceCostByParcelsRequest();
            inValue.request = request;
            return ((DpdCalculator.DPDCalculator)(this)).getServiceCostByParcelsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostByParcels2Response> DpdCalculator.DPDCalculator.getServiceCostByParcels2Async(DpdCalculator.getServiceCostByParcels2Request request)
        {
            return base.Channel.getServiceCostByParcels2Async(request);
        }
        
        public System.Threading.Tasks.Task<DpdCalculator.getServiceCostByParcels2Response> getServiceCostByParcels2Async(DpdCalculator.serviceCostParcelsRequest request)
        {
            DpdCalculator.getServiceCostByParcels2Request inValue = new DpdCalculator.getServiceCostByParcels2Request();
            inValue.request = request;
            return ((DpdCalculator.DPDCalculator)(this)).getServiceCostByParcels2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostInternationalResponse> DpdCalculator.DPDCalculator.getServiceCostInternationalAsync(DpdCalculator.getServiceCostInternationalRequest request)
        {
            return base.Channel.getServiceCostInternationalAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdCalculator.getServiceCostInternationalResponse> getServiceCostInternationalAsync(DpdCalculator.serviceCostInternationalRequest request)
        {
            DpdCalculator.getServiceCostInternationalRequest inValue = new DpdCalculator.getServiceCostInternationalRequest();
            inValue.request = request;
            return ((DpdCalculator.DPDCalculator)(this)).getServiceCostInternationalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCostResponse> DpdCalculator.DPDCalculator.getServiceCostAsync(DpdCalculator.getServiceCostRequest request)
        {
            return base.Channel.getServiceCostAsync(request);
        }
        
        public System.Threading.Tasks.Task<DpdCalculator.getServiceCostResponse> getServiceCostAsync(DpdCalculator.serviceCostRequest request)
        {
            DpdCalculator.getServiceCostRequest inValue = new DpdCalculator.getServiceCostRequest();
            inValue.request = request;
            return ((DpdCalculator.DPDCalculator)(this)).getServiceCostAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DpdCalculator.getServiceCost2Response> DpdCalculator.DPDCalculator.getServiceCost2Async(DpdCalculator.getServiceCost2Request request)
        {
            return base.Channel.getServiceCost2Async(request);
        }
        
        public System.Threading.Tasks.Task<DpdCalculator.getServiceCost2Response> getServiceCost2Async(DpdCalculator.serviceCostRequest request)
        {
            DpdCalculator.getServiceCost2Request inValue = new DpdCalculator.getServiceCost2Request();
            inValue.request = request;
            return ((DpdCalculator.DPDCalculator)(this)).getServiceCost2Async(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.DPDCalculatorPort))
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
            if ((endpointConfiguration == EndpointConfiguration.DPDCalculatorPort))
            {
                return new System.ServiceModel.EndpointAddress("http://ws.dpd.ru/services/calculator2");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DPDCalculatorClient.GetBindingForEndpoint(EndpointConfiguration.DPDCalculatorPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DPDCalculatorClient.GetEndpointAddress(EndpointConfiguration.DPDCalculatorPort);
        }
        
        public enum EndpointConfiguration
        {
            
            DPDCalculatorPort,
        }
    }
}
