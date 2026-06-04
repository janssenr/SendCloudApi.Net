using System.Linq;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class AddressValidationRequest
	{
		/// <summary>
		/// Raw address object
		/// </summary>
		[DataMember(Name = "address", EmitDefaultValue = false, IsRequired = true)]
		public RawAddress Address { get; set; }

		/// <summary>
		/// The code of the carrier to be used for the address validation. Only carriers available to your account can be used.
		/// Example: "trunkrs"
		/// </summary>
		[DataMember(Name = "carrier_code", EmitDefaultValue = false, IsRequired = true)]
		public string CarrierCode { get; set; }

		/// <summary>
		/// An array of optional address validation methods to be applied.
		/// The default Sendcloud validation will always be applied.
		/// </summary>
		public AddressValidationMethod[] ValidationMethods { get; set; }
		[DataMember(Name = "validation_methods", EmitDefaultValue = false, IsRequired = false)]
		private string[] ValidationMethodsString
		{
			get { return ValidationMethods.Select(vm => vm.ToStringExtended()).ToArray(); }
			set { ValidationMethods = value.Select(v => v.ToAddressValidationMethod()).ToArray(); }
		}
	}
}
