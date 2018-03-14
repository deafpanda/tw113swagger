# IO.Swagger.Api.HomepagesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAll**](HomepagesApi.md#getall) | **GET** /homepages | Search homepages
[**GetHomepageById**](HomepagesApi.md#gethomepagebyid) | **GET** /homepages/{rkHomepageId} | Get homepage details by ID


<a name="getall"></a>
# **GetAll**
> List<Homepage> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null)

Search homepages

Returns a list of all homepages or only those homepages that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllExample
    {
        public void main()
        {
            var apiInstance = new HomepagesApi();
            var id = new List<string>(); // List<string> | IDs of homepages to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of homepages to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of homepages to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking IDs of homepages to fetch. (optional) 

            try
            {
                // Search homepages
                List&lt;Homepage&gt; result = apiInstance.GetAll(id, name, description, subDescription, trackingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomepagesApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| IDs of homepages to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of homepages to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of homepages to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking IDs of homepages to fetch. | [optional] 

### Return type

[**List<Homepage>**](Homepage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethomepagebyid"></a>
# **GetHomepageById**
> Homepage GetHomepageById (string rkHomepageId)

Get homepage details by ID

Returns summary details for an individual homepage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHomepageByIdExample
    {
        public void main()
        {
            var apiInstance = new HomepagesApi();
            var rkHomepageId = rkHomepageId_example;  // string | rkHomepageId to fetch

            try
            {
                // Get homepage details by ID
                Homepage result = apiInstance.GetHomepageById(rkHomepageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomepagesApi.GetHomepageById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkHomepageId** | **string**| rkHomepageId to fetch | 

### Return type

[**Homepage**](Homepage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

