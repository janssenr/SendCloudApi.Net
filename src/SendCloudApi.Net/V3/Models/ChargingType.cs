using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public enum ChargingType
	{
		[EnumMember(Value = "label_creation")]
		LabelCreation,
		[EnumMember(Value = "first_scan")]
		FirstScan,
	}

	internal static class ChargingTypeExtensions
	{
		public static string ToStringExtended(this ChargingType me)
		{
			switch (me)
			{
				case ChargingType.LabelCreation:
					return "label_creation";
				case ChargingType.FirstScan:
					return "first_scan";
				default:
					throw new NotImplementedException();
			}
		}

		public static ChargingType ToChargingType(this string enumerationDescription)
		{
			var type = typeof(ChargingType);

			foreach (ChargingType val in Enum.GetValues(typeof(ChargingType)))
				if (val.ToStringExtended() == enumerationDescription)
					return val;

			throw new ArgumentException("ToEnumValue(): Invalid description for enum " + type.Name, "enumerationDescription");
		}
	}

}
