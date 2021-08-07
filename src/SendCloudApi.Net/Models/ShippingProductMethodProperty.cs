using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingProductMethodProperty
    {
        [DataMember(Name = "min_weight", EmitDefaultValue = false, IsRequired = false)]
        public int MinWeight { get; set; }

        [DataMember(Name = "max_weight", EmitDefaultValue = false, IsRequired = false)]
        public int MaxWeight { get; set; }

        [DataMember(Name = "max_dimensions", EmitDefaultValue = false, IsRequired = false)]
        public Dimensions MaxDimensions { get; set; }
    }
}
