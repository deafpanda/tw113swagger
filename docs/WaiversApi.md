# IO.Swagger.Api.WaiversApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWaiver**](WaiversApi.md#deletewaiver) | **DELETE** /waivers/{rkWaiverId} | Delete a waiver (since 1.11)
[**GetWaiverById**](WaiversApi.md#getwaiverbyid) | **GET** /waivers/{rkWaiverId} | Get waiver details by ID. (since 1.5)
[**GetWaivers**](WaiversApi.md#getwaivers) | **GET** /waivers | Search waivers (since 1.5)


<a name="deletewaiver"></a>
# **DeleteWaiver**
> void DeleteWaiver (string rkWaiverId)

Delete a waiver (since 1.11)

Removes a waiver

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWaiverExample
    {
        public void main()
        {
            var apiInstance = new WaiversApi();
            var rkWaiverId = rkWaiverId_example;  // string | Id of the waiver

            try
            {
                // Delete a waiver (since 1.11)
                apiInstance.DeleteWaiver(rkWaiverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaiversApi.DeleteWaiver: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkWaiverId** | **string**| Id of the waiver | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwaiverbyid"></a>
# **GetWaiverById**
> Waiver GetWaiverById (string rkWaiverId)

Get waiver details by ID. (since 1.5)

Returns the details of an individual waiver.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWaiverByIdExample
    {
        public void main()
        {
            var apiInstance = new WaiversApi();
            var rkWaiverId = rkWaiverId_example;  // string | ID of Waiver to fetch

            try
            {
                // Get waiver details by ID. (since 1.5)
                Waiver result = apiInstance.GetWaiverById(rkWaiverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaiversApi.GetWaiverById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkWaiverId** | **string**| ID of Waiver to fetch | 

### Return type

[**Waiver**](Waiver.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwaivers"></a>
# **GetWaivers**
> Waiver GetWaivers (bool? closed = null, List<string> description = null, List<string> expiration = null, List<string> grantedBy = null, List<string> id = null, List<string> name = null, string pageLimit = null, string pageStart = null, List<string> policyId = null, List<string> policyName = null, List<string> responsible = null, List<string> startTime = null, List<string> subDescription = null)

Search waivers (since 1.5)

Returns a list of all waivers or only those waivers that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWaiversExample
    {
        public void main()
        {
            var apiInstance = new WaiversApi();
            var closed = true;  // bool? | Closed condition of waivers to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of waivers to fetch. (optional) 
            var expiration = new List<string>(); // List<string> | Expiration times of waivers to fetch. (optional) 
            var grantedBy = new List<string>(); // List<string> | Granted by waivers to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of waivers to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of waivers to fetch. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var policyId = new List<string>(); // List<string> | Policy IDs of waivers to fetch. (optional) 
            var policyName = new List<string>(); // List<string> | Policy names of waivers to fetch. (optional) 
            var responsible = new List<string>(); // List<string> | Responsibles of waivers to fetch. (optional) 
            var startTime = new List<string>(); // List<string> | Start times of waivers to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description. (optional) 

            try
            {
                // Search waivers (since 1.5)
                Waiver result = apiInstance.GetWaivers(closed, description, expiration, grantedBy, id, name, pageLimit, pageStart, policyId, policyName, responsible, startTime, subDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaiversApi.GetWaivers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **closed** | **bool?**| Closed condition of waivers to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of waivers to fetch. | [optional] 
 **expiration** | [**List&lt;string&gt;**](string.md)| Expiration times of waivers to fetch. | [optional] 
 **grantedBy** | [**List&lt;string&gt;**](string.md)| Granted by waivers to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of waivers to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of waivers to fetch. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **policyId** | [**List&lt;string&gt;**](string.md)| Policy IDs of waivers to fetch. | [optional] 
 **policyName** | [**List&lt;string&gt;**](string.md)| Policy names of waivers to fetch. | [optional] 
 **responsible** | [**List&lt;string&gt;**](string.md)| Responsibles of waivers to fetch. | [optional] 
 **startTime** | [**List&lt;string&gt;**](string.md)| Start times of waivers to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description. | [optional] 

### Return type

[**Waiver**](Waiver.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

