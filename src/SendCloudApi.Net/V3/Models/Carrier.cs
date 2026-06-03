using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class Carrier
	{
		/// <summary>
		/// Unique identifier of the carrier.
		/// </summary>
		[DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
		public string Code { get; set; }

		/// <summary>
		/// The carrier name in a representational format.
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
		public string Name { get; set; }
	}
}
