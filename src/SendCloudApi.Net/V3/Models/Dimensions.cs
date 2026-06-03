using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Dimensions
    {
		/// <summary>
		/// length in specified unit
		/// Example: 15
		/// </summary>
		[DataMember(Name = "length", EmitDefaultValue = false, IsRequired = true)]
		public double Length { get; set; }

		/// <summary>
		/// width in specified unit
		/// Example: 20.5
		/// </summary>
		[DataMember(Name = "width", EmitDefaultValue = false, IsRequired = true)]
		public double Width { get; set; }
		
		/// <summary>
		/// height in specified unit
		/// Example: 37
		/// </summary>
		[DataMember(Name = "height", EmitDefaultValue = false, IsRequired = true)]
        public double Height { get; set; }

		/// <summary>
		/// Available options: cm, mm, m, yd, ft, in
		/// Example: "mm"
		/// </summary>
		[DataMember(Name = "unit", EmitDefaultValue = false, IsRequired = true)]
        public string Unit { get; set; }
    }
}
