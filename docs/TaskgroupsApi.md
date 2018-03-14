# IO.Swagger.Api.TaskgroupsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateTaskGroupableToTaskGroup**](TaskgroupsApi.md#associatetaskgroupabletotaskgroup) | **POST** /taskgroups/{rkTaskGroupId}/links/{rkTaskGroupableId} | Add a Task Group link (since 1.11)
[**CreateTaskGroup**](TaskgroupsApi.md#createtaskgroup) | **POST** /taskgroups | Create a new Task Group (since 1.11)
[**DeleteTaskGroup**](TaskgroupsApi.md#deletetaskgroup) | **DELETE** /taskgroups/{rkTaskGroupId} | Delete a Task Group (since 1.11)
[**DisassociateTaskGroupableFromTaskGroup**](TaskgroupsApi.md#disassociatetaskgroupablefromtaskgroup) | **DELETE** /taskgroups/{rkTaskGroupId}/links/{rkTaskGroupableId} | Delete a Task Group link (since 1.11)
[**GetRootTaskGroup**](TaskgroupsApi.md#getroottaskgroup) | **GET** /taskgroups/root | Get root Task Group (since 1.11)
[**GetTaskGroupById**](TaskgroupsApi.md#gettaskgroupbyid) | **GET** /taskgroups/{rkTaskGroupId} | Get the details of a single Task Group (since 1.11)
[**GetTaskGroupChildren**](TaskgroupsApi.md#gettaskgroupchildren) | **GET** /taskgroups/{rkTaskGroupId}/links | Get children of a Task Group (since 1.11)
[**GetTaskGroups**](TaskgroupsApi.md#gettaskgroups) | **GET** /taskgroups | Search all Task Groups (since 1.11)


<a name="associatetaskgroupabletotaskgroup"></a>
# **AssociateTaskGroupableToTaskGroup**
> void AssociateTaskGroupableToTaskGroup (string rkTaskGroupId, string rkTaskGroupableId)

Add a Task Group link (since 1.11)

Links a task or Task Group as a child in another Task Group. Tasks and Task Groups may be linked into many Task Groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateTaskGroupableToTaskGroupExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var rkTaskGroupId = rkTaskGroupId_example;  // string | ID of Task Group to create the link
            var rkTaskGroupableId = rkTaskGroupableId_example;  // string | ID of Task Groupable to create the link

            try
            {
                // Add a Task Group link (since 1.11)
                apiInstance.AssociateTaskGroupableToTaskGroup(rkTaskGroupId, rkTaskGroupableId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.AssociateTaskGroupableToTaskGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskGroupId** | **string**| ID of Task Group to create the link | 
 **rkTaskGroupableId** | **string**| ID of Task Groupable to create the link | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtaskgroup"></a>
# **CreateTaskGroup**
> TaskGroup CreateTaskGroup (TaskGroup body)

Create a new Task Group (since 1.11)

Returns the newly created Task Group. New Task Groups are in the Unlinked Group until linked with another Task Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskGroupExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var body = new TaskGroup(); // TaskGroup | Task Group object to be created in TE

            try
            {
                // Create a new Task Group (since 1.11)
                TaskGroup result = apiInstance.CreateTaskGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.CreateTaskGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TaskGroup**](TaskGroup.md)| Task Group object to be created in TE | 

### Return type

[**TaskGroup**](TaskGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskgroup"></a>
# **DeleteTaskGroup**
> void DeleteTaskGroup (string rkTaskGroupId)

Delete a Task Group (since 1.11)

Removes a Task Group from TE. Child tasks and Task Groups with no other links will be move to the Unlinked Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskGroupExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var rkTaskGroupId = rkTaskGroupId_example;  // string | ID of Task Group to delete

            try
            {
                // Delete a Task Group (since 1.11)
                apiInstance.DeleteTaskGroup(rkTaskGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.DeleteTaskGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskGroupId** | **string**| ID of Task Group to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociatetaskgroupablefromtaskgroup"></a>
# **DisassociateTaskGroupableFromTaskGroup**
> void DisassociateTaskGroupableFromTaskGroup (string rkTaskGroupId, string rkTaskGroupableId)

Delete a Task Group link (since 1.11)

Removes a child task or Task Group from a parent Task Group. If the child is no longer linked to any other Task Groups, then it is moved to the Unlinked Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisassociateTaskGroupableFromTaskGroupExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var rkTaskGroupId = rkTaskGroupId_example;  // string | ID of Task Group to delete the link
            var rkTaskGroupableId = rkTaskGroupableId_example;  // string | ID of Task Groupable to delete the link

            try
            {
                // Delete a Task Group link (since 1.11)
                apiInstance.DisassociateTaskGroupableFromTaskGroup(rkTaskGroupId, rkTaskGroupableId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.DisassociateTaskGroupableFromTaskGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskGroupId** | **string**| ID of Task Group to delete the link | 
 **rkTaskGroupableId** | **string**| ID of Task Groupable to delete the link | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroottaskgroup"></a>
# **GetRootTaskGroup**
> TaskGroup GetRootTaskGroup ()

Get root Task Group (since 1.11)

Returns the Task Group resource for the 'Root Task Group'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootTaskGroupExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();

            try
            {
                // Get root Task Group (since 1.11)
                TaskGroup result = apiInstance.GetRootTaskGroup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.GetRootTaskGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TaskGroup**](TaskGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskgroupbyid"></a>
# **GetTaskGroupById**
> TaskGroup GetTaskGroupById (string rkTaskGroupId)

Get the details of a single Task Group (since 1.11)

Return a specific task group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskGroupByIdExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var rkTaskGroupId = rkTaskGroupId_example;  // string | ID of Task Group to fetch

            try
            {
                // Get the details of a single Task Group (since 1.11)
                TaskGroup result = apiInstance.GetTaskGroupById(rkTaskGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.GetTaskGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskGroupId** | **string**| ID of Task Group to fetch | 

### Return type

[**TaskGroup**](TaskGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskgroupchildren"></a>
# **GetTaskGroupChildren**
> List<TaskGroupChild> GetTaskGroupChildren (string rkTaskGroupId)

Get children of a Task Group (since 1.11)

Returns a list of all visible, immediate children of a Task Group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskGroupChildrenExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var rkTaskGroupId = rkTaskGroupId_example;  // string | Id of parent Task Group

            try
            {
                // Get children of a Task Group (since 1.11)
                List&lt;TaskGroupChild&gt; result = apiInstance.GetTaskGroupChildren(rkTaskGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.GetTaskGroupChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkTaskGroupId** | **string**| Id of parent Task Group | 

### Return type

[**List<TaskGroupChild>**](TaskGroupChild.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskgroups"></a>
# **GetTaskGroups**
> List<TaskGroup> GetTaskGroups (string pageLimit = null, string pageStart = null, List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> modifiedTime = null, List<string> importedTime = null, List<string> trackingId = null)

Search all Task Groups (since 1.11)

Return a list of all Task Groups or only those Task Groups that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskGroupsExample
    {
        public void main()
        {
            var apiInstance = new TaskgroupsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var id = new List<string>(); // List<string> | IDs of Task Groups to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of Task Groups to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of Task Groups to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Support for like search for description parameter. (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modified times of Task Groups to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Imported times of Task Groups to fetch. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking ids of Task Groups to fetch. (optional) 

            try
            {
                // Search all Task Groups (since 1.11)
                List&lt;TaskGroup&gt; result = apiInstance.GetTaskGroups(pageLimit, pageStart, id, name, description, subDescription, modifiedTime, importedTime, trackingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskgroupsApi.GetTaskGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of Task Groups to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of Task Groups to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of Task Groups to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for like search for description parameter. | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modified times of Task Groups to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Imported times of Task Groups to fetch. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking ids of Task Groups to fetch. | [optional] 

### Return type

[**List<TaskGroup>**](TaskGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

