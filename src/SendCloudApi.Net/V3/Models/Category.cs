using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public enum Category
	{
		[EnumMember(Value = "price_without_insurance")]
		PriceWithoutInsurance,
		[EnumMember(Value = "insurance_price")]
		InsurancePrice,
		[EnumMember(Value = "volume")]
		Volume,
		[EnumMember(Value = "weight")]
		Weight,
		[EnumMember(Value = "weight_volume")]
		WeightVolume,
		[EnumMember(Value = "internal_correction")]
		InternalCorrection,
		[EnumMember(Value = "seasonal")]
		Seasonal,
		[EnumMember(Value = "fuel")]
		Fuel,
		[EnumMember(Value = "remote")]
		Remote,
		[EnumMember(Value = "toll")]
		Toll,
		[EnumMember(Value = "dimensional")]
		Dimensional,
		[EnumMember(Value = "customs")]
		Customs,
		[EnumMember(Value = "returns")]
		Returns,
		[EnumMember(Value = "label_quality")]
		LabelQuality,
		[EnumMember(Value = "packaging")]
		Packaging,
		[EnumMember(Value = "pickup")]
		Pickup,
		[EnumMember(Value = "residential")]
		Residential,
		[EnumMember(Value = "address_corrections")]
		AddressCorrections,
		[EnumMember(Value = "overcharge")]
		Overcharge,
		[EnumMember(Value = "forbidden_item")]
		ForbiddenItem,
		[EnumMember(Value = "other")]
		Other,
	}

	internal static class CategoryExtensions
	{
		public static string ToStringExtended(this Category me)
		{
			switch (me)
			{
				case Category.PriceWithoutInsurance:
					return "price_without_insurance";
				case Category.InsurancePrice:
					return "insurance_price";
				case Category.Volume:
					return "volume";
				case Category.Weight:
					return "weight";
				case Category.WeightVolume:
					return "weight_volume";
				case Category.InternalCorrection:
					return "internal_correction";
				case Category.Seasonal:
					return "seasonal";
				case Category.Fuel:
					return "fuel";
				case Category.Remote:
					return "remote";
				case Category.Toll:
					return "toll";
				case Category.Dimensional:
					return "dimensional";
				case Category.Customs:
					return "customs";
				case Category.Returns:
					return "returns";
				case Category.LabelQuality:
					return "label_quality";
				case Category.Packaging:
					return "packaging";
				case Category.Pickup:
					return "pickup";
				case Category.Residential:
					return "residential";
				case Category.AddressCorrections:
					return "address_corrections";
				case Category.Overcharge:
					return "overcharge";
				case Category.ForbiddenItem:
					return "forbidden_item";
				case Category.Other:
					return "other";
				default:
					throw new NotImplementedException();
			}
		}

		public static Category ToCategory(this string enumerationDescription)
		{
			var type = typeof(Category);

			foreach (Category val in Enum.GetValues(typeof(Category)))
				if (val.ToStringExtended() == enumerationDescription)
					return val;

			throw new ArgumentException("ToEnumValue(): Invalid description for enum " + type.Name, "enumerationDescription");
		}
	}
}
