using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ParcelCancel
    {
        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = true)]
        public string Status { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = true)]
        public string Message { get; set; }
    }
}
