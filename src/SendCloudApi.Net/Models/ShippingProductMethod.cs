using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingProductMethod
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "functionalities", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, string> Functionalities { get; set; }

        [DataMember(Name = "shipping_product_code", EmitDefaultValue = false, IsRequired = false)]
        public string ShippingProductCode { get; set; }

        [DataMember(Name = "properties", EmitDefaultValue = false, IsRequired = false)]
        public ShippingProductMethodProperty Properties { get; set; }

        [DataMember(Name = "lead_time_hours", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Dictionary<string, int>> LeadTimeHours { get; set; }
    }
}
