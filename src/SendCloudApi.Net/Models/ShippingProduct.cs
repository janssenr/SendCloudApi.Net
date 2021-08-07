using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingProduct
    {
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = false)]
        public string Carrier { get; set; }

        [DataMember(Name = "service_points_carrier", EmitDefaultValue = false, IsRequired = false)]
        public string ServicePointsCarrier { get; set; }

        [DataMember(Name = "available_functionalities", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, string[]> AvailableFunctionalities { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

        [DataMember(Name = "methods", EmitDefaultValue = false, IsRequired = false)]
        public ShippingProductMethod[] Methods { get; set; }

        [DataMember(Name = "weight_range", EmitDefaultValue = false, IsRequired = false)]
        public ShippingProductWeightRange WeightRange { get; set; }
    }
}
