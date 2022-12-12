using System.Threading.Tasks;
using SendCloudApi.Net.V2.Models;

namespace SendCloudApi.Net.V2.Resources
{
    public class SendCloudApiInvoicesResource : SendCloudApiAbstractResource
    {
        public SendCloudApiInvoicesResource(SendCloudApi client) : base(client)
        {
            Resource = "user/invoices";
            ListResource = "invoices";
            SingleResource = "invoice";
            CreateRequest = false;
            UpdateRequest = false;
            DateTimeFormat = "dd-MM-yyyy HH:mm:ss";
        }

        public async Task<Invoice<string>[]> Get()
        {
            var apiResponse = await Get<Invoice<string>[]>();
            return apiResponse.Data;
        }

        public async Task<Invoice<InvoiceItem[]>> Get(int invoiceId)
        {
            var apiResponse = await Get<Invoice<InvoiceItem[]>>(invoiceId);
            return apiResponse.Data;
        }
    }
}
