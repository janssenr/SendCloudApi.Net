using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class AddressValidationResult
	{
		/// <summary>
		/// The validated address details. In case null is returned, the address is not valid and the details are not available (f.e.the address validator is not available).
		/// </summary>
		[DataMember(Name = "address", EmitDefaultValue = false, IsRequired = false)]
		public RawAddress Address { get; set; }

		/// <summary>
		/// The method used for address validation, null stands for the Sendcloud address carrier optimizer validation method.
		/// </summary>
		public AddressValidationMethod ValidationMethod { get; set; }
		[DataMember(Name = "validation_method", EmitDefaultValue = false, IsRequired = false)]
		private string ValidationMethodString
		{
			get { return ValidationMethod.ToStringExtended(); }
			set { ValidationMethod = value.ToAddressValidationMethod(); }
		}

		/// <summary>
		/// Indicates if the address is recommended after validation.
		/// </summary>
		[DataMember(Name = "recommended", EmitDefaultValue = false, IsRequired = false)]
		public bool Recommended { get; set; }

		/// <summary>
		/// Analysis details of the address validation process. In case null is returned no analysis details are available.
		/// </summary>
		[DataMember(Name = "analysis", EmitDefaultValue = false, IsRequired = false)]
		public AddressValidationAnalysis Analysis { get; set; }
	}
}
