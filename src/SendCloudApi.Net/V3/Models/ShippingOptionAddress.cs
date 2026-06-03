using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ShippingOptionAddress
	{
		/// <summary>
		/// Country code in ISO 3166-1 alpha-2 format.
		/// Example: "NL"
		/// </summary>
		[DataMember(Name = "country_code", EmitDefaultValue = false, IsRequired = true)]
		public string CountryCode { get; set; }

		/// <summary>
		/// The postal code of the address. Should be provided, to make quotes as accurate as possible.
		/// Example: "1012AB"
		/// </summary>
		[DataMember(Name = "postal_code", EmitDefaultValue = false, IsRequired = false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// The first line of the address.
		/// Example: "Stadhuisplein 10"
		/// </summary>
		[DataMember(Name = "address_line_1", EmitDefaultValue = false, IsRequired = false)]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// The city of the address.
		/// Example: "Eindhoven"
		/// </summary>
		[DataMember(Name = "city", EmitDefaultValue = false, IsRequired = false)]
		public string City { get; set; }

		/// <summary>
		/// The state or province code represented as ISO 3166-2 code.
		/// Example: "RM-IT"
		/// </summary>
		[DataMember(Name = "state_province_code", EmitDefaultValue = false, IsRequired = false)]
		public string StateProvinceCode { get; set; }
	}
}
