using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ParcelItem
    {
        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = true)]
        public string Description { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false, IsRequired = true)]
        public int Quantity { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = true)]
        public double Weight { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public double Value { get; set; }

        [DataMember(Name = "hs_code", EmitDefaultValue = false, IsRequired = true)]
        public string HarmonizedSystemCode { get; set; }

        [DataMember(Name = "origin_country", EmitDefaultValue = false, IsRequired = true)]
        public string OriginCountry { get; set; }
    }
}
