using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class LeadTimeFilter
	{
		[DataMember(Name = "gt", EmitDefaultValue = false, IsRequired = false)]
		public int GreaterThen { get; set; }

		[DataMember(Name = "gte", EmitDefaultValue = false, IsRequired = false)]
		public int GreaterThenOrEqual { get; set; }

		[DataMember(Name = "eq", EmitDefaultValue = false, IsRequired = false)]
		public int Equal { get; set; }

		[DataMember(Name = "lt", EmitDefaultValue = false, IsRequired = false)]
		public int LessThen { get; set; }

		[DataMember(Name = "lte", EmitDefaultValue = false, IsRequired = false)]
		public int LessThenOrEqual { get; set; }
	}
}
