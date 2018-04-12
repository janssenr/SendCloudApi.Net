using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class ModuleSettings
    {
        [DataMember(Name = "automate_tracking_number", EmitDefaultValue = false, IsRequired = true)]
        public bool AutomateTrackingNumber { get; set; }

        [DataMember(Name = "automate_order_status", EmitDefaultValue = false, IsRequired = true)]
        public bool AutomateOrderStatus { get; set; }
    }
}
