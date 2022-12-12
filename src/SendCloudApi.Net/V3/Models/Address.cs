using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Address
    {
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "company", EmitDefaultValue = false, IsRequired = true)]
        public string Company { get; set; }

        [DataMember(Name = "address_1", EmitDefaultValue = false, IsRequired = true)]
        public string Address1 { get; set; }

        [DataMember(Name = "street", EmitDefaultValue = false, IsRequired = true)]
        public string Street { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = true)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "address_2", EmitDefaultValue = false, IsRequired = true)]
        public string Address2 { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = true)]
        public string PostalCode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        /// <summary>
        /// ISO 3166-2 2 character state code
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false, IsRequired = true)]
        public string State { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = true)]
        public string Country { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = true)]
        public string Email { get; set; }

        [DataMember(Name = "phone", EmitDefaultValue = false, IsRequired = true)]
        public string Phone { get; set; }
    }
}
