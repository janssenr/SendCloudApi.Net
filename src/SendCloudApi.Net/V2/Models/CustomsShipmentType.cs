using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public enum CustomsShipmentType
    {
        [EnumMember]
        Gift = 0,
        [EnumMember]
        Documents = 1,
        [EnumMember]
        CommercialGoods = 2,
        [EnumMember]
        CommercialSample = 3,
        [EnumMember]
        ReturnedGoods = 4
    }
}
