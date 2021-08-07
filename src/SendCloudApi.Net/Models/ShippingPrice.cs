using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShippingPrice
    {
        [DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
        public string Price { get; set; }


        [DataMember(Name = "currency", EmitDefaultValue = false, IsRequired = false)]
        public string Currency { get; set; }
    }
}
