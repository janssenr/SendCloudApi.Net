using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class ShippingOption
	{
		/// <summary>
		/// Unique identifier for this Shipping option. You can use this code to announce a parcel in the Parcel API.
		/// Example: "postnl:standard/insured=3000"
		/// </summary>
		[DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
		public string Code { get; set; }

		/// <summary>
		/// Shipping option friendly name
		/// Example: "PostNL insured up to 3000 euro"
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
		public string Name { get; set; }

		/// <summary>
		/// Carrier
		/// </summary>
		[DataMember(Name = "carrier", EmitDefaultValue = false, IsRequired = false)]
		public Carrier Carrier { get; set; }

		/// <summary>
		/// Shipping product
		/// </summary>
		[DataMember(Name = "product", EmitDefaultValue = false, IsRequired = false)]
		public ShippingProduct Product { get; set; }

		/// <summary>
		/// Shipping functionalities
		/// </summary>
		[DataMember(Name = "functionalities", EmitDefaultValue = false, IsRequired = false)]
		public ShippingFunctionalities Functionalities { get; set; }

		/// <summary>
		/// Maximum allowed parcel dimensions for this option.
		/// </summary>
		[DataMember(Name = "max_dimensions", EmitDefaultValue = false, IsRequired = false)]
		public Dimensions MaxDimensions { get; set; }

		/// <summary>
		/// Weight range allowed for this option.
		/// </summary>
		[DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
		public WeightRange Weight { get; set; }

		/// <summary>
		/// If dimensions are provided, the volumetric weight will be calculated. The billed weight will indicate which is the highest of the regular weight and the volumetric weight.
		/// </summary>
		[DataMember(Name = "parcel_billed_weights", EmitDefaultValue = false, IsRequired = false)]
		public MultiColloBilledWeight[] ParcelBilledWeights { get; set; }

		/// <summary>
		/// Carrier contract that will be used by this option.
		/// </summary>
		[DataMember(Name = "contract", EmitDefaultValue = false, IsRequired = false)]
		public Contract Contract { get; set; }

		public ChargingType ChargingType { get; set; }
		[DataMember(Name = "charging_type", EmitDefaultValue = false, IsRequired = false)]
		private string ChargingTypeString
		{
			get { return ChargingType.ToStringExtended(); }
			set { ChargingType = value.ToChargingType(); }
		}

		/// <summary>
		/// Carrier contract that will be used by this option.
		/// </summary>
		[DataMember(Name = "requirements", EmitDefaultValue = false, IsRequired = false)]
		public Requirements Requirements { get; set; }

		/// <summary>
		/// List of available quotes.
		/// </summary>
		[DataMember(Name = "quotes", EmitDefaultValue = false, IsRequired = false)]
		public ShippingQuote[] ShippingQuotes { get; set; }
	}
}
