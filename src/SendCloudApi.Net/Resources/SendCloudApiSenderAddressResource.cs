using System.Threading.Tasks;
using SendCloudApi.Net.Models;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiSenderAddressResource : SendCloudApiAbstractResource
    {
        public SendCloudApiSenderAddressResource(SendCloudApi client) : base(client)
        {
            Resource = "user/addresses/sender";
            ListResource = "sender_addresses";
            SingleResource = "sender_address";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<SenderAddress[]> Get()
        {
            var apiResponse = await Get<SenderAddress[]>();
            return apiResponse.Data;
        }

        public async Task<SenderAddress> Get(int senderAddressId)
        {
            var apiResponse = await Get<SenderAddress>(senderAddressId);
            return apiResponse.Data;
        }
    }
}
