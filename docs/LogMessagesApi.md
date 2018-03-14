# IO.Swagger.Api.LogMessagesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLogMessage**](LogMessagesApi.md#createlogmessage) | **POST** /logMessages | Create a log message (since 1.9)
[**GetLogMessages**](LogMessagesApi.md#getlogmessages) | **GET** /logMessages | Get messages in the TE log manager (since 1.6)


<a name="createlogmessage"></a>
# **CreateLogMessage**
> LogMessage CreateLogMessage (LogMessage body = null)

Create a log message (since 1.9)

Returns a newly created log message of one of the following types: System, Tacacs, Radius, SOAP Client. System messages are general, and can optionally be associated to one or more TE objects. Tacacs and Radius messages require a single Node object in the objects field. Log message levels may be INFO or ERROR.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLogMessageExample
    {
        public void main()
        {
            var apiInstance = new LogMessagesApi();
            var body = new LogMessage(); // LogMessage | A log entry that stores information about an event (optional) 

            try
            {
                // Create a log message (since 1.9)
                LogMessage result = apiInstance.CreateLogMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogMessagesApi.CreateLogMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogMessage**](LogMessage.md)| A log entry that stores information about an event | [optional] 

### Return type

[**LogMessage**](LogMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlogmessages"></a>
# **GetLogMessages**
> List<LogMessage> GetLogMessages (string pageLimit = null, string pageStart = null, List<string> id = null, List<string> level = null, List<string> time = null, string timeRange = null, List<string> type = null, List<string> message = null, List<string> subMessage = null, List<string> username = null, List<string> _object = null)

Get messages in the TE log manager (since 1.6)

List all log manager messages or those that match the filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLogMessagesExample
    {
        public void main()
        {
            var apiInstance = new LogMessagesApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support. (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support. (optional) 
            var id = new List<string>(); // List<string> | IDs of log messages to fetch. (optional) 
            var level = new List<string>(); // List<string> | Level of log messages to fetch. May be one of ERROR, INFO, UNKNOWN (optional) 
            var time = new List<string>(); // List<string> | Times of creation of log messages to fetch. (optional) 
            var timeRange = timeRange_example;  // string | Creation time range of log messages to fetch. (optional) 
            var type = new List<string>(); // List<string> | Types of log messages to fetch. (optional) 
            var message = new List<string>(); // List<string> | Messages of log messages to fetch. (optional) 
            var subMessage = new List<string>(); // List<string> | Substring matching for messages of log messages to fetch. (optional) 
            var username = new List<string>(); // List<string> | Username of log messages to fetch. (optional) 
            var _object = new List<string>(); // List<string> | Associated object readable keys of log messages to fetch. (optional) 

            try
            {
                // Get messages in the TE log manager (since 1.6)
                List&lt;LogMessage&gt; result = apiInstance.GetLogMessages(pageLimit, pageStart, id, level, time, timeRange, type, message, subMessage, username, _object);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogMessagesApi.GetLogMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageLimit** | **string**| Page limit for paging support. | [optional] 
 **pageStart** | **string**| Page start for paging support. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of log messages to fetch. | [optional] 
 **level** | [**List&lt;string&gt;**](string.md)| Level of log messages to fetch. May be one of ERROR, INFO, UNKNOWN | [optional] 
 **time** | [**List&lt;string&gt;**](string.md)| Times of creation of log messages to fetch. | [optional] 
 **timeRange** | **string**| Creation time range of log messages to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Types of log messages to fetch. | [optional] 
 **message** | [**List&lt;string&gt;**](string.md)| Messages of log messages to fetch. | [optional] 
 **subMessage** | [**List&lt;string&gt;**](string.md)| Substring matching for messages of log messages to fetch. | [optional] 
 **username** | [**List&lt;string&gt;**](string.md)| Username of log messages to fetch. | [optional] 
 **_object** | [**List&lt;string&gt;**](string.md)| Associated object readable keys of log messages to fetch. | [optional] 

### Return type

[**List<LogMessage>**](LogMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

