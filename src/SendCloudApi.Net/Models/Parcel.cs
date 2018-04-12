using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Parcel<T>
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false, IsRequired = false)]
        public string Address { get; set; }

        [DataMember(Name = "address_2", EmitDefaultValue = false, IsRequired = false)]
        public string Address2 { get; set; }

        [DataMember(Name = "address_divided", EmitDefaultValue = false, IsRequired = false)]
        public AddressDivided AddressDivided { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }

        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = false)]
        public T Country { get; set; }

        [DataMember(Name = "date_created", EmitDefaultValue = false, IsRequired = false)]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string PostalCode { get; set; }

        [DataMember(Name = "reference", EmitDefaultValue = false, IsRequired = false)]
        public string Reference { get; set; }

        [DataMember(Name = "shipment", EmitDefaultValue = false, IsRequired = false)]
        public ShippingMethod Shipment { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
        public ParcelStatus Status { get; set; }

        [DataMember(Name = "to_service_point", EmitDefaultValue = false, IsRequired = false)]
        public int? ToServicePointId { get; set; }

        [DataMember(Name = "telephone", EmitDefaultValue = false, IsRequired = false)]
        public string Telephone { get; set; }

        [DataMember(Name = "tracking_number", EmitDefaultValue = false, IsRequired = false)]
        public string TrackingNumber { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
        public double Weight { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
        public Label Label { get; set; }

        [DataMember(Name = "order_number", EmitDefaultValue = false, IsRequired = false)]
        public string OrderNumber { get; set; }

        [DataMember(Name = "insured_value", EmitDefaultValue = false, IsRequired = false)]
        public int InsuredValue { get; set; }

        [DataMember(Name = "total_insured_value", EmitDefaultValue = false, IsRequired = false)]
        public int TotalInsuredValue { get; set; }

        [DataMember(Name = "to_state", EmitDefaultValue = false, IsRequired = false)]
        public string ToState { get; set; }

        [DataMember(Name = "customs_invoice_nr", EmitDefaultValue = false, IsRequired = false)]
        public string CustomsInvoiceNr { get; set; }

        [DataMember(Name = "customs_shipment_type", EmitDefaultValue = false, IsRequired = false)]
        public CustomsShipmentType? CustomsShipmentType { get; set; }

        [DataMember(Name = "parcel_items", EmitDefaultValue = false, IsRequired = false)]
        public ParcelItem[] ParcelItems { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = false)]
        public Carrier Carrier { get; set; }

        [DataMember(Name = "tracking_url", EmitDefaultValue = false, IsRequired = false)]
        public string TrackingUrl { get; set; }
    }

    [DataContract]
    public class CreateParcel : Parcel<string>
    {
        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = false)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "request_label", EmitDefaultValue = false, IsRequired = false)]
        public bool RequestLabel { get; set; }

        [DataMember(Name = "request_label_async", EmitDefaultValue = false, IsRequired = false)]
        public bool RequestLabelASync { get; set; }

        [DataMember(Name = "sender_address", EmitDefaultValue = false, IsRequired = false)]
        public int SenderAddressId { get; set; }

        [DataMember(Name = "from_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromName { get; set; }

        [DataMember(Name = "from_company_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromCompanyName { get; set; }

        [DataMember(Name = "from_address_1", EmitDefaultValue = false, IsRequired = false)]
        public string FromAddress1 { get; set; }

        [DataMember(Name = "from_address_2", EmitDefaultValue = false, IsRequired = false)]
        public string FromAddress2 { get; set; }

        [DataMember(Name = "from_house_number", EmitDefaultValue = false, IsRequired = false)]
        public string FromHouseNumber { get; set; }

        [DataMember(Name = "from_city", EmitDefaultValue = false, IsRequired = false)]
        public string FromCity { get; set; }

        [DataMember(Name = "from_postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string FromPostalCode { get; set; }

        [DataMember(Name = "from_country", EmitDefaultValue = false, IsRequired = false)]
        public string FromCountry { get; set; }

        [DataMember(Name = "from_telephone", EmitDefaultValue = false, IsRequired = false)]
        public string FromTelephone { get; set; }

        [DataMember(Name = "from_email", EmitDefaultValue = false, IsRequired = false)]
        public string FromEmail { get; set; }

        [DataMember(Name = "country_state", EmitDefaultValue = false, IsRequired = false)]
        public string CountryState { get; set; }
    }
}
