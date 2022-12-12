using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Weight
    {
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public double Value { get; set; }

        [DataMember(Name = "unit", EmitDefaultValue = false, IsRequired = true)]
        public string Unit { get; set; }
    }
}
