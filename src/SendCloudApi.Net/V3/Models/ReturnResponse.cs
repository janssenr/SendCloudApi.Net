using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ReturnResponse
    {
        [DataMember(Name = "return_id", EmitDefaultValue = false, IsRequired = true)]
        public int ReturnId { get; set; }

        [DataMember(Name = "parcel_id", EmitDefaultValue = false, IsRequired = true)]
        public int ParcelId { get; set; }

        [DataMember(Name = "multi_collo_ids", EmitDefaultValue = false, IsRequired = true)]
        public int[] MultiColloIds { get; set; }
    }
}
