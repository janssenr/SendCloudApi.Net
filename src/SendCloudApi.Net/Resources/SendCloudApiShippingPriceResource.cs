using SendCloudApi.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiShippingPriceResource : SendCloudApiAbstractResource
    {
        public SendCloudApiShippingPriceResource(SendCloudApi client) : base(client)
        {
            Resource = "shipping-price";
            ListResource = "";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<ShippingPrice[]> Get(int shippingMethodId, string fromCountry, string toCountry, int weight, string weightUnit)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("shipping_method_id", shippingMethodId.ToString());
            parameters.Add("from_country", fromCountry);
            parameters.Add("to_country", toCountry);
            parameters.Add("weight", weight.ToString());
            parameters.Add("weight_unit", weightUnit);
            var apiResponse = await Get<ShippingPrice[]>(parameters: parameters);
            return apiResponse.Data;
        }
    }
}
