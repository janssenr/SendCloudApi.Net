using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Price
    {
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public double Value { get; set; }

        [DataMember(Name = "currency", EmitDefaultValue = false, IsRequired = true)]
        public string Currency { get; set; }
    }
}
