using SendCloudApi.Net.Models;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiBrandsResource: SendCloudApiAbstractResource
    {
        public SendCloudApiBrandsResource(SendCloudApi client) : base(client)
        {
            Resource = "brands";
            ListResource = "brands";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<Brand[]> Get()
        {
            return await Get<Brand[]>();
        }

        public async Task<Brand> Get(int brandId)
        {
            return await Get<Brand>(brandId);
        }
    }
}
