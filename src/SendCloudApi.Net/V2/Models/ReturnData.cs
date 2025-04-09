using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ReturnData
    {
        [DataMember(Name = "return_postal_code", EmitDefaultValue = false, IsRequired = false)]
        public string ReturnPostalCode { get; set; }

        [DataMember(Name = "outbound_tracking_number", EmitDefaultValue = false, IsRequired = false)]
        public string OutboundTrackingNumber { get; set; }

        [IgnoreDataMember]
        public DateTime? OutboundShipmentDate { get; set; }

        [DataMember(Name = "outbound_shipment_date", EmitDefaultValue = false, IsRequired = false)]
        public string OutboundShipmentDateFormatted
        {
            get => OutboundShipmentDate?.ToString("yyyy-MM-dd");
            set => OutboundShipmentDate = string.IsNullOrWhiteSpace(value) ? (DateTime?)null : DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        [DataMember(Name = "outbound_carrier_name", EmitDefaultValue = false, IsRequired = false)]
        public string OutboundCarrierName { get; set; }
    }
}
