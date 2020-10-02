using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class RefundType
    {
        public RefundTypeCode Code { get; set; }
        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        internal string CodeString
        {
            get { return Code.ToFriendlyString(); }
            set { Code = (RefundTypeCode)Enum.Parse(typeof(RefundTypeCode), value, true); }
        }

        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
        public string Label { get; set; }

        [DataMember(Name = "require_message", EmitDefaultValue = false, IsRequired = false)]
        public bool RequireMessage { get; set; }
    }
}
