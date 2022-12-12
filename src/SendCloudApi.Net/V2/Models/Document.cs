using SendCloudApi.Net.Helpers;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Document
    {
        public DocumentType Type { get; set; }
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        internal string TypeString
        {
            get { return Type.ToStringExtended(); }
            set { Type = value.ToDocumentType(); }
        }

        [DataMember(Name = "size", EmitDefaultValue = false, IsRequired = false)]
        public string Size { get; set; }

        [DataMember(Name = "link", EmitDefaultValue = false, IsRequired = false)]
        public string Link { get; set; }
    }
}
