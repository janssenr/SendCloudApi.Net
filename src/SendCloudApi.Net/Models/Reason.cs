using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Reason
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }
    }
}
