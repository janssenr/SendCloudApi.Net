using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class TaxNumbers
    {
        [DataMember(Name = "sender", EmitDefaultValue = false, IsRequired = false)]
        public TaxNumber[] Sender { get; set; }

        [DataMember(Name = "receiver", EmitDefaultValue = false, IsRequired = false)]
        public TaxNumber[] Receiver { get; set; }

        [DataMember(Name = "importer_of_record", EmitDefaultValue = false, IsRequired = false)]
        public TaxNumber[] ImporterOfRecord { get; set; }
    }
}
