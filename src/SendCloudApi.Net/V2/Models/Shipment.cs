using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{

    [DataContract]
    public class Shipment
    {
        [DataMember(Name = "address", EmitDefaultValue = false, IsRequired = false)]
        public string Address { get; set; }

        [DataMember(Name = "address_2", EmitDefaultValue = false, IsRequired = false)]
        public string Address2 { get; set; }

        [DataMember(Name = "allowed_shipping_methods", EmitDefaultValue = false, IsRequired = false)]
        public int[] AllowedShippingMethods { get; set; }

        [DataMember(Name = "barcode", EmitDefaultValue = false, IsRequired = false)]
        public string Barcode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }

        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = false)]
        public string Country { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "currency", EmitDefaultValue = false, IsRequired = false)]
        public string Currency { get; set; }

        [DataMember(Name = "customs_invoice_nr", EmitDefaultValue = false, IsRequired = false)]
        public string CustomsInvoiceNr { get; set; }

        [DataMember(Name = "customs_shipment_type", EmitDefaultValue = false, IsRequired = false)]
        public CustomsShipmentType? CustomsShipmentType { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }

        [DataMember(Name = "external_order_id", EmitDefaultValue = false, IsRequired = false)]
        public string ExternalOrderId { get; set; }

        [DataMember(Name = "external_shipment_id", EmitDefaultValue = false, IsRequired = false)]
        public string ExternalShipmentId { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = true)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "integration", EmitDefaultValue = false, IsRequired = true)]
        public int IntegrationId { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "order_number", EmitDefaultValue = false, IsRequired = false)]
        public string OrderNumber { get; set; }

        [DataMember(Name = "order_status", EmitDefaultValue = false, IsRequired = false)]
        public Status OrderStatus { get; set; }

        [DataMember(Name = "parcel_items", EmitDefaultValue = false, IsRequired = false)]
        public ParcelItem[] ParcelItems { get; set; }

        [DataMember(Name = "payment_status", EmitDefaultValue = false, IsRequired = false)]
        public Status PaymentStatus { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string PostalCode { get; set; }

        [DataMember(Name = "sender_address", EmitDefaultValue = false, IsRequired = false)]
        public int SenderAddressId { get; set; }

        [DataMember(Name = "shipment_uuid", EmitDefaultValue = false, IsRequired = false)]
        public string ShipmentUuid { get; set; }

        [DataMember(Name = "shipping_method", EmitDefaultValue = false, IsRequired = false)]
        public int? ShippingMethodId { get; set; }

        [DataMember(Name = "shipping_method_checkout_name", EmitDefaultValue = false, IsRequired = false)]
        public string ShippingMethodCheckoutName { get; set; }

        [DataMember(Name = "telephone", EmitDefaultValue = false, IsRequired = false)]
        public string Telephone { get; set; }

        [DataMember(Name = "to_post_number", EmitDefaultValue = false, IsRequired = false)]
        public string ToPostNumber { get; set; }

        [DataMember(Name = "to_service_point", EmitDefaultValue = false, IsRequired = false)]
        public int? ToServicePointId { get; set; }

        [DataMember(Name = "to_state", EmitDefaultValue = false, IsRequired = false)]
        public string ToState { get; set; }

        [DataMember(Name = "total_order_value", EmitDefaultValue = false, IsRequired = false)]
        public string TotalOrderValue { get; set; }

        [DataMember(Name = "updated_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
        public double Weight { get; set; }

        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public string Width { get; set; }

        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public string Height { get; set; }

        [DataMember(Name = "length", EmitDefaultValue = false, IsRequired = false)]
        public string Length { get; set; }

        //[DataMember(Name = "errors", EmitDefaultValue = false, IsRequired = false)]
        //public Dictionary<string, List<string>> Errors { get; set; }
    }
}
