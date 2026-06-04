using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class AddressValidationAnalysisValidationResult
	{
		/// <summary>
		/// Indicates if the address is valid.
		/// </summary>
		[DataMember(Name = "is_valid", EmitDefaultValue = false, IsRequired = false)]
		public bool IsValid { get; set; }

		/// <summary>
		/// List of reasons for the validation result.
		/// </summary>
		[DataMember(Name = "reasons", EmitDefaultValue = false, IsRequired = false)]
		public string[] Reasons { get; set; }
	}
}
