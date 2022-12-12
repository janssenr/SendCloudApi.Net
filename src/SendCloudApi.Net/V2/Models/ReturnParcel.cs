using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ReturnParcel
    {
        [DataMember(Name = "outgoing_parcel", EmitDefaultValue = false, IsRequired = false)]
        public int OutgoingParcelId { get; set; }

        [DataMember(Name = "products", EmitDefaultValue = false, IsRequired = false)]
        public ReturnParcelProduct[] Products { get; set; }

        [DataMember(Name = "incoming_parcel", EmitDefaultValue = false, IsRequired = false)]
        public IncomingParcel IncomingParcel { get; set; }

        [DataMember(Name = "refund", EmitDefaultValue = false, IsRequired = false)]
        public Refund Refund { get; set; }

        [DataMember(Name = "delivery_option", EmitDefaultValue = false, IsRequired = false)]
        public DeliveryOption DeliveryOption { get; set; }

        [DataMember(Name = "service_point", EmitDefaultValue = false, IsRequired = false)]
        public ServicePoint ServicePoint { get; set; }

        [DataMember(Name = "reason", EmitDefaultValue = false, IsRequired = false)]
        public int? ReasonId { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }
    }
}
