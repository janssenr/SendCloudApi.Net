﻿using SendCloudApi.Net.Exceptions;
using SendCloudApi.Net.Extensions;
using SendCloudApi.Net.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SendCloudApi.Net
{
    public abstract class SendCloudApiBase
    {
        protected readonly string _apiKey;
        protected readonly string _apiSecret;
        protected readonly string _partnerUuid;
        protected readonly bool _verbose = false;

        public SendCloudApiBase(string apiKey, string apiSecret, string partnerUuid = null, bool verbose = false)
        {
            if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(apiSecret))
            {
                throw new SendCloudException("You must have an API key and an API secret key");
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _apiKey = apiKey;
            _apiSecret = apiSecret;
            _partnerUuid = partnerUuid;
            _verbose = verbose;
        }

        internal string GetApiKey()
        {
            return _apiKey;
        }

        internal string GetApiSecret()
        {
            return _apiSecret;
        }

        internal string GetBasicAuth()
        {
            return $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(_apiKey + ":" + _apiSecret))}";
        }

        internal string GetAccessToken()
        {
            return $"AccessToken {_apiKey}";
        }

        internal bool GetVerbose()
        {
            return _verbose;
        }

        internal async Task<ApiResponse<T>> Create<T>(string url, string authorization, string data, string returnObject, string dateTimeFormat, bool verbose)
        {
            return await SendRequest<T>(url, authorization, "POST", null, data, returnObject, dateTimeFormat, verbose);
        }

        internal async Task<ApiResponse<T>> Get<T>(string url, string authorization, Dictionary<string, string> parameters, string returnObject, string dateTimeFormat, bool verbose)
        {
            return await SendRequest<T>(url, authorization, "GET", parameters, null, returnObject, dateTimeFormat, verbose);
        }

        internal async Task<ApiResponse<T>> Update<T>(string url, string authorization, string data, string returnObject, string dateTimeFormat, bool verbose)
        {
            return await SendRequest<T>(url, authorization, "PUT", null, data, returnObject, dateTimeFormat, verbose);
        }

        internal async Task<ApiResponse<T>> Delete<T>(string url, string authorization, bool verbose)
        {
            return await SendRequest<T>(url, authorization, "DELETE", null, null, null, null, verbose);
        }

        internal async Task<ApiResponse<T>> Patch<T>(string url, string authorization, string data, string returnObject, string dateTimeFormat, bool verbose)
        {
            return await SendRequest<T>(url, authorization, "PATCH", null, data, returnObject, dateTimeFormat, verbose);
        }

        internal Uri GetUrl(string url, Dictionary<string, string> parameters = null)
        {
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
                    url += "?" + queryParameters;
                }
            }
            return new Uri(url);
        }

        private async Task<ApiResponse<T>> SendRequest<T>(string url, string authorization, string method, Dictionary<string, string> parameters, string data, string returnObject, string dateTimeFormat, bool verbose)
        {
            var httpClient = new HttpClient();
            if (!string.IsNullOrWhiteSpace(authorization))
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization);
            }
            if (!string.IsNullOrWhiteSpace(_partnerUuid))
            {
                httpClient.DefaultRequestHeaders.Add("Sendcloud-Partner-Id", _partnerUuid);
            }

            if (verbose)
            {
                if (parameters == null) parameters = new Dictionary<string, string>();
                parameters.Add("errors", "verbose-carrier");
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
                case "DELETE":
                    {
                        response = await httpClient.DeleteAsync(requestUri).ConfigureAwait(false);
                    }
                    break;
                case "PATCH":
                    {
                        response = await httpClient.PatchAsync(requestUri).ConfigureAwait(false);
                    }
                    break;
            }
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (!string.IsNullOrEmpty(jsonResult))
                {
                    if (!string.IsNullOrWhiteSpace(returnObject))
                    {
                        Dictionary<string, T> result = JsonHelper.DeserializeAsDictionary<T>(jsonResult, dateTimeFormat);
                        return new ApiResponse<T>(response.StatusCode, result[returnObject], jsonResult);
                    }
                    return new ApiResponse<T>(response.StatusCode, JsonHelper.Deserialize<T>(jsonResult, dateTimeFormat), jsonResult);
                }
                return new ApiResponse<T>(response.StatusCode, default(T));
            }
            await HandleResponseError(response);
            return new ApiResponse<T>(response.StatusCode, default(T));
        }

        private async Task HandleResponseError(HttpResponseMessage response)
        {
            string message;
            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    message = "Page not found";
                    break;
                case HttpStatusCode.InternalServerError:
                    message = "Internal server error";
                    break;
                default:
                    var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    message = GetErrorMessage(responseBody);
                    break;
            }
            throw new SendCloudException(message);
        }

        protected abstract string GetErrorMessage(string responseBody);

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
