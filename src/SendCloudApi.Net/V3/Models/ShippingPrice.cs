using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ShippingPrice
	{
		[DataMember(Name = "breakdown", EmitDefaultValue = false, IsRequired = false)]
		public ShippingPriceBreakdown[] Breakdown { get; set; }

		[DataMember(Name = "total", EmitDefaultValue = false, IsRequired = false)]
		public Price Total { get; set; }
	}
}
