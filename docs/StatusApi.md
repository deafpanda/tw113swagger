# IO.Swagger.Api.StatusApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatus**](StatusApi.md#getstatus) | **GET** /status | Get TE system status information (since 1.0)


<a name="getstatus"></a>
# **GetStatus**
> TeStatus GetStatus ()

Get TE system status information (since 1.0)

Returns a TE Status details object with the identifying information for the TE system that the API client is connecting to.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatusExample
    {
        public void main()
        {
            var apiInstance = new StatusApi();

            try
            {
                // Get TE system status information (since 1.0)
                TeStatus result = apiInstance.GetStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusApi.GetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeStatus**](TeStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

