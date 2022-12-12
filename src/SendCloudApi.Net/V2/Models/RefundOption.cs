using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class RefundOption
    {
        [DataMember(Name = "require_message", EmitDefaultValue = false, IsRequired = false)]
        public bool RequireMessage { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
        public string Label { get; set; }
    }
}
