using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public enum RefundTypeCode
    {
        [EnumMember(Value = "money")]
        Money,
        [EnumMember(Value = "credit")]
        Credit,
        [EnumMember(Value = "exchange")]
        Exchange,
    }

    internal static class RefundTypeCodeExtensions
    {
        public static string ToFriendlyString(this RefundTypeCode me)
        {
            switch (me)
            {
                case RefundTypeCode.Money:
                    return "money";
                case RefundTypeCode.Credit:
                    return "credit";
                case RefundTypeCode.Exchange:
                    return "exchange";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
