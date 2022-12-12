using System.Threading.Tasks;
using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V2.Models;
using SendCloudApi.Net.V2.Wrappers;

namespace SendCloudApi.Net.V2.Resources
{
    public class SendCloudApiLabelsResource : SendCloudApiAbstractResource
    {
        public SendCloudApiLabelsResource(SendCloudApi client) : base(client)
        {
            Resource = "labels";
            ListResource = "label";
            SingleResource = "";
            CreateResource = "label";
            CreateRequest = true;
        }

        public async Task<Label> BulkCreate(int[] parcelIds)
        {
            var label = new Label { ParcelIds = parcelIds };
            var wrapper = new DataWrapper { Label = label };
            var apiResponse = await Client.Create<Label>(Resource, Authorization, JsonHelper.Serialize(wrapper, DateTimeFormat), ListResource, DateTimeFormat, Verbose);
            return apiResponse.Data;
        }

        public async Task<Label> Get(int parcelId)
        {
            var apiResponse = await Get<DataWrapper>(parcelId);
            return apiResponse.Data.Label;
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
