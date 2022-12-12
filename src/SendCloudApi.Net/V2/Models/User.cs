using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "username", EmitDefaultValue = false, IsRequired = true)]
        public string Username { get; set; }

        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = true)]
        public string CompanyName { get; set; }

        [DataMember(Name = "telephone", EmitDefaultValue = false, IsRequired = true)]
        public string Telephone { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false, IsRequired = true)]
        public string Address { get; set; }

        [DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = true)]
        public string PostalCode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = true)]
        public string Email { get; set; }

        [DataMember(Name = "company_logo", EmitDefaultValue = false, IsRequired = true)]
        public string CompanyLogo { get; set; }

        [DataMember(Name = "registered", EmitDefaultValue = false, IsRequired = true)]
        public DateTime Registered { get; set; }

        [DataMember(Name = "modules", EmitDefaultValue = false, IsRequired = true)]
        public Module[] Modules { get; set; }

        //[DataMember(Name = "invoices", EmitDefaultValue = false, IsRequired = true)]
        //public Invoice<string>[] Invoices { get; set; }
    }
}
