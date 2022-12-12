using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V3.Resources;
using SendCloudApi.Net.V3.Wrappers;
using System.Linq;

namespace SendCloudApi.Net.V3
{
    public class SendCloudApi : SendCloudApiBase
    {
        public readonly SendCloudApiReturnsResource Returns;

        public SendCloudApi(string apiKey, string apiSecret, string partnerUuid = null, bool verbose = false) : base(apiKey, apiSecret, partnerUuid, verbose)
        {
            Returns = new SendCloudApiReturnsResource(this);
        }

        protected override string GetErrorMessage(string responseBody)
        {
            var result = JsonHelper.Deserialize<ErrorWrapper>(responseBody, "yyyy-MM-dd HH:mm:ss");
            var message = string.Join("\n", result.Errors.Select(x => string.Format("{0} {1} ({2})", x.Field, x.Message, x.Code)));
            return message;
        }
    }
}
