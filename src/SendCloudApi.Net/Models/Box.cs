using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Box
    {
        [DataMember(Name = "copy_count ", EmitDefaultValue = false, IsRequired = false)]
        public int CopyCount { get; set; }
    }
}
