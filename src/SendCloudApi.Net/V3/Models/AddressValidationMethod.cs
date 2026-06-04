using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public enum AddressValidationMethod
	{
		[EnumMember(Value = "here")]
		Here,
	}

	internal static class ValidationMethodExtensions
	{
		public static string ToStringExtended(this AddressValidationMethod me)
		{
			switch (me)
			{
				case AddressValidationMethod.Here:
					return "here";
				default:
					throw new NotImplementedException();
			}
		}

		public static AddressValidationMethod ToAddressValidationMethod(this string enumerationDescription)
		{
			var type = typeof(AddressValidationMethod);

			foreach (AddressValidationMethod val in Enum.GetValues(typeof(AddressValidationMethod)))
				if (val.ToStringExtended() == enumerationDescription)
					return val;

			throw new ArgumentException("ToEnumValue(): Invalid description for enum " + type.Name, "enumerationDescription");
		}
	}
}
