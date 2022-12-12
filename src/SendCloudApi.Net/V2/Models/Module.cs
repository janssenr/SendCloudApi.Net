using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Module
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "settings", EmitDefaultValue = false, IsRequired = true)]
        public ModuleSettings Settings { get; set; }

        [DataMember(Name = "activated", EmitDefaultValue = false, IsRequired = true)]
        public bool Activated { get; set; }

        [DataMember(Name = "short_name", EmitDefaultValue = false, IsRequired = true)]
        public string ShortName { get; set; }
    }
}
