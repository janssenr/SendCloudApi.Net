using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ShippingOptionRequest
	{
		/// <summary>
		/// Sender address.
		/// </summary>
		[DataMember(Name = "from_address", EmitDefaultValue = false, IsRequired = false)]
		public ShippingOptionAddress FromAddress { get; set; }

		/// <summary>
		/// Destination address.
		/// </summary>
		[DataMember(Name = "to_address", EmitDefaultValue = false, IsRequired = false)]
		public ShippingOptionAddress ToAddress { get; set; }

		/// <summary>
		/// Node for service point information. Use the Retrieve a list of service points endpoint to find service points, or pass in the carrier's id for the service point.
		/// </summary>
		[DataMember(Name = "to_service_point", EmitDefaultValue = false, IsRequired = false)]
		public ServicePoint ToServicePoint { get; set; }

		/// <summary>
		/// List of parcels in a shipment.
		/// </summary>
		[DataMember(Name = "parcels", EmitDefaultValue = false, IsRequired = false)]
		public Parcel[] Parcels { get; set; }

		/// <summary>
		/// Shipping functionalities
		/// </summary>
		[DataMember(Name = "functionalities", EmitDefaultValue = false, IsRequired = false)]
		public ShippingFunctionalities Functionalities { get; set; }

		/// <summary>
		/// Carrier code.
		/// </summary>
		[DataMember(Name = "carrier_code", EmitDefaultValue = false, IsRequired = false)]
		public string CarrierCode { get; set; }

		/// <summary>
		/// Contract id.
		/// </summary>
		[DataMember(Name = "contract_id", EmitDefaultValue = false, IsRequired = false)]
		public int ContractId { get; set; }

		/// <summary>
		/// Shipping product code.
		/// </summary>
		[DataMember(Name = "shipping_product_code", EmitDefaultValue = false, IsRequired = false)]
		public string ShippingProductCode { get; set; }

		/// <summary>
		/// Specific shipping option code to use for pricing.
		/// </summary>
		[DataMember(Name = "shipping_option_code", EmitDefaultValue = false, IsRequired = false)]
		public string ShippingOptionCode { get; set; }

		/// <summary>
		/// Filter to trim down shipping options with a specific lead time.
		/// </summary>
		[DataMember(Name = "lead_time", EmitDefaultValue = false, IsRequired = false)]
		public LeadTimeFilter LeadTime { get; set; }

		/// <summary>
		/// If true, the quotes will be retrieved for the provided parcels and other parameters.
		///	If false, the quotes will not be retrieved, and the shipping options will be returned without quotes.
		///	This is useful when you want to return shipping options with/without retrieving quotes.
		///	The default value is false.
		/// </summary>
		[DataMember(Name = "calculate_quotes", EmitDefaultValue = false, IsRequired = false)]
		public bool CalculateQuotes { get; set; }
	}
}
