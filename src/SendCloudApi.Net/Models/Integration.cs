using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Integration
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "shop_name", EmitDefaultValue = false, IsRequired = false)]
        public string ShopName { get; set; }

        [DataMember(Name = "shop_url", EmitDefaultValue = false, IsRequired = false)]
        public string ShopUrl { get; set; }

        [DataMember(Name = "system", EmitDefaultValue = false, IsRequired = false)]
        public string System { get; set; }

        [DataMember(Name = "failing_since", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? FailingSince { get; set; }

        [DataMember(Name = "last_fetch", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? LastFetch { get; set; }

        [DataMember(Name = "last_updated_at", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? LastUpdatedAt { get; set; }

        [DataMember(Name = "service_point_enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool ServicePointEnabled { get; set; }

        [DataMember(Name = "service_point_carriers", EmitDefaultValue = false, IsRequired = false)]
        public string[] ServicePointCarriers { get; set; }

        [DataMember(Name = "webhook_active", EmitDefaultValue = false, IsRequired = false)]
        public bool WebhookActive { get; set; }

        [DataMember(Name = "webhook_url", EmitDefaultValue = false, IsRequired = false)]
        public string WebhookUrl { get; set; }
    }
}
