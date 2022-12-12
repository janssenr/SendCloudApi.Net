using SendCloudApi.Net.V2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V2.Resources
{
    public class SendCloudApiServicePointsResource
    {
        private readonly SendCloudApi _client;
        private readonly string _hostUrl = "https://servicepoints.sendcloud.sc/api/v2/";
        private readonly string _dateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        private readonly bool _verbose = false;

        public SendCloudApiServicePointsResource(SendCloudApi client)
        {
            _client = client;
        }

        public async Task<string[]> GetCarriers()
        {
            string url = $"{_hostUrl}carriers/";
            string authorization = _client.GetBasicAuth();
            var apiResponse = await _client.Get<string[]>(url, authorization, null, "", _dateTimeFormat, _verbose);
            return apiResponse.Data;
        }

        public async Task<ServicePoint[]> GetServicePoints(string country, string[] carriers = null, string neLatitude = null, string neLongitude = null, string swLatitude = null, string swLongitude = null, string latitude = null, string longitude = null, string weight = null)
        {
            var parameters = new Dictionary<string, string>
            {
                { "country", country }
            };
            if (carriers != null && carriers.Length > 0)
                parameters.Add("carrier", string.Join(",", carriers));
            if (!string.IsNullOrWhiteSpace(neLatitude))
                parameters.Add("ne_latitude", neLatitude);
            if (!string.IsNullOrWhiteSpace(neLongitude))
                parameters.Add("ne_longitude", neLongitude);
            if (!string.IsNullOrWhiteSpace(swLatitude))
                parameters.Add("sw_latitude", swLatitude);
            if (!string.IsNullOrWhiteSpace(swLongitude))
                parameters.Add("sw_longitude", swLongitude);
            if (!string.IsNullOrWhiteSpace(latitude))
                parameters.Add("latitude", latitude);
            if (!string.IsNullOrWhiteSpace(longitude))
                parameters.Add("longitude", longitude);
            if (!string.IsNullOrWhiteSpace(weight))
                parameters.Add("weight", weight);
            string url = $"{_hostUrl}service-points/";
            string authorization = _client.GetBasicAuth();
            var apiResponse = await _client.Get<ServicePoint[]>(url, authorization, parameters, "", _dateTimeFormat, _verbose);
            return apiResponse.Data;
        }

        public async Task<bool> IsServicePointAvailable(int servicePointId)
        {
            string url = $"{_hostUrl}service-points/{servicePointId}/check-availability/";
            string authorization = _client.GetBasicAuth();
            var apiResponse = await _client.Get<bool>(url, authorization, null, "", _dateTimeFormat, _verbose);
            return apiResponse.Data;
        }
    }
}
