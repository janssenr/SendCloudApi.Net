using System.Threading.Tasks;
using SendCloudApi.Net.Models;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiUsersResource : SendCloudApiAbstractResource
    {
        public SendCloudApiUsersResource(SendCloudApi client) : base(client)
        {
            Resource = "user";
            ListResource = "user";
            SingleResource = "user";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<User> Get()
        {
            var apiResponse = await Get<User>();
            return apiResponse.Data;
        }
    }
}
