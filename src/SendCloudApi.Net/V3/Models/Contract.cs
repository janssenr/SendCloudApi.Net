using System.Runtime.Serialization;

namespace SendCloudApi.Net.V3.Models
{
	[DataContract]
	public class Contract
	{
		/// <summary>
		/// Unique identifier of the contract.
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
		public int Id { get; set; }

		/// <summary>
		/// Client ID of a contract.
		/// </summary>
		[DataMember(Name = "client_id", EmitDefaultValue = false, IsRequired = true)]
		public string ClientId { get; set; }

		/// <summary>
		/// Carrier of this contract.
		/// </summary>
		[DataMember(Name = "carrier_code", EmitDefaultValue = false, IsRequired = true)]
		public string CarrierCode { get; set; }

		/// <summary>
		/// A custom name set by the user used to identify this contract throughout the platform.
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
		public string Name { get; set; }
	}
}
