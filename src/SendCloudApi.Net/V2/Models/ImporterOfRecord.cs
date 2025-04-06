using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ImporterOfRecord
    {
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }

        [DataMember(Name = "address_1", EmitDefaultValue = false, IsRequired = true)]
        public string Address1 { get; set; }

        [DataMember(Name = "address_2", EmitDefaultValue = false, IsRequired = false)]
        public string Address2 { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = false)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = true)]
        public string PostalCode { get; set; }

        [DataMember(Name = "country_code", EmitDefaultValue = false, IsRequired = true)]
        public string CountryCode { get; set; }

        [DataMember(Name = "country_state", EmitDefaultValue = false, IsRequired = false)]
        public string CountryState { get; set; }

        [DataMember(Name = "telephone", EmitDefaultValue = false, IsRequired = false)]
        public string Telephone { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }
    }
}
