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
            DeleteRequest = true;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFzzz";
        }

        public async Task<Integration[]> Get()
        {
            var apiResponse = await Get<Integration[]>();
            return apiResponse.Data;
        }

        public async Task<Integration> Update(Integration integration)
        {
            var apiResponse = await Update<Integration>(JsonHelper.Serialize(integration, DateTimeFormat), integration.Id);
            return apiResponse.Data;
        }

        public async Task<ApiResponse<Integration>> Delete(int integrationId)
        {
            var apiResponse = await Delete<Integration>(integrationId);
            return apiResponse;
        }

        public async Task<Shipment[]> GetShipments(int integrationId, string[] externalOrderIds = null, string[]externalShipmentIds = null, string orderNumber = null, DateTime? startDate = null, DateTime? endDate = null, int? senderAddressId = null, bool? shippingRules = false)
        {
            var apiResponse = await GetShipmentsWithHttpInfo(integrationId, externalOrderIds, externalShipmentIds, orderNumber, startDate, endDate, senderAddressId, shippingRules);
            return apiResponse.Data;
        }

        public async Task<ApiResponse<Shipment[]>> GetShipmentsWithHttpInfo(int integrationId, string[] externalOrderIds = null, string[] externalShipmentIds = null, string orderNumber = null, DateTime? startDate = null, DateTime? endDate = null, int? senderAddressId = null, bool? shippingRules = false)
        {
            var parameters = new Dictionary<string, string>();
            if (externalOrderIds != null && externalOrderIds.Length > 0)
                parameters.Add("external_order_ids", string.Join(",", externalOrderIds));
            if (externalShipmentIds != null && externalShipmentIds.Length > 0)
                parameters.Add("external_shipment_ids", string.Join(",", externalShipmentIds));
            if (!string.IsNullOrWhiteSpace(orderNumber))
                parameters.Add("order_number", orderNumber);
            if (startDate.HasValue)
                parameters.Add("start_date", startDate.Value.ToString("yyyy-MM-dd"));
            if (endDate.HasValue)
                parameters.Add("end_date", endDate.Value.ToString("yyyy-MM-dd"));
            if (senderAddressId.HasValue)
                parameters.Add("sender_address", senderAddressId.Value.ToString());
            if (shippingRules.HasValue)
                parameters.Add("shipping_rules", shippingRules.Value.ToString().ToLowerInvariant());

            string url = $"{HostUrl}integrations/{integrationId}/shipments";
            var apiResponse = await Client.Get<Shipment[]>(url, Authorization, parameters, "results", "yyyy-MM-ddTHH:mm:ss.FFFFFFZ");
            return apiResponse;
        }

        public async Task<Shipment[]> InsertShipments(int integrationId, Shipment[] shipments)
        {
            string url = $"{HostUrl}integrations/{integrationId}/shipments";
            string data = JsonHelper.Serialize(shipments, DateTimeFormat);
            var apiResponse = await Client.Create<Shipment[]>(url, Authorization, data, "", DateTimeFormat);
            return apiResponse.Data;
        }

        public async Task<string> DeleteShipment(int integrationId, Shipment shipment)
        {
            string url = $"{HostUrl}integrations/{integrationId}/shipments/delete";
            string data = JsonHelper.Serialize(shipment, DateTimeFormat);
            var apiResponse = await Client.Create<string>(url, Authorization, data, "", DateTimeFormat);
            return apiResponse.Data;
        }
    }
}
