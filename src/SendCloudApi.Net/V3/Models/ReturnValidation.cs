using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ReturnValidation : Return
    {
        [DataMember(Name = "is_valid", EmitDefaultValue = false, IsRequired = true)]
        public bool IsValid { get; set; }
    }
}
