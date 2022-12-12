using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Country
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
        public decimal? Price { get; set; }

        [DataMember(Name = "iso_2", EmitDefaultValue = false, IsRequired = true)]
        public string Iso2 { get; set; }

        [DataMember(Name = "iso_3", EmitDefaultValue = false, IsRequired = true)]
        public string Iso3 { get; set; }

        [DataMember(Name = "from_id", EmitDefaultValue = false, IsRequired = false)]
        public int FromId { get; set; }

        [DataMember(Name = "from_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromName { get; set; }

        [DataMember(Name = "from_iso_2", EmitDefaultValue = false, IsRequired = false)]
        public string FromIso2 { get; set; }

        [DataMember(Name = "from_iso_3", EmitDefaultValue = false, IsRequired = false)]
        public string FromIso3 { get; set; }
    }
}
