using System.Runtime.Serialization;

namespace SendCloudApi.Net.Exceptions
{
    [DataContract]
    public class SendCloudErrorDetails
    {
        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

        [DataMember(Name = "request", EmitDefaultValue = false, IsRequired = false)]
        public string Request { get; set; }
    }
}
