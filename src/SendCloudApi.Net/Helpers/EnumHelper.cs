using System;

namespace SendCloudApi.Net.Helpers
{
    public static class EnumHelper<T> where T: struct, IConvertible
    {
        public static string ToFriendlyName(T me)
        {
            throw new NotImplementedException();
        }

        public static T ToEnumValue(string enumerationDescription)
        {
            var type = typeof(T);

            if (!type.IsEnum)
                throw new ArgumentException("ToEnumValue<T>(): Must be of enum type", "T");

            foreach (object val in Enum.GetValues(type))
                if (ToFriendlyName((T)val) == enumerationDescription)
                    return (T)val;

            throw new ArgumentException("ToEnumValue<T>(): Invalid description for enum " + type.Name, "enumerationDescription");
        }
    }
}
