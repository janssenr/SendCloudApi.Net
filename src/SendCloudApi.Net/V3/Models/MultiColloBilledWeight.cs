using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class MultiColloBilledWeight : Weight
	{
		/// <summary>
		/// Indicates if the parcel will be billed based on volumetric weight.
		/// </summary>
		[DataMember(Name = "volumetric", EmitDefaultValue = false, IsRequired = false)]
		public bool Volumetric { get; set; }

		/// <summary>
		/// Represent which parcel the billed weight belongs to.
		/// </summary>
		[DataMember(Name = "parcel_number", EmitDefaultValue = false, IsRequired = false)]
		public int ParcelNumber { get; set; }

		/// <summary>
		/// Calculation for how the volumetric weight is calculated.
		/// </summary>
		[DataMember(Name = "calculation", EmitDefaultValue = false, IsRequired = false)]
		public string Calculation { get; set; }
	}
}
