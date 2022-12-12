using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Refund
    {
        [DataMember(Name = "refund_type", EmitDefaultValue = false, IsRequired = false)]
        public RefundType RefundType { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "reason", EmitDefaultValue = false, IsRequired = false)]
        public int ReasonId { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
        public string Status { get; set; }

        [DataMember(Name = "outgoing_parcel", EmitDefaultValue = false, IsRequired = false)]
        public int OutgoingParcelId { get; set; }

        [DataMember(Name = "incoming_parcel", EmitDefaultValue = false, IsRequired = false)]
        public int IncomingParcelId { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "total_refund", EmitDefaultValue = false, IsRequired = false)]
        public string TotalRefund { get; set; }

        [DataMember(Name = "refunded_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? RefundedAt { get; set; }
    }
}
