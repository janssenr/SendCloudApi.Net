using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ShippingProduct
    {
        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = true)]
        public string Code { get; set; }
    }
}
