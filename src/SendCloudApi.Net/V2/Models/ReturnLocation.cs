using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ReturnLocation
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "country_name", EmitDefaultValue = false, IsRequired = false)]
        public string CountryName { get; set; }

        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }

        [DataMember(Name = "address_1", EmitDefaultValue = false, IsRequired = false)]
        public string Address1 { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = false)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "address_2", EmitDefaultValue = false, IsRequired = false)]
        public string Address2 { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string PostalCode { get; set; }
    }
}
