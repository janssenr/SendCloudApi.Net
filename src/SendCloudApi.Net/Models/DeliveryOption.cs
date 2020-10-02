using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public enum DeliveryOption
    {
        [EnumMember(Value = "drop_off_point")]
        DropOffPoint,
        [EnumMember(Value = "in_store")]
        InStore,
    }

    internal static class DeliveryOptionExtensions
    {
        public static string ToStringExtended(this DeliveryOption me)
        {
            switch (me)
            {
                case DeliveryOption.DropOffPoint:
                    return "drop_off_point";
                case DeliveryOption.InStore:
                    return "in_store";
                default:
                    throw new NotImplementedException();
            }
        }

        public static DeliveryOption ToDeliveryOption(this string enumerationDescription)
        {
            var type = typeof(DeliveryOption);

            foreach (DeliveryOption val in Enum.GetValues(typeof(DeliveryOption)))
                if (val.ToStringExtended() == enumerationDescription)
                    return val;

            throw new ArgumentException("ToEnumValue(): Invalid description for enum " + type.Name, "enumerationDescription");
        }
    }
}
