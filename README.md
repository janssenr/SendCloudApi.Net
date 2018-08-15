# SendCloudApi.Net

An unofficial client for the SendCloud API. More info about SendCloud on http://sendcloud.nl. Below are some examples on the usage of this client.

Full docs of the SendCloud API can be found on https://docs.sendcloud.sc/api/v2/index.html

## Installation
This project can easily be installed through NuGet.
```
Install-Package SendCloudApi
```

## Set-up connection
Prepare the client for connecting to SendCloud with your API key, API secret and Sendcloud Partner id (optional)
```C#
var client = new SendCloudApi("apikey", "apisecret", "partnerid")
```

## Get all parcels
Returns an array of Parcel objects
```C#
var parcels = await client.Parcels.Get();
```

## Get a single parcel
Returns a Parcel object
```C#
var parcel = await client.Parcels.Get(2342);
```

## Create a new parcel
```C#
var parcel = new CreateParcel
{
	Name = "John Smith",
	CompanyName = "ACME",
	Address = "Wellingtonstreet 25",
	City = "Wellington",
	PostalCode = "3423 DD",
	Country = "NL",
	RequestLabel = true,
    ShippingMethod = 1, // Shipping method, get possibilities from client.ShippingMethods.Get()
	OrderNumber = "ORDER2014-52321",
};
var response = await client.Parcels.Create(parcel);
```

## Exceptions
Actions to the API may cause an Exception to be thrown in case something went wrong
```C#
try
{
	var response = await client.Parcels.Create(parcel);
}
catch (SendCloudException e)
{
	throw new Exception(e.Message);
}
```