using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ParcelItem
    {
        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = true)]
        public string Description { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false, IsRequired = true)]
        public int Quantity { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = true)]
        public Weight Weight { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public Price Value { get; set; }

        [DataMember(Name = "hs_code", EmitDefaultValue = false, IsRequired = true)]
        public string HSCode { get; set; }

        [DataMember(Name = "origin_country", EmitDefaultValue = false, IsRequired = true)]
        public string OriginCountry { get; set; }

        [DataMember(Name = "sku", EmitDefaultValue = false, IsRequired = true)]
        public string SKU { get; set; }

        [DataMember(Name = "product_id", EmitDefaultValue = false, IsRequired = true)]
        public string ProductId { get; set; }
    }
}
