using System.Collections.Generic;
using System.Threading.Tasks;
using SendCloudApi.Net.Helpers;
using SendCloudApi.Net.Models;
using SendCloudApi.Net.Wrappers;

namespace SendCloudApi.Net.Resources
{
    public class SendCloudApiParcelsResource : SendCloudApiAbstractResource
    {
        public SendCloudApiParcelsResource(SendCloudApi client) : base(client)
        {
            Resource = "parcels";
            CreateResource = "parcels";
            UpdateResource = "parcels";
            ListResource = "parcels";
            SingleResource = "parcel";
            DateTimeFormat = "dd-MM-yyyy HH:mm:ss";
        }

        public async Task<Parcel<Country>[]> BulkCreate(CreateParcel[] parcels)
        {
            var wrapper = new DataWrapper { Parcels = parcels };
            return await Client.Create<Parcel<Country>[]>(CreateResource, JsonHelper.Serialize(wrapper, DateTimeFormat), ListResource, DateTimeFormat);
        }

        public async Task<Parcel<Country>> Create(CreateParcel parcel)
        {
            var wrapper = new DataWrapper { Parcel = parcel };
            return await Create<Parcel<Country>>(JsonHelper.Serialize(wrapper, DateTimeFormat));
        }

        public async Task<Parcel<Country>[]> Get(int? limit = null, int? offset = null, string orderNumber = null)
        {
            var parameters = new Dictionary<string, string>();
            if (limit.HasValue)
                parameters.Add("limit", limit.Value.ToString());
            if (offset.HasValue)
                parameters.Add("offset", offset.Value.ToString());
            if (!string.IsNullOrWhiteSpace(orderNumber))
                parameters.Add("order_number", orderNumber);
            return await Get<Parcel<Country>[]>(parameters: parameters);
        }

        public async Task<Parcel<Country>> Get(int parcelId)
        {
            return await Get<Parcel<Country>>(parcelId);
        }

        public async Task<Parcel<Country>> Update(CreateParcel parcel)
        {
            var wrapper = new DataWrapper { Parcel = parcel };
            return await Update<Parcel<Country>>(JsonHelper.Serialize(wrapper, DateTimeFormat));
        }

        public async Task<ParcelCancel> Cancel(int parcelId)
        {
            return await Client.CancelParcel($"{Resource}/{parcelId}/cancel", DateTimeFormat);
        }
    }
}
