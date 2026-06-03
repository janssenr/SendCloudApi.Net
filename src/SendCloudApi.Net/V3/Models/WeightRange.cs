using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class WeightRange
	{
		/// <summary>
		/// Minimum allowed parcel dimensions for this quote.
		/// </summary>
		[DataMember(Name = "min", EmitDefaultValue = false, IsRequired = false)]
		public Weight Min { get; set; }

		/// <summary>
		/// Maximum allowed parcel weight for this quote.
		/// </summary>
		[DataMember(Name = "max", EmitDefaultValue = false, IsRequired = false)]
		public Weight Max { get; set; }
	}
}
