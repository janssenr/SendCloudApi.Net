using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ServicePoint
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

        [DataMember(Name = "is_active", EmitDefaultValue = false, IsRequired = false)]
        public bool IsActive { get; set; }

        [DataMember(Name = "extra_data", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, string> ExtraData { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "street", EmitDefaultValue = false, IsRequired = false)]
        public string Street { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = false)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string PostalCode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        [DataMember(Name = "latitude", EmitDefaultValue = false, IsRequired = false)]
        public string Latitude { get; set; }

        [DataMember(Name = "longitude", EmitDefaultValue = false, IsRequired = false)]
        public string Longitude { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }

        [DataMember(Name = "phone", EmitDefaultValue = false, IsRequired = false)]
        public string Phone { get; set; }

        [DataMember(Name = "homepage", EmitDefaultValue = false, IsRequired = false)]
        public string Homepage { get; set; }

        [DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = false)]
        public string Carrier { get; set; }

        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = false)]
        public string Country { get; set; }

        [DataMember(Name = "formatted_opening_times", EmitDefaultValue = false, IsRequired = false)]
        public FormattedOpeningTimes FormattedOpeningTimes { get; set; }

        [DataMember(Name = "open_tomorrow", EmitDefaultValue = false, IsRequired = false)]
        public bool OpenTomorrow { get; set; }

        [DataMember(Name = "distance", EmitDefaultValue = false, IsRequired = false)]
        public int Distance { get; set; }
    }
}
