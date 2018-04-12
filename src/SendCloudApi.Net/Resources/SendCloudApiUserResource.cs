using System.Threading.Tasks;
using SendCloudApi.Net.Models;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiUserResource : SendCloudApiAbstractResource
    {
        public SendCloudApiUserResource(SendCloudApi client) : base(client)
        {
            Resource = "user";
            ListResource = "user";
            SingleResource = "user";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<User> Get()
        {
            return await Get<User>();
        }
    }
}
