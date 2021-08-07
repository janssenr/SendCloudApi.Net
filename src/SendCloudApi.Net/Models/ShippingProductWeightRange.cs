using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingProductWeightRange
    {
        [DataMember(Name = "min_weight", EmitDefaultValue = false, IsRequired = false)]
        public int MinWeight { get; set; }

        [DataMember(Name = "max_weight", EmitDefaultValue = false, IsRequired = false)]
        public int MaxWeight { get; set; }
    }
}
