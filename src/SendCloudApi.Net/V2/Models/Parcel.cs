using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Parcel<T>
    {
        /// <summary>
        /// Identifier of the parcel (ignored when creating)
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        /// <summary>
        /// Name of the recipient
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        /// <summary>
        /// Company name of the recipient the parcel will be shipped to
        /// </summary>
        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Id of the contract that you would like to use to create the parcel with
        /// </summary>
        [DataMember(Name = "contract", EmitDefaultValue = false, IsRequired = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Address of the recipient
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false, IsRequired = false)]
        public string Address { get; set; }

        /// <summary>
        /// Additional address information, e.g. 2nd level
        /// </summary>
        [DataMember(Name = "address_2", EmitDefaultValue = false, IsRequired = false)]
        public string Address2 { get; set; }

        [DataMember(Name = "address_divided", EmitDefaultValue = false, IsRequired = false)]
        public AddressDivided AddressDivided { get; set; }

        /// <summary>
        /// City of the recipient
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        /// <summary>
        /// Zip code of the recipient
        /// </summary>
        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Phone number of the recipient
        /// </summary>
        [DataMember(Name = "telephone", EmitDefaultValue = false, IsRequired = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// E-mail address of the recipient
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }

        /// <summary>
        /// Country of the recipient
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = false)]
        public T Country { get; set; }

        /// <summary>
        /// Shipping method object for a parcel
        /// </summary>
        [DataMember(Name = "shipment", EmitDefaultValue = false, IsRequired = false)]
        public ShippingMethod Shipment { get; set; }

        /// <summary>
        /// Weight of the parcel in kilograms, if none given the default weight from settings is used. If you provide no weight in your request we’ll use the default weight set in your settings.
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
        public double Weight { get; set; }

        /// <summary>
        /// Order number of your order
        /// </summary>
        [DataMember(Name = "order_number", EmitDefaultValue = false, IsRequired = false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// This field is mutually exclusive with the total_insured_value. Amount of Sendcloud Insurance to add.
        /// For XCover, this must be a positive value, larger than 2. If a value between 0 and 2 is sent, it is rounded up to 2. For Insureship(legacy): this must be a multiple of 100, for example, 100, 200, 300, etc.The maximum insurance is 5000. This field does not take the carrier provided shipping method insurance into consideration.Note: this value is an integer.If decimal numbers are sent, these are rounded up to the nearest whole number.Example: sending 72.35 results in a insured_value of 73.
        /// </summary>
        [DataMember(Name = "insured_value", EmitDefaultValue = false, IsRequired = false)]
        public int InsuredValue { get; set; }

        /// <summary>
        /// The currency of the total order value. Validated against a format of “XYZ” (ISO 4217).
        /// </summary>
        [DataMember(Name = "total_order_value_currency", EmitDefaultValue = false, IsRequired = false)]
        public string TotalOrderValueCurrency { get; set; }

        /// <summary>
        /// The value paid by the buyer (via various payment methods supported by the shop(cash on delivery, pre-paid or post-paid), it will also be used for the cash on delivery amount for example “99.99”.
        /// </summary>
        [DataMember(Name = "total_order_value", EmitDefaultValue = false, IsRequired = false)]
        public string TotalOrderValue { get; set; }

        /// <summary>
        /// Shipping method name selected by buyer during the checkout
        /// </summary>
        [DataMember(Name = "shipping_method_checkout_name", EmitDefaultValue = false, IsRequired = false)]
        public string ShippingMethodCheckoutName { get; set; }

        /// <summary>
        /// Code required in case of PO Box or post locker delivery
        /// </summary>
        [DataMember(Name = "to_post_number", EmitDefaultValue = false, IsRequired = false)]
        public string ToPostNumber { get; set; }

        /// <summary>
        /// Customs invoice number
        /// </summary>
        [DataMember(Name = "customs_invoice_nr", EmitDefaultValue = false, IsRequired = false)]
        [Obsolete("Deprecated in favor of the customs_information object.")]
        public string CustomsInvoiceNr { get; set; }

        /// <summary>
        /// Customs shipment type
        /// 0 - Gift
        /// 1 - Documents
        /// 2 - Commercial Goods
        /// 3 - Commercial Sample
        /// 4 - Returned Goods
        /// Allowed values: 0 1 2 3 4
        /// </summary>
        [DataMember(Name = "customs_shipment_type", EmitDefaultValue = false, IsRequired = false)]
        [Obsolete("Deprecated in favor of the customs_information object.")]
        public CustomsShipmentType? CustomsShipmentType { get; set; }

        /// <summary>
        /// Can be used to uniquely identify a Parcel using your own external reference. This field is used to create idempotence.
        /// </summary>
        [DataMember(Name = "external_reference", EmitDefaultValue = false, IsRequired = false)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// ID of the selected service point
        /// </summary>
        [DataMember(Name = "to_service_point", EmitDefaultValue = false, IsRequired = false)]
        public int? ToServicePointId { get; set; }

        /// <summary>
        /// This field is mutually exclusive with the insured_value. Amount of total insurance to add. For XCover, this must be a positive value, larger than 2. If a value between 0 and 2 is sent, it is rounded up to 2. For Insureship (legacy): this must be a multiple of 100, for example, 100, 200, 300, etc. The maximum insurance is 5000 plus your shipping method’s insurance depending on the carrier. This field works by automatically calculating how much Sendcloud Insurance you’d need to add plus your shipping method’s insurance so it matches the exact value you’ve given. As an example, DPD insures all their shipments by 520€ by default. If you pass the total_insured_value: 5000 your shipment will have a total insurance coverage of 5000€, but you’re only paying for 4480€. Note: this value is an integer. If decimal numbers are sent, these are rounded up to the nearest whole number. Example: sending 72.35 results in a total_insured_value of 73.
        /// </summary>
        [DataMember(Name = "total_insured_value", EmitDefaultValue = false, IsRequired = false)]
        public int TotalInsuredValue { get; set; }

        /// <summary>
        /// Unique identifier that we assign to your shipment within the Sendcloud system.
        /// </summary>
        [DataMember(Name = "shipment_uuid", EmitDefaultValue = false, IsRequired = false)]
        public string ShipmentUuid { get; set; }

        /// <summary>
        /// List of items the order contains. Check the structure of a parcel_item in the “Parcel_items” section (remember, it’s a list of them!).
        /// </summary>
        [DataMember(Name = "parcel_items", EmitDefaultValue = false, IsRequired = false)]
        public ParcelItem[] ParcelItems { get; set; }

        /// <summary>
        /// Set to true if this parcel is a return
        /// </summary>
        [DataMember(Name = "is_return", EmitDefaultValue = false, IsRequired = false)]
        public bool IsReturn { get; set; }

        /// <summary>
        /// Parcel length in centimeters (will be used for volumetric weight calculation)
        /// </summary>
        [DataMember(Name = "length", EmitDefaultValue = false, IsRequired = false)]
        public string Length { get; set; }

        /// <summary>
        /// Parcel width in centimeters (will be used for volumetric weight calculation)
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public string Width { get; set; }

        /// <summary>
        /// Parcel height in centimeters (will be used for volumetric weight calculation). Note: You must provide length, width and height all at once for calculating volumetric weight or passing them as-is to carriers that require these properties Parcel height in centimeters (will be used for volumetric weight calculation). Note: You must provide length, width and height all at once for calculating volumetric weight or passing them as-is to carriers that require these properties
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public string Height { get; set; }


        [DataMember(Name = "date_created", EmitDefaultValue = false, IsRequired = false)]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = "date_announced", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? DateAnnounced { get; set; }

        [DataMember(Name = "date_updated", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? DateUpdated { get; set; }

        [DataMember(Name = "reference", EmitDefaultValue = false, IsRequired = false)]
        public string Reference { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
        public Status Status { get; set; }

        [DataMember(Name = "tracking_number", EmitDefaultValue = false, IsRequired = false)]
        public string TrackingNumber { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
        public Label Label { get; set; }

        [DataMember(Name = "to_state", EmitDefaultValue = false, IsRequired = false)]
        public string ToState { get; set; }

        [DataMember(Name = "documents", EmitDefaultValue = false, IsRequired = false)]
        public Document[] Documents { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "shipping_method", EmitDefaultValue = false, IsRequired = false)]
        public int? ShippingMethod { get; set; }

        [DataMember(Name = "external_order_id", EmitDefaultValue = false, IsRequired = false)]
        public string ExternalOrderId { get; set; }

        [DataMember(Name = "external_shipment_id", EmitDefaultValue = false, IsRequired = false)]
        public string ExternalShipmentId { get; set; }

        [DataMember(Name = "note", EmitDefaultValue = false, IsRequired = false)]
        public string Note { get; set; }

        [DataMember(Name = "colli_tracking_number", EmitDefaultValue = false, IsRequired = false)]
        public string ColliTrackingNumber { get; set; }

        [DataMember(Name = "colli_uuid", EmitDefaultValue = false, IsRequired = false)]
        public Guid ColliUuid { get; set; }

        [DataMember(Name = "collo_nr", EmitDefaultValue = false, IsRequired = false)]
        public int ColloNr { get; set; }

        [DataMember(Name = "collo_count", EmitDefaultValue = false, IsRequired = false)]
        public int ColloCount { get; set; }

        [DataMember(Name = "awb_tracking_number", EmitDefaultValue = false, IsRequired = false)]
        public string AwbTrackingNumber { get; set; }

        [DataMember(Name = "box_number", EmitDefaultValue = false, IsRequired = false)]
        public int? BoxNumber { get; set; }

        [DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = false)]
        public Carrier Carrier { get; set; }

        [DataMember(Name = "tracking_url", EmitDefaultValue = false, IsRequired = false)]
        public string TrackingUrl { get; set; }

        [DataMember(Name = "customs_information", EmitDefaultValue = false, IsRequired = false)]
        public CustomsInformation CustomsInformation { get; set; }
    }

    [DataContract]
    public class CreateParcel : Parcel<string>
    {
        /// <summary>
        /// House number of the recipient
        /// </summary>
        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = false)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Should the parcel request a label.
        /// </summary>
        [DataMember(Name = "request_label", EmitDefaultValue = false, IsRequired = false)]
        public bool RequestLabel { get; set; }

        /// <summary>
        /// Makes sure that the label is requested asynchronously. The parcel is returned, but without label. You will need to poll for status changes on the parcel.
        /// </summary>
        [DataMember(Name = "request_label_async", EmitDefaultValue = false, IsRequired = false)]
        public bool RequestLabelASync { get; set; }

        /// <summary>
        /// When set to True configured shipping rules will be applied before creating the label and announcing the Parcel
        /// </summary>
        [DataMember(Name = "apply_shipping_rules", EmitDefaultValue = false, IsRequired = false)]
        public bool ApplyShippingRules { get; set; }

        /// <summary>
        /// ID of the SenderAddress
        /// </summary>
        [DataMember(Name = "sender_address", EmitDefaultValue = false, IsRequired = false)]
        public int SenderAddressId { get; set; }

        /// <summary>
        /// Name of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromName { get; set; }

        /// <summary>
        /// Company name of the sender the parcel will be shipped from (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_company_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromCompanyName { get; set; }

        /// <summary>
        /// Address of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_address_1", EmitDefaultValue = false, IsRequired = false)]
        public string FromAddress1 { get; set; }

        /// <summary>
        /// Additional address information of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_address_2", EmitDefaultValue = false, IsRequired = false)]
        public string FromAddress2 { get; set; }

        /// <summary>
        /// House number of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_house_number", EmitDefaultValue = false, IsRequired = false)]
        public string FromHouseNumber { get; set; }

        /// <summary>
        /// City of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_city", EmitDefaultValue = false, IsRequired = false)]
        public string FromCity { get; set; }

        /// <summary>
        /// Zip code of the sender
        /// </summary>
        [DataMember(Name = "from_postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string FromPostalCode { get; set; }

        /// <summary>
        /// Country of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_country", EmitDefaultValue = false, IsRequired = false)]
        public string FromCountry { get; set; }

        /// <summary>
        /// Phone number of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_telephone", EmitDefaultValue = false, IsRequired = false)]
        public string FromTelephone { get; set; }

        /// <summary>
        /// E-mail address of the sender (when creating a return parcel)
        /// </summary>
        [DataMember(Name = "from_email", EmitDefaultValue = false, IsRequired = false)]
        public string FromEmail { get; set; }

        /// <summary>
        /// Code of the state (e.g. NY for New York) or province (e.g. RM for Rome). Destinations that require this field are USA, Canada, Italy and Australia. Errors related to this field will mention the to_state field.
        /// </summary>
        [DataMember(Name = "country_state", EmitDefaultValue = false, IsRequired = false)]
        public string CountryState { get; set; }

        /// <summary>
        /// Create a multi-collo shipment. Default value: 1. Minimal value: 1. Maximal value: 20. When request_label is true, it is required to use the Create multiple parcels method, since multiple parcels will be returned. When request_label is false, the number of parcels will be set according to this value in the incoming order overview.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false, IsRequired = false)]
        public int Quantity { get; set; }
    }
}
