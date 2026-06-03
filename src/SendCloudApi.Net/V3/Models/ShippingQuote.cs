using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ShippingQuote
	{
		/// <summary>
		/// Weight range allowed for this qoute.
		/// </summary>
		[DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
		public WeightRange Weight { get; set; }

		/// <summary>
		/// Lead time of this quote in hours.
		/// Example: 24	
		/// </summary>
		[DataMember(Name = "lead_time", EmitDefaultValue = false, IsRequired = false)]
		public int LeadTime { get; set; }

		/// <summary>
		/// Lead time of this quote in hours.
		/// Example: 24	
		/// </summary>
		[DataMember(Name = "estimated_surcharges", EmitDefaultValue = false, IsRequired = false)]
		public Surcharge[] EstimatedSurcharges { get; set; }

		/// <summary>
		/// Lead time of this quote in hours.
		/// Example: 24	
		/// </summary>
		[DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
		public ShippingPrice Price { get; set; }
	}
}
