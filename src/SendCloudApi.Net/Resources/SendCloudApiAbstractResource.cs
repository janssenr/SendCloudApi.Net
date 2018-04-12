using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public abstract class SendCloudApiAbstractResource
    {
        protected readonly SendCloudApi Client;
        protected bool CreateRequest = true;
        protected bool GetRequest = true;
        protected bool UpdateRequest = true;
        protected string SingleResource = string.Empty;
        protected string ListResource = string.Empty;
        protected string CreateResource = string.Empty;
        protected string UpdateResource = string.Empty;
        protected string Resource = string.Empty;
        protected string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        protected SendCloudApiAbstractResource(SendCloudApi client)
        {
            Client = client;
        }

        protected async Task<T> Create<T>(string data)
        {
            if (CreateRequest)
            {
                return await Client.Create<T>(CreateResource, data, SingleResource, DateTimeFormat);
            }
            return default(T);
        }

        protected async Task<T> Get<T>(int? objectId = null, Dictionary<string, string> parameters = null)
        {
            if (GetRequest)
            {
                if (objectId.HasValue)
                {
                    return await Client.Get<T>($"{Resource}/{objectId.Value}", parameters, SingleResource, DateTimeFormat);
                }
                return await Client.Get<T>(Resource, parameters, ListResource, DateTimeFormat);
            }
            return default(T);
        }

        protected async Task<T> Update<T>(string data)
        {
            if (UpdateRequest)
            {
                return await Client.Update<T>(UpdateResource, data, SingleResource, DateTimeFormat);
            }
            return default(T);
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
