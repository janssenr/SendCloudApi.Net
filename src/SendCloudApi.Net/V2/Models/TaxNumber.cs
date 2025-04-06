using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class TaxNumber
    {
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "country_code", EmitDefaultValue = false, IsRequired = false)]
        public string CountryCode { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public string Value { get; set; }
    }
}
