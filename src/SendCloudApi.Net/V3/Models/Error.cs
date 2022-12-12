using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "field", EmitDefaultValue = false, IsRequired = true)]
        public string Field { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = true)]
        public string Message { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = true)]
        public string Code { get; set; }
    }
}
