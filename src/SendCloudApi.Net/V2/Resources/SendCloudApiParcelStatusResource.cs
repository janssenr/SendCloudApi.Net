using System.Threading.Tasks;
using SendCloudApi.Net.V2.Models;

namespace SendCloudApi.Net.V2.Resources
{
    public class SendCloudApiParcelStatusResource : SendCloudApiAbstractResource
    {
        public SendCloudApiParcelStatusResource(SendCloudApi client) : base(client)
        {
            Resource = "parcels/statuses";
            ListResource = "";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<Status[]> Get()
        {
            var apiResponse = await Get<Status[]>();
            return apiResponse.Data;
        }
    }
}
