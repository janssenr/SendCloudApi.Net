using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Weight
    {
		/// <summary>
		/// Weight value
		/// Example: 14.5
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public double Value { get; set; }

		/// <summary>
		/// Available options: kg, g, lbs, oz
		/// Example: "g"
		/// </summary>
		[DataMember(Name = "unit", EmitDefaultValue = false, IsRequired = true)]
        public string Unit { get; set; }
    }
}
