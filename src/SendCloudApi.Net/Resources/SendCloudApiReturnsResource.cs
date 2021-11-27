using SendCloudApi.Net.Models;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiReturnsResource: SendCloudApiAbstractResource
    {
        public SendCloudApiReturnsResource(SendCloudApi client) : base(client)
        {
            Resource = "returns";
            ListResource = "returns";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.ffffffzzz";
        }

        public async Task<Return[]> Get()
        {
            var apiResponse = await Get<Return[]>();
            return apiResponse.Data;
        }

        public async Task<Return> Get(int returnId)
        {
            var apiResponse = await Get<Return>(returnId);
            return apiResponse.Data;
        }
    }
}
