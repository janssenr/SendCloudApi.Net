using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class Surcharge
	{
		/// <summary>
		/// The price of the surcharge item.
		/// </summary>
		[DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
		public Price Price { get; set; }

		/// <summary>
		/// Friendly name for the surcharge type.
		/// </summary>
		[DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
		public string Label { get; set; }

		/// <summary>
		/// Type of surcharge. It is an identifier for the category of the surcharge.
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
		public Category Type { get; set; }
	}
}
