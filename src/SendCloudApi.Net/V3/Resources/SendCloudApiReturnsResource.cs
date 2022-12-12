using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V3.Models;
using SendCloudApi.Net.V3.Wrappers;
using System.Threading.Tasks;

namespace SendCloudApi.Net.V3.Resources
{
    public class SendCloudApiReturnsResource: SendCloudApiAbstractResource
    {
        public SendCloudApiReturnsResource(SendCloudApi client) : base(client)
        {
            Resource = "returns";
            CreateResource = "returns";
            ListResource = "";
            SingleResource = "";
            CreateRequest = true;
            UpdateRequest = false;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.ffffffzzz";
        }

        public async Task<ReturnResponse> Create(Return r)
        {
            var apiResponse = await Create<ReturnResponse>(JsonHelper.Serialize(r, DateTimeFormat));
            return apiResponse.Data;
        }

        public async Task<Return[]> Get()
        {
            var apiResponse = await Get<DataWrapper<Return>>();
            return apiResponse.Data.Data;
        }

        public async Task<Return> Get(int returnId)
        {
            var apiResponse = await Get<Return>(returnId);
            return apiResponse.Data;
        }

        public async Task<ReturnCancel> Cancel(int returnId)
        {
            var apiResponse = await Client.Patch<ReturnCancel>($"{HostUrl}{Resource}/{returnId}/cancel", Authorization, string.Empty, string.Empty, DateTimeFormat, Verbose);
            return apiResponse.Data;
        }

        public async Task<ReturnValidation> Validate(Return r)
        {
            var apiResponse = await Client.Create<ReturnValidation>($"{HostUrl}{Resource}/validate", Authorization, JsonHelper.Serialize(r, DateTimeFormat), string.Empty, DateTimeFormat, Verbose);
            return apiResponse.Data;
        }
    }
}
