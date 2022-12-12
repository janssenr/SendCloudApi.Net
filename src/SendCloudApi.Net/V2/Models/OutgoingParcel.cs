using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class OutgoingParcel
    {
        [DataMember(Name = "service_points_token", EmitDefaultValue = false, IsRequired = false)]
        public string ServicePointsToken { get; set; }

        [DataMember(Name = "access_token", EmitDefaultValue = false, IsRequired = false)]
        public string AccessToken { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false, IsRequired = false)]
        public OutgoingParcelData Data { get; set; }
    }
}
