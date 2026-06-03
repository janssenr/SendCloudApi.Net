using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Wrappers
{
    [DataContract]
    public class DataWrapper<T>
    {
        [DataMember(Name = "next", EmitDefaultValue = false, IsRequired = false)]
        public string Next { get; set; }

        [DataMember(Name = "previous", EmitDefaultValue = false, IsRequired = false)]
        public string Previous { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false, IsRequired = true)]
        public T[] Data { get; set; }

		[DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
		public string Message { get; set; }
	}
}
