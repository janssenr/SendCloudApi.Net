using System.Runtime.Serialization;

namespace SendCloudApi.Net.Exceptions
{
    [DataContract]
    public class SendCloudError
    {
        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = true)]
        public string Message { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = true)]
        public string Code { get; set; }

        [DataMember(Name = "request", EmitDefaultValue = false, IsRequired = true)]
        public string Request { get; set; }
    }
}
