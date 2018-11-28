using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SendCloudApi.Net.Exceptions;
using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.Models;
using SendCloudApi.Net.Resources;

namespace SendCloudApi.Net
{
    public class SendCloudApi
    {
        private const string HostUrl = "https://panel.sendcloud.sc/api/v2/";
        private readonly Uri _apiUrl;
        private readonly string _apiKey;
        private readonly string _apiSecret;
        private readonly string _partnerUuid;
        public readonly SendCloudApiParcelsResource Parcels;
        public readonly SendCloudApiParcelStatusResource ParcelStatuses;
        public readonly SendCloudApiShippingResource ShippingMethods;
        public readonly SendCloudApiUserResource User;
        public readonly SendCloudApiLabelResource Label;
        public readonly SendCloudApiInvoicesResource Invoices;
        public readonly SendCloudApiSenderAddressResource SenderAddresses;

        public SendCloudApi(string apiKey, string apiSecret, string partnerUuid = null)
        {
            if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(apiSecret))
            {
                throw new SendCloudException("You must have an API key and an API secret key");
            }
            _apiKey = apiKey;
            _apiSecret = apiSecret;
            _apiUrl = new Uri(HostUrl);
            _partnerUuid = partnerUuid;
            Parcels = new SendCloudApiParcelsResource(this);
            ParcelStatuses = new SendCloudApiParcelStatusResource(this);
            ShippingMethods = new SendCloudApiShippingResource(this);
            User = new SendCloudApiUserResource(this);
            Label = new SendCloudApiLabelResource(this);
            Invoices = new SendCloudApiInvoicesResource(this);
            SenderAddresses = new SendCloudApiSenderAddressResource(this);
        }

        public string GetApiKey()
        {
            return _apiKey;
        }

        public string GetApiSecret()
        {
            return _apiSecret;
        }

        public async Task<T> Create<T>(string url, string data, string returnObject, string dateTimeFormat)
        {
            return await SendRequest<T>(url, "POST", null, data, returnObject, dateTimeFormat);
        }

        public async Task<T> Get<T>(string url, Dictionary<string, string> parameters, string returnObject, string dateTimeFormat)
        {
            return await SendRequest<T>(url, "GET", parameters, null, returnObject, dateTimeFormat);
        }

        public async Task<T> Update<T>(string url, string data, string returnObject, string dateTimeFormat)
        {
            return await SendRequest<T>(url, "PUT", null, data, returnObject, dateTimeFormat);
        }

        public async Task<ParcelCancel> CancelParcel(string url, string dateTimeFormat)
        {
            return await SendRequest<ParcelCancel>(url, "POST", null, string.Empty, null, dateTimeFormat);
        }

        private Uri GetUrl(string url, Dictionary<string, string> parameters = null)
        {
            var apiUrl = _apiUrl.ToString();
            apiUrl += url;
            if (parameters != null && parameters.Any())
            {
                var queryParameters = string.Join("&",
                    parameters.Select(
                        p =>
                            string.IsNullOrEmpty(p.Value)
                                ? Uri.EscapeDataString(p.Key)
                                : $"{Uri.EscapeDataString(p.Key)}={Uri.EscapeDataString(p.Value)}"));
                if (!string.IsNullOrWhiteSpace(queryParameters))
                {
                    apiUrl += "?" + queryParameters;
                }
            }
            return new Uri(apiUrl);
        }

        private async Task<T> SendRequest<T>(string url, string method, Dictionary<string, string> parameters, string data, string returnObject, string dateTimeFormat)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(_apiKey + ":" + _apiSecret))}");
            if (!string.IsNullOrWhiteSpace(_partnerUuid))
            {
                httpClient.DefaultRequestHeaders.Add("Sendcloud-Partner-Id", _partnerUuid);
            }

            var requestUri = GetUrl(url, parameters);
            HttpResponseMessage response = new HttpResponseMessage();
            switch (method.ToUpper())
            {
                case "GET":
                    {
                        response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);
                    }
                    break;
                case "POST":
                    {
                        var content = new StringContent(data);
                        content.Headers.Clear();
                        content.Headers.Add("Content-Type", "application/json;charset=utf-8");
                        response = await httpClient.PostAsync(requestUri, content).ConfigureAwait(false);
                    }
                    break;
                case "PUT":
                    {
                        var content = new StringContent(data);
                        content.Headers.Clear();
                        content.Headers.Add("Content-Type", "application/json;charset=utf-8");
                        response = await httpClient.PutAsync(requestUri, content).ConfigureAwait(false);
                    }
                    break;
            }
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (!string.IsNullOrWhiteSpace(returnObject))
                {
                    Dictionary<string, T> result = JsonHelper.DeserializeAsDictionary<T>(jsonResult, dateTimeFormat);
                    return result[returnObject];
                }
                return JsonHelper.Deserialize<T>(jsonResult, dateTimeFormat);
            }
            await HandleResponseError(response);
            return default(T);
        }

        private async Task HandleResponseError(HttpResponseMessage response)
        {
            string message;
            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    message = "Page not found";
                    break;
                default:
                    var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var result = JsonHelper.DeserializeAsDictionary<SendCloudError>(responseBody, "yyyy-MM-dd HH:mm:ss");
                    message = result["error"].Message;
                    break;
            }
            throw new SendCloudException(message);
        }

        //public async Task<string> Download(string url)
        //{
        //    var httpClient = new HttpClient();
        //    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(_apiKey + ":" + _apiSecret))}");
        //    if (!string.IsNullOrWhiteSpace(_partnerUuid))
        //    {
        //        httpClient.DefaultRequestHeaders.Add("Sendcloud-Partner-Id", _partnerUuid);
        //    }
        //    httpClient.DefaultRequestHeaders.Accept.Clear();
        //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));

        //    var response = await httpClient.GetAsync(url).ConfigureAwait(false);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        //    }
        //    return null;
        //}

        public async Task<byte[]> Download(string url)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(_apiKey + ":" + _apiSecret))}");
            if (!string.IsNullOrWhiteSpace(_partnerUuid))
            {
                httpClient.DefaultRequestHeaders.Add("Sendcloud-Partner-Id", _partnerUuid);
            }
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));

            var response = await httpClient.GetAsync(url).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }
            return null;
        }

        //public async Task<Stream> Download(string url)
        //{
        //    var httpClient = new HttpClient();
        //    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(_apiKey + ":" + _apiSecret))}");
        //    if (!string.IsNullOrWhiteSpace(_partnerUuid))
        //    {
        //        httpClient.DefaultRequestHeaders.Add("Sendcloud-Partner-Id", _partnerUuid);
        //    }
        //    httpClient.DefaultRequestHeaders.Accept.Clear();
        //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));

        //    var response = await httpClient.GetAsync(url).ConfigureAwait(false);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        //    }
        //    return null;
        //}
    }
}
