using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class Parcel
	{
		/// <summary>
		/// While dimensions are optional, some carriers require them present. If this is the case, an error will be thrown.
		/// </summary>
		[DataMember(Name = "dimensions", EmitDefaultValue = false, IsRequired = false)]
		public Dimensions Dimensions { get; set; }

		/// <summary>
		/// Weight in the specified unit
		/// </summary>
		[DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
		public Weight Weight { get; set; }

		/// <summary>
		/// Amount for which you want to add additional insurance (on top of carrier insurance) to the parcel with our insurance provider XCover. You can insure up from 2 euros to 5000 euros per shipment.
		/// </summary>
		[DataMember(Name = "additional_insured_price", EmitDefaultValue = false, IsRequired = false)]
		public int AdditionalInsuredPrice { get; set; }

		/// <summary>
		/// Amount for which you want to insure the parcel with (including the carrier insurance) our insurance provider XCover. If both additional_insured_price and total_insured_price are provided, additional_insured_price will take precedence.
		/// </summary>
		[DataMember(Name = "total_insured_price", EmitDefaultValue = false, IsRequired = false)]
		public int TotalInsuredPrice { get; set; }
	}
}
