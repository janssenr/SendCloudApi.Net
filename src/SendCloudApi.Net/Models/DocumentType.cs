using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public enum DocumentType
    {
        Label,
        CP71,
        CN23,
        CommercialInvoice,
        CN23Default
    }

    internal static class DocumentTypeExtensions
    {
        public static string ToStringExtended(this DocumentType me)
        {
            switch (me)
            {
                case DocumentType.Label:
                    return "label";
                case DocumentType.CP71:
                    return "cp71";
                case DocumentType.CN23:
                    return "cn23";
                case DocumentType.CommercialInvoice:
                    return "commercial‑invoice";
                case DocumentType.CN23Default:
                    return "cn23‑default";
                default:
                    throw new NotImplementedException();
            }
        }

        public static DocumentType ToDocumentType(this string enumerationDescription)
        {
            var type = typeof(DeliveryOption);

            foreach (DocumentType val in Enum.GetValues(typeof(DocumentType)))
                if (val.ToStringExtended() == enumerationDescription)
                    return val;

            throw new ArgumentException("ToEnumValue(): Invalid description for enum " + type.Name, "enumerationDescription");
        }
    }
}
