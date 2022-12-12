using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Dimensions
    {
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = true)]
        public double Height { get; set; }

        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = true)]
        public double Width { get; set; }

        [DataMember(Name = "length", EmitDefaultValue = false, IsRequired = true)]
        public double Length { get; set; }

        [DataMember(Name = "unit", EmitDefaultValue = false, IsRequired = true)]
        public string Unit { get; set; }
    }
}
