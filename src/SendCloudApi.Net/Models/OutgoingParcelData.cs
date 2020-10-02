using System.Runtime.Serialization;

namespace SendCloudApi.Net.Models
{
    [DataContract]
    public class OutgoingParcelData
    {
        [DataMember(Name = "parcel", EmitDefaultValue = false, IsRequired = false)]
        public Parcel<Country> Parcel { get; set; }

        [DataMember(Name = "products", EmitDefaultValue = false, IsRequired = false)]
        public OutgoingParcelProduct[] Products { get; set; }

        [DataMember(Name = "carriers", EmitDefaultValue = false, IsRequired = false)]
        public Carrier[] Carriers { get; set; }

        [DataMember(Name = "service_point", EmitDefaultValue = false, IsRequired = false)]
        public ServicePoint ServicePoint { get; set; }

        [DataMember(Name = "shop_distances", EmitDefaultValue = false, IsRequired = false)]
        public ShopDistance[] ShopDistances { get; set; }

        [DataMember(Name = "national_carrier_contact", EmitDefaultValue = false, IsRequired = false)]
        public string NationalCarrierContact { get; set; }

    }
}
