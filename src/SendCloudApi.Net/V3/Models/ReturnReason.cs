using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ReturnReason
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = true)]
        public string Description { get; set; }
    }
}
