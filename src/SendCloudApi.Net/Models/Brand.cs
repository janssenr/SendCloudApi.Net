using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class Brand
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "color", EmitDefaultValue = false, IsRequired = false)]
        public string Color { get; set; }

        [DataMember(Name = "secondary_color", EmitDefaultValue = false, IsRequired = false)]
        public string SecondaryColor { get; set; }

        [DataMember(Name = "website", EmitDefaultValue = false, IsRequired = false)]
        public string Website { get; set; }

        [DataMember(Name = "overlay_logo", EmitDefaultValue = false, IsRequired = false)]
        public Logo OverlayLogo { get; set; }

        [DataMember(Name = "screen_logo", EmitDefaultValue = false, IsRequired = false)]
        public Logo ScreenLogo { get; set; }

        [DataMember(Name = "print_logo", EmitDefaultValue = false, IsRequired = false)]
        public Logo PrintLogo { get; set; }

        [DataMember(Name = "overlay_thumb", EmitDefaultValue = false, IsRequired = false)]
        public string OverlayThumb { get; set; }

        [DataMember(Name = "screen_thumb", EmitDefaultValue = false, IsRequired = false)]
        public string ScreenThumb { get; set; }

        [DataMember(Name = "print_thumb", EmitDefaultValue = false, IsRequired = false)]
        public string PrintThumb { get; set; }

        [DataMember(Name = "notify_reply_to_email", EmitDefaultValue = false, IsRequired = false)]
        public bool? NotifyReplyToEmail { get; set; }

        [DataMember(Name = "domain", EmitDefaultValue = false, IsRequired = false)]
        public string Domain { get; set; }

        [DataMember(Name = "notify_bcc_email", EmitDefaultValue = false, IsRequired = false)]
        public bool? NotifyBccEmail { get; set; }

        [DataMember(Name = "hide_powered_by", EmitDefaultValue = false, IsRequired = false)]
        public bool HidePoweredBy { get; set; }
    }
}
