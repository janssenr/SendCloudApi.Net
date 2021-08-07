using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Dimensions
    {
        [DataMember(Name = "length", EmitDefaultValue = false, IsRequired = false)]
        public int Length { get; set; }

        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int Width { get; set; }

        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public int Height { get; set; }
    }
}
