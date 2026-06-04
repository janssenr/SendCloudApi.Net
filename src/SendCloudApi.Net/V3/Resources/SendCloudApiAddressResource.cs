using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V3.Models;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Resources
{
	public class SendCloudApiAddressResource : SendCloudApiAbstractResource
	{
		public SendCloudApiAddressResource(SendCloudApi client) : base(client)
		{
			Resource = "addresses";
			CreateResource = "";
			ListResource = "";
			SingleResource = "";
			CreateRequest = false;
			UpdateRequest = false;
			DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.ffffffzzz";
		}

		public async Task<AddressValidationResponse> Validate(AddressValidationRequest request)
		{
			var apiResponse = await Client.Create<AddressValidationResponse>($"{HostUrl}{Resource}/validate", Authorization, JsonHelper.Serialize(request, DateTimeFormat), string.Empty, DateTimeFormat, Verbose);
			return apiResponse.Data;
		}
	}
}
