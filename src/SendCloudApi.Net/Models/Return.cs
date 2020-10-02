using SendCloudApi.Net.Helpers;
using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Return
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "reason", EmitDefaultValue = false, IsRequired = false)]
        public int ReasonId { get; set; }

        [DataMember(Name = "outgoing_parcel", EmitDefaultValue = false, IsRequired = false)]
        public int OutgoingParcelId { get; set; }

        [DataMember(Name = "incoming_parcel", EmitDefaultValue = false, IsRequired = false)]
        public int IncomingParcelId { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "refund", EmitDefaultValue = false, IsRequired = false)]
        public Refund Refund { get; set; }

        [DataMember(Name = "is_cancellable", EmitDefaultValue = false, IsRequired = false)]
        public bool IsCancellable { get; set; }

        [DataMember(Name = "return_fee", EmitDefaultValue = false, IsRequired = false)]
        public decimal ReturnFee { get; set; }

        [DataMember(Name = "return_fee_currency", EmitDefaultValue = false, IsRequired = false)]
        public string ReturnFeeCurrency { get; set; }

        [DataMember(Name = "label_cost", EmitDefaultValue = false, IsRequired = false)]
        public decimal LabelCost { get; set; }

        [DataMember(Name = "items_cost", EmitDefaultValue = false, IsRequired = false)]
        public decimal ItemsCost { get; set; }

        [DataMember(Name = "delivered_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? DeliveredAt { get; set; }

        public DeliveryOption DeliveryOption { get; set; }
        [DataMember(Name = "delivery_option", EmitDefaultValue = false, IsRequired = false)]
        internal string DeliveryOptionString
        {
            get { return DeliveryOption.ToStringExtended(); }
            set { DeliveryOption = value.ToDeliveryOption(); }
        }

        [DataMember(Name = "store_location", EmitDefaultValue = false, IsRequired = false)]
        public string StoreLocation { get; set; }

        [DataMember(Name = "outgoing_parcel_data", EmitDefaultValue = false, IsRequired = false)]
        public Parcel<Country> OutgoingParcelData { get; set; }

        [DataMember(Name = "incoming_parcel_data", EmitDefaultValue = false, IsRequired = false)]
        public Parcel<Country> IncomingParcelData { get; set; }
    }
}
