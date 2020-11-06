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
            return await Get<Return[]>();
        }

        public async Task<Return> Get(int returnId)
        {
            return await Get<Return>(returnId);
        }
    }
}
