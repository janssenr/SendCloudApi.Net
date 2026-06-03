using SendCloudApi.Net.V2.Models;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ShippingPriceBreakdown
	{
		/// <summary>
		/// Type of price. It is an identifier for the category of the price.
		/// </summary>
		public Category Type { get; set; }
		[DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
		private string TypeString
		{
			get { return Type.ToStringExtended(); }
			set { Type = value.ToCategory(); }
		}


		/// <summary>
		/// Friendly name for the price type.
		/// Example: "Initial price per parcel"
		/// </summary>
		[DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
		public string Label { get; set; }

		/// <summary>
		/// The price of the breakdown item.
		/// </summary>
		[DataMember(Name = "price", EmitDefaultValue = false, IsRequired = false)]
		public Price Price { get; set; }
	}
}
