using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class AddressValidationResponse
	{
		/// <summary>
		/// Indicates if the input address is valid. In case null is returned, the address is not valid and the details are not available (f.e.the address validator is not available).
		/// </summary>
		[DataMember(Name = "input_address_is_valid", EmitDefaultValue = false, IsRequired = false)]
		public bool InputAddressIsValid { get; set; }

		/// <summary>
		/// The results of the address validation.
		/// </summary>
		[DataMember(Name = "results", EmitDefaultValue = false, IsRequired = false)]
		public AddressValidationResult[] Results { get; set; }
	}
}
