# SendCloudApi.Net

This wrapper helps you to easily connect to the SendCloud API when you use Asp.Net as your main programming language.

Feel free to improve the wrapper by sending a pull request.

## Supported API versions
This wrapper is designed for API v2. Which is currently the most recent version of the SendCloud API.

## Example
```
var api = new Net.SendCloudApi("API_KEY", "API_SECRET");

// Get shipping methods of this user
var shippingMethods = api.ShippingMethods.Get();
```

## Documentation
Documentation is available here:
[SendCloud API v2 Documentation](https://docs.sendcloud.sc/api/v2/index.html)

Be aware that you need a SendCloud account before you can use the SendCloud API.
