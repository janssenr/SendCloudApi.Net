using SendCloudApi.Net.Models;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiBrandsResource : SendCloudApiAbstractResource
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
            var apiResponse = await Get<Brand[]>();
            return apiResponse.Data;
        }

        public async Task<Brand> Get(int brandId)
        {
            var apiResponse = await Get<Brand>(brandId);
            return apiResponse.Data;
        }
    }
}
