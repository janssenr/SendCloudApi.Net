using System.Threading.Tasks;
using SendCloudApi.Net.Models;

namespace SendCloudApi.Net.Resources
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

        public async Task<ParcelStatus[]> Get()
        {
            return await Get<ParcelStatus[]>();
        }
    }
}
