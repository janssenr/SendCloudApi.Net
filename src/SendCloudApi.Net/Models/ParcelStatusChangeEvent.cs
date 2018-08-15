using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ParcelStatusChangeEvent
    {
        [DataMember(Name = "action", EmitDefaultValue = false, IsRequired = true)]
        public string Action { get; set; }

        [DataMember(Name = "timestamp", EmitDefaultValue = false, IsRequired = false)]
        public long TimeStamp { get; set; }

        [DataMember(Name = "parcel", EmitDefaultValue = false, IsRequired = false)]
        public Parcel<Country> Parcel { get; set; }
    }
}
