using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class SenderAddress
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = true)]
        public string CompanyName { get; set; }

        [DataMember(Name = "contact_name", EmitDefaultValue = false, IsRequired = true)]
        public string ContactName { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = true)]
        public string Email { get; set; }

        [DataMember(Name = "telephone", EmitDefaultValue = false, IsRequired = true)]
        public string Telephone { get; set; }

        [DataMember(Name = "street", EmitDefaultValue = false, IsRequired = true)]
        public string Street { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = true)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "postal_box", EmitDefaultValue = false, IsRequired = true)]
        public string PostalBox { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = true)]
        public string PostalCode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = true)]
        public string Country { get; set; }

        [DataMember(Name = "country_state", EmitDefaultValue = false, IsRequired = true)]
        public string CountryState { get; set; }

        [DataMember(Name = "vat_number", EmitDefaultValue = false, IsRequired = true)]
        public string VatNumber { get; set; }

        [DataMember(Name = "eori_number", EmitDefaultValue = false, IsRequired = true)]
        public string EORINumber { get; set; }
    }
}
