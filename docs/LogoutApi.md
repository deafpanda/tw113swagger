# IO.Swagger.Api.LogoutApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Logout**](LogoutApi.md#logout) | **GET** /logout | Logout of aï¿½session (since 1.13)


<a name="logout"></a>
# **Logout**
> void Logout ()

Logout of aï¿½session (since 1.13)

Invalidates the current session, allowing clients to cleanup.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            var apiInstance = new LogoutApi();

            try
            {
                // Logout of aï¿½session (since 1.13)
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogoutApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

