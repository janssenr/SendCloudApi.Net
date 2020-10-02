using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ShopDistance
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "distance", EmitDefaultValue = false, IsRequired = false)]
        public int Distance { get; set; }
    }
}
