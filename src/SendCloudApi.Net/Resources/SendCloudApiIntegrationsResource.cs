using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiIntegrationsResource: SendCloudApiAbstractResource
    {
        public SendCloudApiIntegrationsResource(SendCloudApi client) : base(client)
        {
            Resource = "integrations";
            UpdateResource = "integrations";
            ListResource = "";
            SingleResource = "";
            CreateRequest = false;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFzzz";
        }

        public async Task<Integration[]> Get()
        {
            return await Get<Integration[]>();
        }

        public async Task<Integration> Update(Integration integration)
        {
            return await Update<Integration>(JsonHelper.Serialize(integration, DateTimeFormat), integration.Id);
        }

        public async Task<Shipment[]> GetShipments(int integrationId, int[] externalOrderIds = null, int[]externalShipmentIds = null, string orderNumber = null, DateTime? startDate = null, DateTime? endDate = null, int? senderAddressId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (externalOrderIds != null && externalOrderIds.Length > 0)
                parameters.Add("external_order_ids", string.Join(",", externalOrderIds));
            if (externalShipmentIds != null && externalShipmentIds.Length > 0)
                parameters.Add("external_shipment_ids", string.Join(",", externalShipmentIds));
            if (!string.IsNullOrWhiteSpace(orderNumber))
                parameters.Add("order_number", orderNumber);
            if (startDate.HasValue)
                parameters.Add("start_date ", startDate.Value.ToString("yyyy-MM-dd"));
            if (endDate.HasValue)
                parameters.Add("end_date ", endDate.Value.ToString("yyyy-MM-dd"));
            if (senderAddressId.HasValue)
                parameters.Add("sender_address ", senderAddressId.Value.ToString());

            string url = $"{HostUrl}/integrations/{integrationId}/shipments";
            return await Client.Get<Shipment[]>(url, Authorization, parameters, "results", "yyyy-MM-ddTHH:mm:ss.FFFFFFZ");
        }

        public async Task<Shipment[]> InsertShipments(int integrationId, Shipment[] shipments)
        {
            string url = $"{HostUrl}/integrations/{integrationId}/shipments";
            string data = JsonHelper.Serialize(shipments, DateTimeFormat);
            return await Client.Create<Shipment[]>(url, Authorization, data, "", DateTimeFormat);
        }

        public async Task<string> DeleteShipment(int integrationId, Shipment shipment)
        {
            string url = $"{HostUrl}/integrations/{integrationId}/shipments/delete";
            string data = JsonHelper.Serialize(shipment, DateTimeFormat);
            return await Client.Create<string>(url, Authorization, data, "", DateTimeFormat);
        }
    }
}
