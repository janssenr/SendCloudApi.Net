using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V3.Models;
using SendCloudApi.Net.V3.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Resources
{
	public class SendCloudApiShippingOptionResource : SendCloudApiAbstractResource
	{
		public SendCloudApiShippingOptionResource(SendCloudApi client) : base(client)
		{
			Resource = "shipping-options";
			CreateResource = "";
			ListResource = "";
			SingleResource = "";
			CreateRequest = false;
			UpdateRequest = false;
			DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.ffffffzzz";
		}

		public async Task<ShippingOption[]> Get(ShippingOptionRequest request)
		{
			var apiResponse = await Client.Create<DataWrapper<ShippingOption>>($"{HostUrl}{Resource}", Authorization, JsonHelper.Serialize(request, DateTimeFormat), string.Empty, DateTimeFormat, Verbose);
			return apiResponse.Data.Data;
		}
	}
}
