using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Label
    {
        [DataMember(Name = "normal_printer", EmitDefaultValue = false, IsRequired = false)]
        public string[] NormalPrinter { get; set; }

        [DataMember(Name = "label_printer", EmitDefaultValue = false, IsRequired = false)]
        public string LabelPrinter { get; set; }

        [DataMember(Name = "parcels", EmitDefaultValue = false, IsRequired = false)]
        public int[] ParcelIds { get; set; }
    }
}
