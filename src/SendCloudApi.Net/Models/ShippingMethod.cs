using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingMethod
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = false)]
        public string Carrier { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
        public decimal Price { get; set; }

        [DataMember(Name = "min_weight", EmitDefaultValue = false, IsRequired = false)]
        public decimal MinWeight { get; set; }

        [DataMember(Name = "max_weight", EmitDefaultValue = false, IsRequired = false)]
        public decimal MaxWeight { get; set; }

        [DataMember(Name = "service_point_input", EmitDefaultValue = false, IsRequired = false)]
        public string ServicePointInput { get; set; }

        [DataMember(Name = "countries", EmitDefaultValue = false, IsRequired = false)]
        public Country[] Countries { get; set; }
    }
}
