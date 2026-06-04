using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "field", EmitDefaultValue = false, IsRequired = false)]
        public string Field { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

		[DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
		public string Status { get; set; }
		
        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

		[DataMember(Name = "detail", EmitDefaultValue = false, IsRequired = false)]
		public string Detail { get; set; }
	}
}
