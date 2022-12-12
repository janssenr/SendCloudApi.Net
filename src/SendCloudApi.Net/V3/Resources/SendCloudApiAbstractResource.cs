using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Resources
{
    public abstract class SendCloudApiAbstractResource
    {
        protected readonly SendCloudApi Client;
        protected string HostUrl = "https://panel.sendcloud.sc/api/v3/";
        protected string Authorization;
        protected bool Verbose;
        protected bool CreateRequest = true;
        protected bool GetRequest = true;
        protected bool UpdateRequest = true;
        protected bool DeleteRequest = false;
        protected string SingleResource = string.Empty;
        protected string ListResource = string.Empty;
        protected string CreateResource = string.Empty;
        protected string UpdateResource = string.Empty;
        protected string Resource = string.Empty;
        protected string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        protected SendCloudApiAbstractResource(SendCloudApi client)
        {
            Client = client;
            Authorization = client.GetBasicAuth();
            Verbose = client.GetVerbose();
        }

        protected async Task<ApiResponse<T>> Create<T>(string data)
        {
            if (CreateRequest)
            {
                return await Client.Create<T>($"{HostUrl}{CreateResource}", Authorization, data, "", DateTimeFormat, Verbose);
            }
            return new ApiResponse<T>(System.Net.HttpStatusCode.MethodNotAllowed, default(T));
        }

        protected async Task<ApiResponse<T>> Get<T>(int? objectId = null, Dictionary<string, string> parameters = null)
        {
            if (GetRequest)
            {
                if (objectId.HasValue)
                {
                    return await Client.Get<T>($"{HostUrl}{Resource}/{objectId.Value}", Authorization, parameters, SingleResource, DateTimeFormat, Verbose);
                }
                return await Client.Get<T>($"{HostUrl}{Resource}", Authorization, parameters, ListResource, DateTimeFormat, Verbose);
            }
            return new ApiResponse<T>(System.Net.HttpStatusCode.MethodNotAllowed, default(T));
        }

        protected async Task<ApiResponse<T>> Update<T>(string data, int? objectId = null)
        {
            if (UpdateRequest)
            {
                if (objectId.HasValue)
                {
                    return await Client.Update<T>($"{HostUrl}{UpdateResource}/{objectId.Value}", Authorization, data, SingleResource, DateTimeFormat, Verbose);
                }
                return await Client.Update<T>($"{HostUrl}{UpdateResource}", Authorization, data, SingleResource, DateTimeFormat, Verbose);
            }
            return new ApiResponse<T>(System.Net.HttpStatusCode.MethodNotAllowed, default(T));
        }

        protected async Task<ApiResponse<T>> Delete<T>(int objectId)
        {
            if (DeleteRequest)
            {
                return await Client.Delete<T>($"{HostUrl}{Resource}/{objectId}", Authorization, Verbose);
            }
            return new ApiResponse<T>(System.Net.HttpStatusCode.MethodNotAllowed, default(T));
        }


        //protected async Task<string> Download<T>(string url)
        //{
        //    return await Client.Download(url);
        //}

        protected async Task<byte[]> Download<T>(string url)
        {
            return await Client.Download(url);
        }

        //protected async Task<Stream> Download<T>(string url)
        //{
        //    return await Client.Download(url);
        //}
    }
}
