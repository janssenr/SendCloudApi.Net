using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingFunctionality
    {
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "default_value", EmitDefaultValue = false, IsRequired = false)]
        public string DefaultValue { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "enum", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, ShippingFunctionalityOption> Enum { get; set; }

        [DataMember(Name = "pattern", EmitDefaultValue = false, IsRequired = false)]
        public string Pattern { get; set; }
    }
}
