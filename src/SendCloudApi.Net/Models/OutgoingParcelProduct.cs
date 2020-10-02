using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class OutgoingParcelProduct
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
        public string Price { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false, IsRequired = true)]
        public int Quantity { get; set; }
    }
}
