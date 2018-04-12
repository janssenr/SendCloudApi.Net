using System.Threading.Tasks;
using SendCloudApi.Net.Models;

namespace SendCloudApi.Net.Resources
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
            return await Get<Invoice<string>[]>();
        }

        public async Task<Invoice<InvoiceItem[]>> Get(int invoiceId)
        {
            return await Get<Invoice<InvoiceItem[]>>(invoiceId);
        }
    }
}
