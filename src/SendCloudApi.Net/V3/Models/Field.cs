using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public enum Field
	{
		[EnumMember(Value = "to_email")]
		ToEmail,
		[EnumMember(Value = "to_telephone")]
		ToTelephone,
		[EnumMember(Value = "length")]
		Length,
		[EnumMember(Value = "width")]
		Width,
		[EnumMember(Value = "height")]
		Height,
	}
}
