using System.Runtime.Serialization;

namespace SendCloudApi.Net.Exceptions
{
    [DataContract]
    public class SendCloudError
    {
        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
        public string Status { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "error", EmitDefaultValue = false, IsRequired = false)]
        public SendCloudErrorDetails Error { get; set; }
    }
}
