using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class AddressDivided
    {
        [DataMember(Name = "street", EmitDefaultValue = false, IsRequired = true)]
        public string Street { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = true)]
        public string HouseNumber { get; set; }
    }
}
