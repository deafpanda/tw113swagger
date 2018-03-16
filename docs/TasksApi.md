# IO.Swagger.Api.TasksApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExecuteTaskRequest**](TasksApi.md#createexecutetaskrequest) | **POST** /tasks/executeTaskRequests | Post a request to execute a task (since 1.6)
[**CreateTask**](TasksApi.md#createtask) | **POST** /tasks | Post a new task (since 1.6)
[**DeleteTask**](TasksApi.md#deletetask) | **DELETE** /tasks/{rkTaskId} | Delete a task (since 1.6)
[**GetExecutionTaskRequestById**](TasksApi.md#getexecutiontaskrequestbyid) | **GET** /tasks/executeTaskRequests/{requestId} | Get Task Execution Request details by ID (since 1.6)
[**GetNodeStatus**](TasksApi.md#getnodestatus) | **GET** /tasks/{rkTaskId}/nodeStatus | Get the set of node execution status details for a task (since 1.13)
[**GetRunContextNodeRules**](TasksApi.md#getruncontextnoderules) | **GET** /tasks/runContextNodeRules | Get status for node rule pair execution (since 1.13)
[**GetRunContextNodeRulesLatest**](TasksApi.md#getruncontextnoderuleslatest) | **GET** /tasks/runContextNodeRules/latest | Get most recent status by task for node rule pair execution (since 1.13)
[**GetRunContexts**](TasksApi.md#getruncontexts) | **GET** /tasks/runContexts | Get status for rule based task runs (since 1.13)
[**GetRunContextsLatest**](TasksApi.md#getruncontextslatest) | **GET** /tasks/runContexts/latest | Get latest status for rule based task runs (since 1.13)
[**GetTargetableNodes**](TasksApi.md#gettargetablenodes) | **GET** /tasks/{rkTaskId}/targetableNodes | Get nodes targeted by this task (since 1.11)
[**GetTaskById**](TasksApi.md#gettaskbyid) | **GET** /tasks/{rkTaskId} | Get task details by ID (since 1.6)
[**GetTasks**](TasksApi.md#gettasks) | **GET** /tasks | Get a list of tasks (since 1.6)
[**UpdateTask**](TasksApi.md#updatetask) | **PUT** /tasks/{rkTaskId} | Put an update to an existing task (since 1.6)


<a name="createexecutetaskrequest"></a>
# **CreateExecuteTaskRequest**
> ExecuteTaskRequestCommand CreateExecuteTaskRequest (ExecuteTaskRequestCommand body)

Post a request to execute a task (since 1.6)

Request to run a task. The task must be idle or the request will be rejected. Status of the request may be checked with a call to GET /api/v1/tasks/executeTaskRequests/{requestId} using the ID returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateExecuteTaskRequestExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var body = new ExecuteTaskRequestCommand(); // ExecuteTaskRequestCommand | A request for to perform the execution of a Task

            try
            {
                // Post a request to execute a task (since 1.6)
                ExecuteTaskRequestCommand result = apiInstance.CreateExecuteTaskRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateExecuteTaskRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteTaskRequestCommand**](ExecuteTaskRequestCommand.md)| A request for to perform the execution of a Task | 

### Return type

[**ExecuteTaskRequestCommand**](ExecuteTaskRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtask"></a>
# **CreateTask**
> Task CreateTask (Task body)

Post a new task (since 1.6)

Creates a new task in the root task group. 3 task types can be created: Check Rule Task, Baseline Rule Task, and Report Task.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var body = new Task(); // Task | Task to be created in TE

            try
            {
                // Post a new task (since 1.6)
                Task result = apiInstance.CreateTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Task**](Task.md)| Task to be created in TE | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> void DeleteTask (string rkTaskId)

Delete a task (since 1.6)

Remove a task from the TE system. The task must be idle at the time of deletion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var rkTaskId = rkTaskId_example;  // string | ID of Task to delete

            try
            {
                // Delete a task (since 1.6)
                apiInstance.DeleteTask(rkTaskId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskId** | **string**| ID of Task to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutiontaskrequestbyid"></a>
# **GetExecutionTaskRequestById**
> ExecuteTaskRequestCommand GetExecutionTaskRequestById (string requestId)

Get Task Execution Request details by ID (since 1.6)

Returns the details of a single Task Execution Request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionTaskRequestByIdExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var requestId = requestId_example;  // string | ID of Task Execution Request to get

            try
            {
                // Get Task Execution Request details by ID (since 1.6)
                ExecuteTaskRequestCommand result = apiInstance.GetExecutionTaskRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetExecutionTaskRequestById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| ID of Task Execution Request to get | 

### Return type

[**ExecuteTaskRequestCommand**](ExecuteTaskRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodestatus"></a>
# **GetNodeStatus**
> NodeStatus GetNodeStatus (string rkTaskId)

Get the set of node execution status details for a task (since 1.13)

Returns the latest info for each node covered by the task.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeStatusExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var rkTaskId = rkTaskId_example;  // string | ID of Task

            try
            {
                // Get the set of node execution status details for a task (since 1.13)
                NodeStatus result = apiInstance.GetNodeStatus(rkTaskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetNodeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskId** | **string**| ID of Task | 

### Return type

[**NodeStatus**](NodeStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruncontextnoderules"></a>
# **GetRunContextNodeRules**
> RunContextNodeRule GetRunContextNodeRules (List<string> contextId = null, List<string> endTime = null, string endTimeRange = null, string hasErrors = null, string hasTimeout = null, List<string> lastUpdated = null, string lastUpdatedRange = null, List<string> nodeId = null, string pageLimit = null, string pageStart = null, string receivedEnd = null, List<string> ruleId = null, List<string> runType = null, List<string> startTime = null, string startTimeRange = null, string wasCancelled = null)

Get status for node rule pair execution (since 1.13)

Returns a list of all rule run node rule pair status records

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRunContextNodeRulesExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var contextId = new List<string>(); // List<string> | Ids of run context node rules to fetch (optional) 
            var endTime = new List<string>(); // List<string> | End time of run contexts node rules to fetch (optional) 
            var endTimeRange = endTimeRange_example;  // string | End time range of run contexts node rules to fetch (optional) 
            var hasErrors = hasErrors_example;  // string | Has errors condition of run contexts node rules to fetch (optional) 
            var hasTimeout = hasTimeout_example;  // string | Has timeout condition of run contexts node rules to fetch (optional) 
            var lastUpdated = new List<string>(); // List<string> | Last update time of run contexts node rules to fetch (optional) 
            var lastUpdatedRange = lastUpdatedRange_example;  // string | Last update time range of run contexts node rules to fetch (optional) 
            var nodeId = new List<string>(); // List<string> | Ids of nodes of run context node rules to fetch (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var receivedEnd = receivedEnd_example;  // string | Task ids of run contexts node rules to fetch (optional) 
            var ruleId = new List<string>(); // List<string> | Ids of rules of run context node rules to fetch (optional) 
            var runType = runType_example;  // List<string> | Run types of run contexts node rules to fetch (optional) 
            var startTime = new List<string>(); // List<string> | Start time of run contexts node rules to fetch (optional) 
            var startTimeRange = startTimeRange_example;  // string | Start time range of run contexts node rules to fetch (optional) 
            var wasCancelled = wasCancelled_example;  // string | Task ids of run contexts node rules to fetch (optional) 

            try
            {
                // Get status for node rule pair execution (since 1.13)
                RunContextNodeRule result = apiInstance.GetRunContextNodeRules(contextId, endTime, endTimeRange, hasErrors, hasTimeout, lastUpdated, lastUpdatedRange, nodeId, pageLimit, pageStart, receivedEnd, ruleId, runType, startTime, startTimeRange, wasCancelled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetRunContextNodeRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextId** | [**List&lt;string&gt;**](string.md)| Ids of run context node rules to fetch | [optional] 
 **endTime** | [**List&lt;string&gt;**](string.md)| End time of run contexts node rules to fetch | [optional] 
 **endTimeRange** | **string**| End time range of run contexts node rules to fetch | [optional] 
 **hasErrors** | **string**| Has errors condition of run contexts node rules to fetch | [optional] 
 **hasTimeout** | **string**| Has timeout condition of run contexts node rules to fetch | [optional] 
 **lastUpdated** | [**List&lt;string&gt;**](string.md)| Last update time of run contexts node rules to fetch | [optional] 
 **lastUpdatedRange** | **string**| Last update time range of run contexts node rules to fetch | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Ids of nodes of run context node rules to fetch | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **receivedEnd** | **string**| Task ids of run contexts node rules to fetch | [optional] 
 **ruleId** | [**List&lt;string&gt;**](string.md)| Ids of rules of run context node rules to fetch | [optional] 
 **runType** | **List&lt;string&gt;**| Run types of run contexts node rules to fetch | [optional] 
 **startTime** | [**List&lt;string&gt;**](string.md)| Start time of run contexts node rules to fetch | [optional] 
 **startTimeRange** | **string**| Start time range of run contexts node rules to fetch | [optional] 
 **wasCancelled** | **string**| Task ids of run contexts node rules to fetch | [optional] 

### Return type

[**RunContextNodeRule**](RunContextNodeRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruncontextnoderuleslatest"></a>
# **GetRunContextNodeRulesLatest**
> RunContextNodeRule GetRunContextNodeRulesLatest (List<string> contextId = null, List<string> endTime = null, string endTimeRange = null, string hasErrors = null, string hasTimeout = null, List<string> lastUpdated = null, string lastUpdatedRange = null, List<string> nodeId = null, string pageLimit = null, string pageStart = null, string receivedEnd = null, List<string> ruleId = null, List<string> runType = null, List<string> startTime = null, string startTimeRange = null, string wasCancelled = null)

Get most recent status by task for node rule pair execution (since 1.13)

Returns a list the rule run node rule pair status for the latest run context of each task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRunContextNodeRulesLatestExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var contextId = new List<string>(); // List<string> | Ids of run context node rules to fetch (optional) 
            var endTime = new List<string>(); // List<string> | End time of run contexts node rules to fetch (optional) 
            var endTimeRange = endTimeRange_example;  // string | End time range of run contexts node rules to fetch (optional) 
            var hasErrors = hasErrors_example;  // string | Has errors condition of run contexts node rules to fetch (optional) 
            var hasTimeout = hasTimeout_example;  // string | Has timeout condition of run contexts node rules to fetch (optional) 
            var lastUpdated = new List<string>(); // List<string> | Last update time of run contexts node rules to fetch (optional) 
            var lastUpdatedRange = lastUpdatedRange_example;  // string | Last update time range of run contexts node rules to fetch (optional) 
            var nodeId = new List<string>(); // List<string> | Ids of nodes of run context node rules to fetch (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var receivedEnd = receivedEnd_example;  // string | Task ids of run contexts node rules to fetch (optional) 
            var ruleId = new List<string>(); // List<string> | Ids of rules of run context node rules to fetch (optional) 
            var runType = runType_example;  // List<string> | Run types of run contexts node rules to fetch (optional) 
            var startTime = new List<string>(); // List<string> | Start time of run contexts node rules to fetch (optional) 
            var startTimeRange = startTimeRange_example;  // string | Start time range of run contexts node rules to fetch (optional) 
            var wasCancelled = wasCancelled_example;  // string | Task ids of run contexts node rules to fetch (optional) 

            try
            {
                // Get most recent status by task for node rule pair execution (since 1.13)
                RunContextNodeRule result = apiInstance.GetRunContextNodeRulesLatest(contextId, endTime, endTimeRange, hasErrors, hasTimeout, lastUpdated, lastUpdatedRange, nodeId, pageLimit, pageStart, receivedEnd, ruleId, runType, startTime, startTimeRange, wasCancelled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetRunContextNodeRulesLatest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextId** | [**List&lt;string&gt;**](string.md)| Ids of run context node rules to fetch | [optional] 
 **endTime** | [**List&lt;string&gt;**](string.md)| End time of run contexts node rules to fetch | [optional] 
 **endTimeRange** | **string**| End time range of run contexts node rules to fetch | [optional] 
 **hasErrors** | **string**| Has errors condition of run contexts node rules to fetch | [optional] 
 **hasTimeout** | **string**| Has timeout condition of run contexts node rules to fetch | [optional] 
 **lastUpdated** | [**List&lt;string&gt;**](string.md)| Last update time of run contexts node rules to fetch | [optional] 
 **lastUpdatedRange** | **string**| Last update time range of run contexts node rules to fetch | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Ids of nodes of run context node rules to fetch | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **receivedEnd** | **string**| Task ids of run contexts node rules to fetch | [optional] 
 **ruleId** | [**List&lt;string&gt;**](string.md)| Ids of rules of run context node rules to fetch | [optional] 
 **runType** | **List&lt;string&gt;**| Run types of run contexts node rules to fetch | [optional] 
 **startTime** | [**List&lt;string&gt;**](string.md)| Start time of run contexts node rules to fetch | [optional] 
 **startTimeRange** | **string**| Start time range of run contexts node rules to fetch | [optional] 
 **wasCancelled** | **string**| Task ids of run contexts node rules to fetch | [optional] 

### Return type

[**RunContextNodeRule**](RunContextNodeRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruncontexts"></a>
# **GetRunContexts**
> RunContext GetRunContexts (List<string> endTime = null, string endTimeRange = null, string hasErrors = null, List<string> id = null, string pageLimit = null, string previousId = null, List<string> runType = null, List<string> startTime = null, string startTimeRange = null, List<string> stopType = null, List<string> taskId = null)

Get status for rule based task runs (since 1.13)

Returns a list of task run status records

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRunContextsExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var endTime = new List<string>(); // List<string> | End time of run contexts to fetch (optional) 
            var endTimeRange = endTimeRange_example;  // string | End time range of run contexts to fetch (optional) 
            var hasErrors = hasErrors_example;  // string | Has errors condition of run contexts to fetch (optional) 
            var id = new List<string>(); // List<string> | Ids of run contexts to fetch (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var previousId = previousId_example;  // string | When paging, this should be the last element version id returned by the previous page (optional) 
            var runType = runType_example;  // List<string> | Run types of run contexts to fetch (optional) 
            var startTime = new List<string>(); // List<string> | Start time of run contexts to fetch (optional) 
            var startTimeRange = startTimeRange_example;  // string | Start time range of run contexts to fetch (optional) 
            var stopType = stopType_example;  // List<string> | Stop types of run contexts to fetch (optional) 
            var taskId = new List<string>(); // List<string> | Task ids of run contexts to fetch (optional) 

            try
            {
                // Get status for rule based task runs (since 1.13)
                RunContext result = apiInstance.GetRunContexts(endTime, endTimeRange, hasErrors, id, pageLimit, previousId, runType, startTime, startTimeRange, stopType, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetRunContexts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endTime** | [**List&lt;string&gt;**](string.md)| End time of run contexts to fetch | [optional] 
 **endTimeRange** | **string**| End time range of run contexts to fetch | [optional] 
 **hasErrors** | **string**| Has errors condition of run contexts to fetch | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| Ids of run contexts to fetch | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **previousId** | **string**| When paging, this should be the last element version id returned by the previous page | [optional] 
 **runType** | **List&lt;string&gt;**| Run types of run contexts to fetch | [optional] 
 **startTime** | [**List&lt;string&gt;**](string.md)| Start time of run contexts to fetch | [optional] 
 **startTimeRange** | **string**| Start time range of run contexts to fetch | [optional] 
 **stopType** | **List&lt;string&gt;**| Stop types of run contexts to fetch | [optional] 
 **taskId** | [**List&lt;string&gt;**](string.md)| Task ids of run contexts to fetch | [optional] 

### Return type

[**RunContext**](RunContext.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruncontextslatest"></a>
# **GetRunContextsLatest**
> RunContext GetRunContextsLatest (List<string> endTime = null, string endTimeRange = null, string hasErrors = null, List<string> id = null, string pageLimit = null, string previousId = null, List<string> runType = null, List<string> startTime = null, string startTimeRange = null, List<string> stopType = null, List<string> taskId = null)

Get latest status for rule based task runs (since 1.13)

Returns a list of the latest task run status record for each rule based task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRunContextsLatestExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var endTime = new List<string>(); // List<string> | End time of run contexts to fetch (optional) 
            var endTimeRange = endTimeRange_example;  // string | End time range of run contexts to fetch (optional) 
            var hasErrors = hasErrors_example;  // string | Has errors condition of run contexts to fetch (optional) 
            var id = new List<string>(); // List<string> | Ids of run contexts to fetch (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var previousId = previousId_example;  // string | When paging, this should be the last element version id returned by the previous page (optional) 
            var runType = runType_example;  // List<string> | Run types of run contexts to fetch (optional) 
            var startTime = new List<string>(); // List<string> | Start time of run contexts to fetch (optional) 
            var startTimeRange = startTimeRange_example;  // string | Start time range of run contexts to fetch (optional) 
            var stopType = stopType_example;  // List<string> | Stop types of run contexts to fetch (optional) 
            var taskId = new List<string>(); // List<string> | Task ids of run contexts to fetch (optional) 

            try
            {
                // Get latest status for rule based task runs (since 1.13)
                RunContext result = apiInstance.GetRunContextsLatest(endTime, endTimeRange, hasErrors, id, pageLimit, previousId, runType, startTime, startTimeRange, stopType, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetRunContextsLatest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endTime** | [**List&lt;string&gt;**](string.md)| End time of run contexts to fetch | [optional] 
 **endTimeRange** | **string**| End time range of run contexts to fetch | [optional] 
 **hasErrors** | **string**| Has errors condition of run contexts to fetch | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| Ids of run contexts to fetch | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **previousId** | **string**| When paging, this should be the last element version id returned by the previous page | [optional] 
 **runType** | **List&lt;string&gt;**| Run types of run contexts to fetch | [optional] 
 **startTime** | [**List&lt;string&gt;**](string.md)| Start time of run contexts to fetch | [optional] 
 **startTimeRange** | **string**| Start time range of run contexts to fetch | [optional] 
 **stopType** | **List&lt;string&gt;**| Stop types of run contexts to fetch | [optional] 
 **taskId** | [**List&lt;string&gt;**](string.md)| Task ids of run contexts to fetch | [optional] 

### Return type

[**RunContext**](RunContext.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettargetablenodes"></a>
# **GetTargetableNodes**
> Node GetTargetableNodes (string rkTaskId)

Get nodes targeted by this task (since 1.11)

Returns nodes scoped to this task that at least one rule in the task is able to target

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTargetableNodesExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var rkTaskId = rkTaskId_example;  // string | ID of Task to get

            try
            {
                // Get nodes targeted by this task (since 1.11)
                Node result = apiInstance.GetTargetableNodes(rkTaskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTargetableNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskId** | **string**| ID of Task to get | 

### Return type

[**Node**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskbyid"></a>
# **GetTaskById**
> Task GetTaskById (string rkTaskId)

Get task details by ID (since 1.6)

Returns the details of a single task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskByIdExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var rkTaskId = rkTaskId_example;  // string | ID of Task to get

            try
            {
                // Get task details by ID (since 1.6)
                Task result = apiInstance.GetTaskById(rkTaskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskId** | **string**| ID of Task to get | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> Task GetTasks (List<string> actionIds = null, List<string> additionalEmailAddresses = null, bool? archiveAuditEvents = null, List<string> archiveLogsExceeding = null, List<string> archiveLogsOlderThan = null, bool? archiveReports = null, List<string> compactVersionsExceeding = null, List<string> compactVersionsOlderThan = null, List<string> description = null, List<string> emailServer = null, bool? enabled = null, List<string> id = null, bool? ignoreEmptyReports = null, List<string> lastDuration = null, List<string> lastStart = null, List<string> name = null, bool? newBaselinesOnly = null, List<string> nextStart = null, List<string> nodeId = null, string pageLimit = null, string pageStart = null, List<string> reportFormat = null, List<string> reportId = null, List<string> reportUserIds = null, List<string> ruleId = null, List<string> status = null, List<string> subDescription = null, List<string> timeout = null, List<string> type = null, List<string> userId = null)

Get a list of tasks (since 1.6)

Returns a list of all tasks, or only those tasks that match the provided filter criteria. Search filters are supported for all fields except schedule. The task list is returned ordered by name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var actionIds = new List<string>(); // List<string> | Ids of actions to execute for tasks to fetch (optional) 
            var additionalEmailAddresses = new List<string>(); // List<string> | Email addresses that will receive reports from tasks to fetch (optional) 
            var archiveAuditEvents = true;  // bool? | Audit events exceeding retention age option of tasks to fetch (optional) 
            var archiveLogsExceeding = new List<string>(); // List<string> | Number of maximum log messages to retain of tasks to fetch (optional) 
            var archiveLogsOlderThan = new List<string>(); // List<string> | Number of days to retain latests logs of tasks to fetch (optional) 
            var archiveReports = true;  // bool? | Archive report option of tasks to fetch (optional) 
            var compactVersionsExceeding = new List<string>(); // List<string> | Maximum latests element versions to reatain of tasks to fetch (optional) 
            var compactVersionsOlderThan = new List<string>(); // List<string> | Days to ratain element versions of tasks to fetch (optional) 
            var description = new List<string>(); // List<string> | Description of tasks to fetch (optional) 
            var emailServer = new List<string>(); // List<string> | Name of email server for sending reports from tasks to fetch (optional) 
            var enabled = true;  // bool? | Fetch only tasks that are enabled or disabled (optional) 
            var id = new List<string>(); // List<string> | Ids of tasks to fetch (optional) 
            var ignoreEmptyReports = true;  // bool? | Ignore empty reports option of tasks to fetch (optional) 
            var lastDuration = new List<string>(); // List<string> | Last duration of execution of tasks to fetch (optional) 
            var lastStart = new List<string>(); // List<string> | Last start of execution of tasks to fetch (optional) 
            var name = new List<string>(); // List<string> | Name of tasks to fetch (optional) 
            var newBaselinesOnly = true;  // bool? | New baseline element versions creation restriction option of tasks to fetch (optional) 
            var nextStart = new List<string>(); // List<string> | Next start for execution of tasks to fetch (optional) 
            var nodeId = new List<string>(); // List<string> | Node or node group ids in scope of tasks to fetch (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var reportFormat = new List<string>(); // List<string> | Report format used for tasks to fetch (optional) 
            var reportId = new List<string>(); // List<string> | Ids of reports to execute for tasks to fetch (optional) 
            var reportUserIds = new List<string>(); // List<string> | Ids of users who will receive reports from tasks to fetch (optional) 
            var ruleId = new List<string>(); // List<string> | Rule or rule group ids in scope of tasks to fetch (optional) 
            var status = new List<string>(); // List<string> | Statuses of tasks to fetch (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description of tasks to fetch (optional) 
            var timeout = new List<string>(); // List<string> | Hour timeout of tasks to fetch (optional) 
            var type = new List<string>(); // List<string> | Type of tasks to fetch (optional) 
            var userId = new List<string>(); // List<string> | Ids of users of tasks to fetch (optional) 

            try
            {
                // Get a list of tasks (since 1.6)
                Task result = apiInstance.GetTasks(actionIds, additionalEmailAddresses, archiveAuditEvents, archiveLogsExceeding, archiveLogsOlderThan, archiveReports, compactVersionsExceeding, compactVersionsOlderThan, description, emailServer, enabled, id, ignoreEmptyReports, lastDuration, lastStart, name, newBaselinesOnly, nextStart, nodeId, pageLimit, pageStart, reportFormat, reportId, reportUserIds, ruleId, status, subDescription, timeout, type, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionIds** | [**List&lt;string&gt;**](string.md)| Ids of actions to execute for tasks to fetch | [optional] 
 **additionalEmailAddresses** | [**List&lt;string&gt;**](string.md)| Email addresses that will receive reports from tasks to fetch | [optional] 
 **archiveAuditEvents** | **bool?**| Audit events exceeding retention age option of tasks to fetch | [optional] 
 **archiveLogsExceeding** | [**List&lt;string&gt;**](string.md)| Number of maximum log messages to retain of tasks to fetch | [optional] 
 **archiveLogsOlderThan** | [**List&lt;string&gt;**](string.md)| Number of days to retain latests logs of tasks to fetch | [optional] 
 **archiveReports** | **bool?**| Archive report option of tasks to fetch | [optional] 
 **compactVersionsExceeding** | [**List&lt;string&gt;**](string.md)| Maximum latests element versions to reatain of tasks to fetch | [optional] 
 **compactVersionsOlderThan** | [**List&lt;string&gt;**](string.md)| Days to ratain element versions of tasks to fetch | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Description of tasks to fetch | [optional] 
 **emailServer** | [**List&lt;string&gt;**](string.md)| Name of email server for sending reports from tasks to fetch | [optional] 
 **enabled** | **bool?**| Fetch only tasks that are enabled or disabled | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| Ids of tasks to fetch | [optional] 
 **ignoreEmptyReports** | **bool?**| Ignore empty reports option of tasks to fetch | [optional] 
 **lastDuration** | [**List&lt;string&gt;**](string.md)| Last duration of execution of tasks to fetch | [optional] 
 **lastStart** | [**List&lt;string&gt;**](string.md)| Last start of execution of tasks to fetch | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Name of tasks to fetch | [optional] 
 **newBaselinesOnly** | **bool?**| New baseline element versions creation restriction option of tasks to fetch | [optional] 
 **nextStart** | [**List&lt;string&gt;**](string.md)| Next start for execution of tasks to fetch | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Node or node group ids in scope of tasks to fetch | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **reportFormat** | [**List&lt;string&gt;**](string.md)| Report format used for tasks to fetch | [optional] 
 **reportId** | [**List&lt;string&gt;**](string.md)| Ids of reports to execute for tasks to fetch | [optional] 
 **reportUserIds** | [**List&lt;string&gt;**](string.md)| Ids of users who will receive reports from tasks to fetch | [optional] 
 **ruleId** | [**List&lt;string&gt;**](string.md)| Rule or rule group ids in scope of tasks to fetch | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| Statuses of tasks to fetch | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description of tasks to fetch | [optional] 
 **timeout** | [**List&lt;string&gt;**](string.md)| Hour timeout of tasks to fetch | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Type of tasks to fetch | [optional] 
 **userId** | [**List&lt;string&gt;**](string.md)| Ids of users of tasks to fetch | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> Task UpdateTask (string rkTaskId, Task task)

Put an update to an existing task (since 1.6)

Updates an existing task, ignoring the following read-only fields: type, status, lastStart, lastDuration, and nextStart. You may not rename to the same name as another task.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var rkTaskId = rkTaskId_example;  // string | ID of Task to be updated
            var task = new Task(); // Task | Task description to update the existing task

            try
            {
                // Put an update to an existing task (since 1.6)
                Task result = apiInstance.UpdateTask(rkTaskId, task);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskId** | **string**| ID of Task to be updated | 
 **task** | [**Task**](Task.md)| Task description to update the existing task | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

