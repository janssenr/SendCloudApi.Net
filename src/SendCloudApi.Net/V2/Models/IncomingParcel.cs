using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class IncomingParcel
    {
        [DataMember(Name = "collo_count", EmitDefaultValue = false, IsRequired = false)]
        public int ColloCount { get; set; }

        [DataMember(Name = "from_address_1", EmitDefaultValue = false, IsRequired = false)]
        public string FromAddress1 { get; set; }

        [DataMember(Name = "from_address_2", EmitDefaultValue = false, IsRequired = false)]
        public string FromAddress2 { get; set; }

        [DataMember(Name = "from_city", EmitDefaultValue = false, IsRequired = false)]
        public string FromCity { get; set; }

        [DataMember(Name = "from_company_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromCompanyName { get; set; }

        [DataMember(Name = "from_country", EmitDefaultValue = false, IsRequired = false)]
        public string FromCountry { get; set; }

        [DataMember(Name = "from_email", EmitDefaultValue = false, IsRequired = false)]
        public string FromEmail { get; set; }

        [DataMember(Name = "from_house_number", EmitDefaultValue = false, IsRequired = false)]
        public string FromHouseNumber { get; set; }

        [DataMember(Name = "from_name", EmitDefaultValue = false, IsRequired = false)]
        public string FromName { get; set; }

        [DataMember(Name = "from_postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string FromPostalCode { get; set; }

        [DataMember(Name = "from_telephone", EmitDefaultValue = false, IsRequired = false)]
        public string FromTelephone { get; set; }
    }
}
