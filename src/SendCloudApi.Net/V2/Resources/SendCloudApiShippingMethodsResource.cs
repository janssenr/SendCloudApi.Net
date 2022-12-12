using System.Collections.Generic;
using System.Threading.Tasks;
using SendCloudApi.Net.V2.Models;

namespace SendCloudApi.Net.V2.Resources
{
    public class SendCloudApiShippingMethodsResource : SendCloudApiAbstractResource
    {
        public SendCloudApiShippingMethodsResource(SendCloudApi client) : base(client)
        {
            Resource = "shipping_methods";
            ListResource = "shipping_methods";
            SingleResource = "shipping_method";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<ShippingMethod[]> Get(string senderAddress = null, int? servicePointId = null, bool? isReturn = false)
        {
            var parameters = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(senderAddress))
                parameters.Add("sender_address", senderAddress);
            if (servicePointId.HasValue)
                parameters.Add("service_point_id", servicePointId.ToString());
            if (isReturn.HasValue)
                parameters.Add("is_return", isReturn.ToString());
            var apiResponse = await Get<ShippingMethod[]>(parameters: parameters);
            return apiResponse.Data;
        }

        public async Task<ShippingMethod> Get(int shippingMethodId)
        {
            var apiResponse = await Get<ShippingMethod>(shippingMethodId);
            return apiResponse.Data;
        }
    }
}
