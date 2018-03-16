# IO.Swagger.Api.DeletionsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAll**](DeletionsApi.md#getall) | **GET** /deletions | Get a list of critical deleted objects (since 1.8)


<a name="getall"></a>
# **GetAll**
> DeletionRecord GetAll (string deletedTimeRange = null)

Get a list of critical deleted objects (since 1.8)

Returns a deletion record for any policy test group, action group, element, waiver, policy, policy test, job, report, rule, rule group, node, node group, action, task or Task Group that has been deleted. Records are automatically purged if older than 90 days.

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
            var apiInstance = new DeletionsApi();
            var deletedTimeRange = deletedTimeRange_example;  // string | Time range of deletion records to fetch (optional) 

            try
            {
                // Get a list of critical deleted objects (since 1.8)
                DeletionRecord result = apiInstance.GetAll(deletedTimeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeletionsApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deletedTimeRange** | **string**| Time range of deletion records to fetch | [optional] 

### Return type

[**DeletionRecord**](DeletionRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

