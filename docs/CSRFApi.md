# IO.Swagger.Api.CSRFApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCSRFToken**](CSRFApi.md#getcsrftoken) | **GET** /csrf-token | Get CSRF token (since 1.2)


<a name="getcsrftoken"></a>
# **GetCSRFToken**
> Token GetCSRFToken ()

Get CSRF token (since 1.2)

The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application's first request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCSRFTokenExample
    {
        public void main()
        {
            var apiInstance = new CSRFApi();

            try
            {
                // Get CSRF token (since 1.2)
                Token result = apiInstance.GetCSRFToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSRFApi.GetCSRFToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Token**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

