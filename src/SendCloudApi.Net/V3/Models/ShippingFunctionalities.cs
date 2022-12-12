using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
    [DataContract]
    public class ShippingFunctionalities
    {
        [DataMember(Name = "age_check", EmitDefaultValue = false, IsRequired = false)]
        public int? AgeCheck { get; set; }

        [DataMember(Name = "b2b", EmitDefaultValue = false, IsRequired = false)]
        public bool B2B { get; set; }

        [DataMember(Name = "b2c", EmitDefaultValue = false, IsRequired = false)]
        public bool B2C { get; set; }

        [DataMember(Name = "boxable", EmitDefaultValue = false, IsRequired = false)]
        public bool Boxable { get; set; }

        [DataMember(Name = "bulky_goods", EmitDefaultValue = false, IsRequired = false)]
        public bool BulkyGoods { get; set; }

        [DataMember(Name = "carrier_billing_type", EmitDefaultValue = false, IsRequired = false)]
        public string CarrierBillingType { get; set; }

        [DataMember(Name = "cash_on_delivery", EmitDefaultValue = false, IsRequired = false)]
        public int? CashOnDelivery { get; set; }

        [DataMember(Name = "dangerous_goods", EmitDefaultValue = false, IsRequired = false)]
        public bool DangerousGoods { get; set; }

        [DataMember(Name = "delivery_attempts", EmitDefaultValue = false, IsRequired = false)]
        public int? DeliveryAttempts { get; set; }

        [DataMember(Name = "delivery_before", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryBefore { get; set; }

        [DataMember(Name = "delivery_deadline", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryDeadline { get; set; }

        [DataMember(Name = "direct_contract_only", EmitDefaultValue = false, IsRequired = false)]
        public bool DirectContractOnly { get; set; }

        [DataMember(Name = "eco_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool EcoDelivery { get; set; }

        [DataMember(Name = "first_mile", EmitDefaultValue = false, IsRequired = false)]
        public string FirstMile { get; set; }

        [DataMember(Name = "flex_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool FlexDelivery { get; set; }

        [DataMember(Name = "form_factor", EmitDefaultValue = false, IsRequired = false)]
        public string FormFactor { get; set; }

        [DataMember(Name = "fragile_goods", EmitDefaultValue = false, IsRequired = false)]
        public bool FragileGoods { get; set; }

        [DataMember(Name = "fresh_goods", EmitDefaultValue = false, IsRequired = false)]
        public bool FreshGoods { get; set; }

        [DataMember(Name = "harmonized_label", EmitDefaultValue = false, IsRequired = false)]
        public bool HarmonizedLabel { get; set; }

        [DataMember(Name = "id_check", EmitDefaultValue = false, IsRequired = false)]
        public bool IDCheck { get; set; }

        [DataMember(Name = "incoterm", EmitDefaultValue = false, IsRequired = false)]
        public string Incoterm { get; set; }

        [DataMember(Name = "insurance", EmitDefaultValue = false, IsRequired = false)]
        public int? Insurance { get; set; }

        [DataMember(Name = "last_mile", EmitDefaultValue = false, IsRequired = false)]
        public string LastMile { get; set; }

        [DataMember(Name = "manually", EmitDefaultValue = false, IsRequired = false)]
        public bool Manually { get; set; }

        [DataMember(Name = "multicollo", EmitDefaultValue = false, IsRequired = false)]
        public bool Multicollo { get; set; }

        [DataMember(Name = "neighbor_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool NeighborDelivery { get; set; }

        [DataMember(Name = "non_conveyable", EmitDefaultValue = false, IsRequired = false)]
        public bool NonConveyable { get; set; }

        [DataMember(Name = "personalized_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool PersonalizedDelivery { get; set; }

        [DataMember(Name = "premium", EmitDefaultValue = false, IsRequired = false)]
        public bool Premium { get; set; }

        [DataMember(Name = "priority", EmitDefaultValue = false, IsRequired = false)]
        public string Priority { get; set; }

        [DataMember(Name = "registered_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool RegisteredDelivery { get; set; }

        [DataMember(Name = "returns", EmitDefaultValue = false, IsRequired = false)]
        public bool Returns { get; set; }

        [DataMember(Name = "segment", EmitDefaultValue = false, IsRequired = false)]
        public string Segment { get; set; }

        [DataMember(Name = "service_area", EmitDefaultValue = false, IsRequired = false)]
        public string ServiceArea { get; set; }

        [DataMember(Name = "signature", EmitDefaultValue = false, IsRequired = false)]
        public bool Signature { get; set; }

        [DataMember(Name = "size", EmitDefaultValue = false, IsRequired = false)]
        public string Size { get; set; }

        [DataMember(Name = "sorted", EmitDefaultValue = false, IsRequired = false)]
        public bool Sorted { get; set; }

        [DataMember(Name = "surcharge", EmitDefaultValue = false, IsRequired = false)]
        public bool Surcharge { get; set; }

        [DataMember(Name = "tracked", EmitDefaultValue = false, IsRequired = false)]
        public bool Tracked { get; set; }

        [DataMember(Name = "tyres", EmitDefaultValue = false, IsRequired = false)]
        public bool Tyres { get; set; }

        [DataMember(Name = "weekend_delivery", EmitDefaultValue = false, IsRequired = false)]
        public string WeekendDelivery { get; set; }

        [DataMember(Name = "ers", EmitDefaultValue = false, IsRequired = false)]
        public bool ERS { get; set; }

        [DataMember(Name = "pick_up", EmitDefaultValue = false, IsRequired = false)]
        public bool PickUp { get; set; }

        [DataMember(Name = "labelless", EmitDefaultValue = false, IsRequired = false)]
        public bool Labelless { get; set; }
    }
}
