using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class DetailedTrackingStatus
    {
        [DataMember(Name = "carrier_update_timestamp", EmitDefaultValue = false, IsRequired = true)]
        public string CarrierUpdateTimestamp { get; set; }

        [DataMember(Name = "parcel_status_history_id", EmitDefaultValue = false, IsRequired = true)]
        public string ParcelStatusHistoryId { get; set; }

        [DataMember(Name = "parent_status", EmitDefaultValue = false, IsRequired = true)]
        public string ParentStatus { get; set; }

        [DataMember(Name = "carrier_code", EmitDefaultValue = false, IsRequired = true)]
        public string CarrierCode { get; set; }

        [DataMember(Name = "carrier_message", EmitDefaultValue = false, IsRequired = true)]
        public string CarrierMessage { get; set; }
    }
}
