using SendCloudApi.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiShippingProducts : SendCloudApiAbstractResource
    {
        public SendCloudApiShippingProducts(SendCloudApi client) : base(client)
        {
            Resource = "shipping-products";
            ListResource = "";
            SingleResource = "shipping-products";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<ShippingProduct[]> Get(string fromCountry, string toCountry, Dictionary<string, string> functionalities = null, string carrier = null, int? weight = null, string weightUnit = null, int? length = null, string lengthUnit = null, int? width = null, string widthUnit = null, int? height = null, string heightUnit = null, int? leadTimeHours = null)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("from_country", fromCountry);
            parameters.Add("to_country", toCountry);
            if (functionalities != null)
            {
                foreach (string key in functionalities.Keys)
                {
                    parameters.Add(key, functionalities[key]);
                }
            }
            if (!string.IsNullOrEmpty(carrier))
                parameters.Add("carrier", carrier);
            if (weight.HasValue)
            {
                parameters.Add("weight", weight.ToString());
                parameters.Add("weight_unit", weightUnit);
            }
            if (length.HasValue)
            {
                parameters.Add("length", length.ToString());
                parameters.Add("length_unit", lengthUnit);
            }
            if (width.HasValue)
            {
                parameters.Add("width", width.ToString());
                parameters.Add("width_unit", widthUnit);
            }
            if (height.HasValue)
            {
                parameters.Add("height", height.ToString());
                parameters.Add("height_unit", heightUnit);
            }
            if (leadTimeHours.HasValue)
                parameters.Add("lead_time_hours", leadTimeHours.ToString());
            return await Get<ShippingProduct[]>(parameters: parameters);
        }
    }
}
