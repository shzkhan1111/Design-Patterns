﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.RatesSoap")]
    public interface RatesSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.Rate> GetRatesAsync(string CustomerCode, string OriginZip, string DestinationZip, string ShipmentDetail, string RatingType, string CODAmount, string Accessorials);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Rate
    {
        
        private string customerCodeField;
        
        private string originZipField;
        
        private string destinationZipField;
        
        private string ratingTypeField;
        
        private string cODAmountField;
        
        private string shipmentDetailField;
        
        private string accessorialsField;
        
        private string rateQuoteNumberField;
        
        private string beyondChargesField;
        
        private string commodityField;
        
        private string milesBetweenField;
        
        private RateReturnDetail returnDetailField;
        
        private string fullLineField;
        
        private string fuelSurchargeField;
        
        private string fuelSurchargePercentField;
        
        private string originCityField;
        
        private string originStateField;
        
        private string destinationCityField;
        
        private string destinationStateField;
        
        private string cODFeeField;
        
        private string hazmatFeeField;
        
        private string handlingFeeField;
        
        private string insideDeliveryFeeField;
        
        private string constructionSiteDeliveryFeeField;
        
        private string liftgateFeeField;
        
        private string notificationBeforeDeliveryFeeField;
        
        private string residentialFeeField;
        
        private string returnLineField;
        
        private string pieceCountField;
        
        private string transitDaysField;
        
        private string totalsField;
        
        private bool rateErrorField;
        
        private bool debugField;
        
        private ShipmentDetailRow[] shipmentDetailResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CustomerCode
        {
            get
            {
                return this.customerCodeField;
            }
            set
            {
                this.customerCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string OriginZip
        {
            get
            {
                return this.originZipField;
            }
            set
            {
                this.originZipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string DestinationZip
        {
            get
            {
                return this.destinationZipField;
            }
            set
            {
                this.destinationZipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string RatingType
        {
            get
            {
                return this.ratingTypeField;
            }
            set
            {
                this.ratingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string CODAmount
        {
            get
            {
                return this.cODAmountField;
            }
            set
            {
                this.cODAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ShipmentDetail
        {
            get
            {
                return this.shipmentDetailField;
            }
            set
            {
                this.shipmentDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Accessorials
        {
            get
            {
                return this.accessorialsField;
            }
            set
            {
                this.accessorialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string RateQuoteNumber
        {
            get
            {
                return this.rateQuoteNumberField;
            }
            set
            {
                this.rateQuoteNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string BeyondCharges
        {
            get
            {
                return this.beyondChargesField;
            }
            set
            {
                this.beyondChargesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Commodity
        {
            get
            {
                return this.commodityField;
            }
            set
            {
                this.commodityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string MilesBetween
        {
            get
            {
                return this.milesBetweenField;
            }
            set
            {
                this.milesBetweenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public RateReturnDetail ReturnDetail
        {
            get
            {
                return this.returnDetailField;
            }
            set
            {
                this.returnDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string FullLine
        {
            get
            {
                return this.fullLineField;
            }
            set
            {
                this.fullLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string FuelSurcharge
        {
            get
            {
                return this.fuelSurchargeField;
            }
            set
            {
                this.fuelSurchargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string FuelSurchargePercent
        {
            get
            {
                return this.fuelSurchargePercentField;
            }
            set
            {
                this.fuelSurchargePercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string OriginCity
        {
            get
            {
                return this.originCityField;
            }
            set
            {
                this.originCityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string OriginState
        {
            get
            {
                return this.originStateField;
            }
            set
            {
                this.originStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string DestinationCity
        {
            get
            {
                return this.destinationCityField;
            }
            set
            {
                this.destinationCityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string DestinationState
        {
            get
            {
                return this.destinationStateField;
            }
            set
            {
                this.destinationStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string CODFee
        {
            get
            {
                return this.cODFeeField;
            }
            set
            {
                this.cODFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string HazmatFee
        {
            get
            {
                return this.hazmatFeeField;
            }
            set
            {
                this.hazmatFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string HandlingFee
        {
            get
            {
                return this.handlingFeeField;
            }
            set
            {
                this.handlingFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string InsideDeliveryFee
        {
            get
            {
                return this.insideDeliveryFeeField;
            }
            set
            {
                this.insideDeliveryFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string ConstructionSiteDeliveryFee
        {
            get
            {
                return this.constructionSiteDeliveryFeeField;
            }
            set
            {
                this.constructionSiteDeliveryFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string LiftgateFee
        {
            get
            {
                return this.liftgateFeeField;
            }
            set
            {
                this.liftgateFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string NotificationBeforeDeliveryFee
        {
            get
            {
                return this.notificationBeforeDeliveryFeeField;
            }
            set
            {
                this.notificationBeforeDeliveryFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string ResidentialFee
        {
            get
            {
                return this.residentialFeeField;
            }
            set
            {
                this.residentialFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public string ReturnLine
        {
            get
            {
                return this.returnLineField;
            }
            set
            {
                this.returnLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public string PieceCount
        {
            get
            {
                return this.pieceCountField;
            }
            set
            {
                this.pieceCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public string TransitDays
        {
            get
            {
                return this.transitDaysField;
            }
            set
            {
                this.transitDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public string Totals
        {
            get
            {
                return this.totalsField;
            }
            set
            {
                this.totalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public bool RateError
        {
            get
            {
                return this.rateErrorField;
            }
            set
            {
                this.rateErrorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public bool Debug
        {
            get
            {
                return this.debugField;
            }
            set
            {
                this.debugField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=33)]
        public ShipmentDetailRow[] ShipmentDetailResponse
        {
            get
            {
                return this.shipmentDetailResponseField;
            }
            set
            {
                this.shipmentDetailResponseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class RateReturnDetail
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ShipmentDetailRow
    {
        
        private string descriptionField;
        
        private string unitsField;
        
        private string nMFCField;
        
        private string weightField;
        
        private string rateField;
        
        private string chargeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string NMFC
        {
            get
            {
                return this.nMFCField;
            }
            set
            {
                this.nMFCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Weight
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Charge
        {
            get
            {
                return this.chargeField;
            }
            set
            {
                this.chargeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface RatesSoapChannel : ServiceReference1.RatesSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class RatesSoapClient : System.ServiceModel.ClientBase<ServiceReference1.RatesSoap>, ServiceReference1.RatesSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public RatesSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(RatesSoapClient.GetBindingForEndpoint(endpointConfiguration), RatesSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RatesSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RatesSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RatesSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RatesSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RatesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Rate> GetRatesAsync(string CustomerCode, string OriginZip, string DestinationZip, string ShipmentDetail, string RatingType, string CODAmount, string Accessorials)
        {
            return base.Channel.GetRatesAsync(CustomerCode, OriginZip, DestinationZip, ShipmentDetail, RatingType, CODAmount, Accessorials);
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
            if ((endpointConfiguration == EndpointConfiguration.RatesSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.RatesSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RatesSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://api.godependable.com/services/rates.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.RatesSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://api.godependable.com/services/rates.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            RatesSoap,
            
            RatesSoap12,
        }
    }
}