using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
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

        [DataMember(Name = "hs_code", EmitDefaultValue = false, IsRequired = false)]
        public string HarmonizedSystemCode { get; set; }

        [DataMember(Name = "origin_country", EmitDefaultValue = false, IsRequired = false)]
        public string OriginCountry { get; set; }

        [DataMember(Name = "product_id", EmitDefaultValue = false, IsRequired = false)]
        public string ProductId { get; set; }

        [DataMember(Name = "properties", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, object> Properties { get; set; }

        [DataMember(Name = "sku", EmitDefaultValue = false, IsRequired = false)]
        public string StockKeepingUnit { get; set; }
    }
}
