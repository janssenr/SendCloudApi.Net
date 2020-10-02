using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class WebhookEvent
    {
        [DataMember(Name = "action", EmitDefaultValue = false, IsRequired = true)]
        public string Action { get; set; }

        [DataMember(Name = "timestamp", EmitDefaultValue = false, IsRequired = false)]
        public long TimeStamp { get; set; }

        [DataMember(Name = "integration", EmitDefaultValue = false, IsRequired = false)]
        public Integration Integration { get; set; }

        [DataMember(Name = "parcel", EmitDefaultValue = false, IsRequired = false)]
        public Parcel<Country> Parcel { get; set; }

        [DataMember(Name = "refund", EmitDefaultValue = false, IsRequired = false)]
        public Refund Refund { get; set; }
    }
}
