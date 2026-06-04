using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class AddressValidationAnalysis
	{
		/// <summary>
		/// The result of the validation process.
		/// </summary>
		[DataMember(Name = "validation_result", EmitDefaultValue = false, IsRequired = false)]
		public AddressValidationAnalysisValidationResult ValidationResult { get; set; }

		/// <summary>
		/// List of changed attributes.
		/// </summary>
		[DataMember(Name = "changed_attributes", EmitDefaultValue = false, IsRequired = false)]
		public string[] ChangedAttributes { get; set; }
	}
}
