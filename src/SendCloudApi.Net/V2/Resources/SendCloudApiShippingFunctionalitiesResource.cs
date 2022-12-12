using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V2.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V2.Resources
{
    public class SendCloudApiShippingFunctionalitiesResource
    {
        private readonly SendCloudApi _client;
        private readonly string _hostUrl = "https://panel.sendcloud.sc/api/v2/";
        private readonly string _dateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public SendCloudApiShippingFunctionalitiesResource(SendCloudApi client)
        {
            _client = client;
        }

        public async Task<Dictionary<string, ShippingFunctionality>> Get()
        {
            string url = $"{_hostUrl}shipping-functionalities/";
            string authorization = _client.GetBasicAuth();

            var httpClient = new HttpClient();
            if (!string.IsNullOrWhiteSpace(authorization))
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization);
            }
            //if (!string.IsNullOrWhiteSpace(_partnerUuid))
            //{
            //    httpClient.DefaultRequestHeaders.Add("Sendcloud-Partner-Id", _partnerUuid);
            //}

            HttpResponseMessage response = await httpClient.GetAsync(url).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                Dictionary<string, ShippingFunctionality> result = JsonHelper.DeserializeAsDictionary<ShippingFunctionality>(jsonResult, _dateTimeFormat);
                return result;
            }
            return new Dictionary<string, ShippingFunctionality>();
        }
    }
}
