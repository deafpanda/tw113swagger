# IO.Swagger.Api.ReportsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteReport**](ReportsApi.md#deletereport) | **DELETE** /reports/{rkReportId} | Delete a report (since 1.11)
[**GetReports**](ReportsApi.md#getreports) | **GET** /reports | List reports (since 1.9)


<a name="deletereport"></a>
# **DeleteReport**
> void DeleteReport (string rkReportId)

Delete a report (since 1.11)

Removes a report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteReportExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var rkReportId = rkReportId_example;  // string | ID of report to delete

            try
            {
                // Delete a report (since 1.11)
                apiInstance.DeleteReport(rkReportId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkReportId** | **string**| ID of report to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreports"></a>
# **GetReports**
> Report GetReports (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null)

List reports (since 1.9)

Returns a list of all reports or those that match the filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportsExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var description = new List<string>(); // List<string> | Description of the report (optional) 
            var id = new List<string>(); // List<string> | Id of the report (optional) 
            var name = new List<string>(); // List<string> | Name of the report (optional) 
            var subDescription = new List<string>(); // List<string> | Support for like search for description parameter. (optional) 
            var type = new List<string>(); // List<string> | Template name for this report (optional) 

            try
            {
                // List reports (since 1.9)
                Report result = apiInstance.GetReports(description, id, name, subDescription, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **description** | [**List&lt;string&gt;**](string.md)| Description of the report | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| Id of the report | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Name of the report | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for like search for description parameter. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Template name for this report | [optional] 

### Return type

[**Report**](Report.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

