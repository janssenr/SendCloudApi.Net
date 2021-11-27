using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.Models;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiBoxResource : SendCloudApiAbstractResource
    {
        public SendCloudApiBoxResource(SendCloudApi client) : base(client)
        {
            Resource = "box";
            CreateResource = "";
            UpdateResource = "";
            ListResource = "";
            SingleResource = "";
        }

        public async Task<Box> Finalize(Box box)
        {
            var apiResponse = await Client.Create<Box>($"{HostUrl}{Resource}/finalize", Authorization, JsonHelper.Serialize(box, DateTimeFormat), string.Empty, DateTimeFormat);
            return apiResponse.Data;
        }
    }
}
