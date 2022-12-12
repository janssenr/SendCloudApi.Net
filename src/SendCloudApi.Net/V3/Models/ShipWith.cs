using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ShipWith
    {
        [DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = true)]
        public string Carrier { get; set; }

        [DataMember(Name = "functionalities", EmitDefaultValue = false, IsRequired = true)]
        public ShippingFunctionalities Functionalities { get; set; }
    }
}
