using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Logo
    {
        [DataMember(Name = "url", EmitDefaultValue = false, IsRequired = false)]
        public string Url { get; set; }

    }
}
