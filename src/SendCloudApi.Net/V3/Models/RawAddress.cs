using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class RawAddress
	{
		/// <summary>
		/// First line of the address
		/// Example: "Stadhuisplein"
		/// </summary>
		[DataMember(Name = "address_line_1", EmitDefaultValue = false, IsRequired = false)]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// House number of the address
		/// Example: "50"
		/// </summary>
		[DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = false)]
		public string HouseNumber { get; set; }

		/// <summary>
		/// Additional address information, e.g. 2nd level
		/// Example: "Apartment 17B"
		/// </summary>
		[DataMember(Name = "address_line_2", EmitDefaultValue = false, IsRequired = false)]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Zip code of the address
		/// Example: "1013 AB"
		/// </summary>
		[DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// City of the address
		/// Example: "Eindhoven"
		/// </summary>
		[DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
		public string City { get; set; }

		/// <summary>
		/// Code required in case of PO Box or post locker delivery
		/// </summary>
		[DataMember(Name = "po_box", EmitDefaultValue = false, IsRequired = false)]
		public string PoBox { get; set; }

		/// <summary>
		/// The character state code of the customer represented as ISO 3166-2 code. This field is required for certain countries. See international shipping for details.
		/// Example: "IT-RM" 
		/// </summary>
		[DataMember(Name = "state_province_code", EmitDefaultValue = false, IsRequired = false)]
		public string StateProvinceCode { get; set; }

		/// <summary>
		/// The country code of the customer represented as ISO 3166-1 alpha-2
		/// Example: "NL"
		/// </summary>
		[DataMember(Name = "country_code", EmitDefaultValue = false, IsRequired = false)]
		public string CountryCode { get; set; }
	}
}
