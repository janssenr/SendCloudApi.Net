using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Status
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public string Id { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = true)]
        public string Message { get; set; }

        [DataMember(Name = "global_status_slug", EmitDefaultValue = false, IsRequired = false)]
        public string GlobalStatusSlug { get; set; }
    }
}
