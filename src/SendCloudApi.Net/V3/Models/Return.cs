using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Return
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "is_cancellable", EmitDefaultValue = false, IsRequired = false)]
        public bool IsCancellable { get; set; }

        [DataMember(Name = "label_cost", EmitDefaultValue = false, IsRequired = false)]
        public Price LabelCost { get; set; }

        [DataMember(Name = "delivered_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? DeliveredAt { get; set; }

        [DataMember(Name = "shipping_product", EmitDefaultValue = false, IsRequired = false)]
        public ShippingProduct ShippingProduct { get; set; }

        [DataMember(Name = "collo_count", EmitDefaultValue = false, IsRequired = false)]
        public int ColloCount { get; set; }

        [DataMember(Name = "brand_id", EmitDefaultValue = false, IsRequired = false)]
        public int BrandId { get; set; }

        [DataMember(Name = "tracking_number", EmitDefaultValue = false, IsRequired = false)]
        public string TrackingNumber { get; set; }

        [DataMember(Name = "dimensions", EmitDefaultValue = false, IsRequired = true)]
        public Dimensions Dimensions { get; set; }

        [DataMember(Name = "parcel_items", EmitDefaultValue = false, IsRequired = false)]
        public ParcelItem[] ParcelItems { get; set; }

        [DataMember(Name = "insurance", EmitDefaultValue = false, IsRequired = false)]
        public bool Insurance { get; set; }

        [DataMember(Name = "label_url", EmitDefaultValue = false, IsRequired = false)]
        public string LabelUrl { get; set; }

        [DataMember(Name = "tracking_url", EmitDefaultValue = false, IsRequired = false)]
        public string TrackingUrl { get; set; }

        [DataMember(Name = "send_tracking_emails", EmitDefaultValue = true, IsRequired = true)]
        public bool SendTrackingEmails { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = true)]
        public Weight Weight { get; set; }

        [DataMember(Name = "from_address", EmitDefaultValue = false, IsRequired = true)]
        public SenderAddress FromAddress { get; set; }

        [DataMember(Name = "to_address", EmitDefaultValue = false, IsRequired = true)]
        public RecipientAddress ToAddress { get; set; }

        [DataMember(Name = "reason", EmitDefaultValue = false, IsRequired = false)]
        public ReturnReason Reason { get; set; }

        [DataMember(Name = "order_number", EmitDefaultValue = false, IsRequired = true)]
        public string OrderNumber { get; set; }

        [DataMember(Name = "status_history", EmitDefaultValue = false, IsRequired = false)]
        public DetailedTrackingStatus[] StatusHistory { get; set; }

        [DataMember(Name = "ship_with", EmitDefaultValue = false, IsRequired = false)]
        public ShipWith ShipWith { get; set; }

        [DataMember(Name = "contract", EmitDefaultValue = false, IsRequired = false)]
        public int Contract { get; set; }

        [DataMember(Name = "total_insured_value", EmitDefaultValue = true, IsRequired = false)]
        public Price TotalInsuredValue { get; set; }

        [DataMember(Name = "total_order_value", EmitDefaultValue = false, IsRequired = false)]
        public Price TotalOrderValue { get; set; }

        [DataMember(Name = "external_reference", EmitDefaultValue = false, IsRequired = false)]
        public string ExternalReference { get; set; }
    }
}
