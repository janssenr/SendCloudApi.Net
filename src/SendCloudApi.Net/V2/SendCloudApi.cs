using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.V2.Models;
using SendCloudApi.Net.V2.Resources;

namespace SendCloudApi.Net.V2
{
    public class SendCloudApi : SendCloudApiBase
    {
        public readonly SendCloudApiParcelsResource Parcels;
        public readonly SendCloudApiParcelDocumentsResource ParcelDocuments;
        public readonly SendCloudApiParcelStatusResource ParcelStatuses;
        public readonly SendCloudApiReturnsResource Returns;
        public readonly SendCloudApiBrandsResource Brands;
        public readonly SendCloudApiShippingMethodsResource ShippingMethods;
        public readonly SendCloudApiLabelsResource Label;
        public readonly SendCloudApiUsersResource User;
        public readonly SendCloudApiInvoicesResource Invoices;
        public readonly SendCloudApiSenderAddressResource SenderAddresses;
        public readonly SendCloudApiIntegrationsResource Integrations;
        public readonly SendCloudApiReturnPortalResource ReturnPortal;
        public readonly SendCloudApiServicePointsResource ServicePoints;
        public readonly SendCloudApiShippingPriceResource ShippingPrice;
        public readonly SendCloudApiShippingFunctionalitiesResource ShippingFunctionalities;
        public readonly SendCloudApiShippingProductsResource ShippingProducts;
        public readonly SendCloudApiBoxResource Box;

        public SendCloudApi(string apiKey, string apiSecret, string partnerUuid = null, bool verbose = false) : base(apiKey, apiSecret, partnerUuid, verbose)
        {
            Parcels = new SendCloudApiParcelsResource(this);
            ParcelDocuments = new SendCloudApiParcelDocumentsResource(this);
            ParcelStatuses = new SendCloudApiParcelStatusResource(this);
            Returns = new SendCloudApiReturnsResource(this);
            Brands = new SendCloudApiBrandsResource(this);
            ShippingMethods = new SendCloudApiShippingMethodsResource(this);
            Label = new SendCloudApiLabelsResource(this);
            User = new SendCloudApiUsersResource(this);
            Invoices = new SendCloudApiInvoicesResource(this);
            SenderAddresses = new SendCloudApiSenderAddressResource(this);
            Integrations = new SendCloudApiIntegrationsResource(this);
            ReturnPortal = new SendCloudApiReturnPortalResource(this);
            ServicePoints = new SendCloudApiServicePointsResource(this);
            ShippingPrice = new SendCloudApiShippingPriceResource(this);
            ShippingFunctionalities = new SendCloudApiShippingFunctionalitiesResource(this);
            ShippingProducts = new SendCloudApiShippingProductsResource(this);
            Box = new SendCloudApiBoxResource(this);
        }

        protected override string GetErrorMessage(string responseBody)
        {
            var result = JsonHelper.Deserialize<Error>(responseBody, "yyyy-MM-dd HH:mm:ss");
            string message = result.Message;
            if (!string.IsNullOrEmpty(result.ErrorDetails?.Message))
            {
                message = result.ErrorDetails.Message;
            }
            return message;
        }
    }
}
