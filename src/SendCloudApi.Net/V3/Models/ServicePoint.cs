using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ServicePoint
	{
		/// <summary>
		/// Unique Sendcloud identifier of the service point.
		/// Example: 1000001
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
		public int id { get; set; }

		/// <summary>
		/// Carrier-specific identifier of the service point.
		/// Example: "NL-00001"
		/// </summary>
		[DataMember(Name = "carrier_service_point_id", EmitDefaultValue = false, IsRequired = false)]
		public string CarrierServicePointId { get; set; }
	}
}
