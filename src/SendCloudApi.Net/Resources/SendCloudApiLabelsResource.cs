using System.Threading.Tasks;
using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.Models;
using SendCloudApi.Net.Wrappers;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiLabelsResource : SendCloudApiAbstractResource
    {
        public SendCloudApiLabelsResource(SendCloudApi client) : base(client)
        {
            Resource = "labels";
            ListResource = "label";
            SingleResource = "label";
            CreateResource = "label";
            CreateRequest = true;
        }

        public async Task<Label> BulkCreate(int[] parcelIds)
        {
            var label = new Label { ParcelIds = parcelIds };
            var wrapper = new DataWrapper { Label = label };
            return await Client.Create<Label>(Resource, Authorization, JsonHelper.Serialize(wrapper, DateTimeFormat), ListResource, DateTimeFormat);
        }

        public async Task<Label> Get(int parcelId)
        {
            return await Get<Label>(parcelId);
        }

        //public async Task<string> Download(string url)
        //{
        //    return await Download<string>(url);
        //}

        public async Task<byte[]> Download(string url)
        {
            return await Download<byte[]>(url);
        }

        //public async Task<Stream> Download(string url)
        //{
        //    return await Download<Stream>(url);
        //}
    }
}
