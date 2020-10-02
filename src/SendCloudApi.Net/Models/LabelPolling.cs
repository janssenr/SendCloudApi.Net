using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class LabelPolling
    {
        [DataMember(Name = "download_url", EmitDefaultValue = false, IsRequired = false)]
        public string DownloadUrl { get; set; }

        [DataMember(Name = "tracking_numbers", EmitDefaultValue = false, IsRequired = false)]
        public string[] TrackingNumbers { get; set; }

        [DataMember(Name = "parcels", EmitDefaultValue = false, IsRequired = false)]
        public int[] ParcelIds { get; set; }

        [DataMember(Name = "return", EmitDefaultValue = false, IsRequired = false)]
        public int ReturnId { get; set; }
    }
}
