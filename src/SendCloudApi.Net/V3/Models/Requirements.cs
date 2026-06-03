using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class Requirements
	{
		/// <summary>
		/// Indicates which fields are required to ship a parcel with this option.
		/// </summary>
		[DataMember(Name = "fields", EmitDefaultValue = false, IsRequired = false)]
		public Field[] Fields { get; set; }

		/// <summary>
		/// When true, custom documents must be provided for this shipment as it crosses economic zones (i.e. EU to non-EU), whether by attaching the necessary documents to the parcel or using Paperless Trade.
		/// </summary>
		[DataMember(Name = "export_documents", EmitDefaultValue = false, IsRequired = false)]
		public bool ExportDocuments { get; set; }

		/// <summary>
		/// Indicates if service point id must be specified when announcing a parcel.
		/// </summary>
		[DataMember(Name = "is_service_point_required", EmitDefaultValue = false, IsRequired = false)]
		public bool IsServicePointRequired { get; set; }
	}
}
