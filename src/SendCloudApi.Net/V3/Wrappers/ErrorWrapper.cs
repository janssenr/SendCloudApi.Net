using SendCloudApi.Net.V3.Models;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Wrappers
{
    [DataContract]
    public class ErrorWrapper
    {
        [DataMember(Name = "errors", EmitDefaultValue = false, IsRequired = true)]
        public Error[] Errors { get; set; }
    }
}
