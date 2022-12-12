using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Wrappers
{
    [DataContract]
    public class DataWrapper<T>
    {
        [DataMember(Name = "next", EmitDefaultValue = false, IsRequired = true)]
        public string Next { get; set; }

        [DataMember(Name = "previous", EmitDefaultValue = false, IsRequired = true)]
        public string Previous { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false, IsRequired = true)]
        public T[] Data { get; set; }
    }
}
