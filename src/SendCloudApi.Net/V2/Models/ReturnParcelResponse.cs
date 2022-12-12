using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class ReturnParcelResponse
    {
        [DataMember(Name = "poller_url", EmitDefaultValue = false, IsRequired = false)]
        public string PollerUrl { get; set; }

        [DataMember(Name = "return", EmitDefaultValue = false, IsRequired = false)]
        public int ReturnId { get; set; }

        [DataMember(Name = "incoming_parcels", EmitDefaultValue = false, IsRequired = false)]
        public int[] IncomingParcelIds { get; set; }
    }
}
