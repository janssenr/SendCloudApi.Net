using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
	[DataContract]
	public class Contract
	{
		[DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
		public int Id { get; set; }

		[DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
		public string Type { get; set; }
	}
}
