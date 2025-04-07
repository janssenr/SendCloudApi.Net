using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace SendCloudApi.Net.V2.Models
{
    [DataContract]
    public class CustomsInformation
    {
        [DataMember(Name = "customs_invoice_nr", EmitDefaultValue = false, IsRequired = true)]
        public string CustomsInvoiceNr { get; set; }

        [DataMember(Name = "customs_shipment_type", EmitDefaultValue = false, IsRequired = true)]
        public CustomsShipmentType? CustomsShipmentType { get; set; }

        [DataMember(Name = "export_type", EmitDefaultValue = false, IsRequired = false)]
        public string ExportType { get; set; }

        [IgnoreDataMember]
        public DateTime InvoiceDate { get; set; }

        [DataMember(Name = "invoice_date", EmitDefaultValue = false, IsRequired = false)]
        public string InvoiceDateFormatted
        {
            get => InvoiceDate.ToString("yyyy-MM-dd");
            set => InvoiceDate = DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        [DataMember(Name = "discount_granted", EmitDefaultValue = false, IsRequired = false)]
        public string DiscountGranted { get; set; }

        [DataMember(Name = "freight_costs", EmitDefaultValue = false, IsRequired = false)]
        public string FreightCosts { get; set; }

        [DataMember(Name = "insurance_costs", EmitDefaultValue = false, IsRequired = false)]
        public string InsuranceCosts { get; set; }

        [DataMember(Name = "other_costs", EmitDefaultValue = false, IsRequired = false)]
        public string OtherCosts { get; set; }

        [DataMember(Name = "general_notes", EmitDefaultValue = false, IsRequired = false)]
        public string GeneralNotes { get; set; }

        [DataMember(Name = "additional_declaration_statements", EmitDefaultValue = false, IsRequired = false)]
        public string[] AdditionalDeclarationStatements { get; set; }

        [DataMember(Name = "importer_of_record", EmitDefaultValue = false, IsRequired = false)]
        public ImporterOfRecord ImporterOfRecord { get; set; }

        [DataMember(Name = "tax_numbers", EmitDefaultValue = false, IsRequired = false)]
        public TaxNumbers TaxNumbers { get; set; }

        [DataMember(Name = "return_data", EmitDefaultValue = false, IsRequired = false)]
        public ReturnData ReturnData { get; set; }
    }
}
