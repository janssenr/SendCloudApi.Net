using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ReturnParcelProduct
    {
        [DataMember(Name = "product_id", EmitDefaultValue = false, IsRequired = false)]
        public int ProductId { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false, IsRequired = false)]
        public int Quantity { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public string Value { get; set; }

        [DataMember(Name = "return_reason", EmitDefaultValue = false, IsRequired = false)]
        public int ReturnReasonId { get; set; }

        [DataMember(Name = "return_message ", EmitDefaultValue = false, IsRequired = false)]
        public string ReturnMessage { get; set; }
    }
}
