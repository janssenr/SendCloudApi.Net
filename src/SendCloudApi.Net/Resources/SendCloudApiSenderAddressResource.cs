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
            return await Get<SenderAddress[]>();
        }

        public async Task<SenderAddress> Get(int senderAddressId)
        {
            return await Get<SenderAddress>(senderAddressId);
        }
    }
}
