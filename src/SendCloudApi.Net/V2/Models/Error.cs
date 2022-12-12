using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
        public string Status { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "error", EmitDefaultValue = false, IsRequired = false)]
        public ErrorDetails ErrorDetails { get; set; }
    }
}
