using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class FormattedOpeningTimes
    {
        [DataMember(Name = "0", EmitDefaultValue = false)]
        public string[] Monday { get; set; }

        [DataMember(Name = "1", EmitDefaultValue = false)]
        public string[] Tuesday { get; set; }

        [DataMember(Name = "2", EmitDefaultValue = false)]
        public string[] Wednesday { get; set; }

        [DataMember(Name = "3", EmitDefaultValue = false)]
        public string[] Thursday { get; set; }

        [DataMember(Name = "4", EmitDefaultValue = false)]
        public string[] Friday { get; set; }

        [DataMember(Name = "5", EmitDefaultValue = false)]
        public string[] Saturday { get; set; }

        [DataMember(Name = "6", EmitDefaultValue = false)]
        public string[] Sunday { get; set; }
    }
}
