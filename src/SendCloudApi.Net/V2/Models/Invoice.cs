using System;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class Invoice<T>
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "ref", EmitDefaultValue = false, IsRequired = true)]
        public string Reference { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = true)]
        public string Type { get; set; }

        [DataMember(Name = "price_excl", EmitDefaultValue = false, IsRequired = true)]
        public decimal PriceExcl { get; set; }

        [DataMember(Name = "price_incl", EmitDefaultValue = false, IsRequired = true)]
        public decimal PriceIncl { get; set; }

        [DataMember(Name = "date", EmitDefaultValue = false, IsRequired = true)]
        public DateTime Date { get; set; }

        [DataMember(Name = "isPayed", EmitDefaultValue = false, IsRequired = true)]
        public bool IsPayed { get; set; }

        [DataMember(Name = "items", EmitDefaultValue = false, IsRequired = true)]
        public T Items { get; set; }
    }
}
