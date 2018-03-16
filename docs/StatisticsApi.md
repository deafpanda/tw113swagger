# IO.Swagger.Api.StatisticsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatistics**](StatisticsApi.md#getstatistics) | **GET** /statistics | Get process statistics (since 1.6)


<a name="getstatistics"></a>
# **GetStatistics**
> Statistic GetStatistics (string namePattern = null)

Get process statistics (since 1.6)

Returns a list of all managed beans and their attributes, or those that match the JMX name pattern criteria. The default pattern only includes the Measure type mbeans.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatisticsExample
    {
        public void main()
        {
            var apiInstance = new StatisticsApi();
            var namePattern = namePattern_example;  // string | A standard JMX MBean name pattern. (optional) 

            try
            {
                // Get process statistics (since 1.6)
                Statistic result = apiInstance.GetStatistics(namePattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **namePattern** | **string**| A standard JMX MBean name pattern. | [optional] 

### Return type

[**Statistic**](Statistic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

