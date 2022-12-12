using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Portal
    {
        [DataMember(Name = "reasons", EmitDefaultValue = false, IsRequired = false)]
        public Reason[] Reasons { get; set; }

        [DataMember(Name = "support_url", EmitDefaultValue = false, IsRequired = false)]
        public string SupportUrl { get; set; }

        [DataMember(Name = "brand", EmitDefaultValue = false, IsRequired = false)]
        public Brand Brand { get; set; }

        [DataMember(Name = "languages", EmitDefaultValue = false, IsRequired = false)]
        public string[] Languages { get; set; }

        [DataMember(Name = "enable_refunds", EmitDefaultValue = false, IsRequired = false)]
        public bool EnableRefunds { get; set; }

        [DataMember(Name = "return_fee", EmitDefaultValue = false, IsRequired = false)]
        public string ReturnFee { get; set; }

        [DataMember(Name = "delivery_options", EmitDefaultValue = false, IsRequired = false)]
        public string[] DeliveryOptions { get; set; }
    }
}
