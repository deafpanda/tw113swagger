# IO.Swagger.Api.NodegroupsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateNodeGroupableToNodeGroup**](NodegroupsApi.md#associatenodegroupabletonodegroup) | **POST** /nodegroups/{rkParentId}/links/{rkChildId} | Post a new link to a node group (since 1.7)
[**CreateNodeGroup**](NodegroupsApi.md#createnodegroup) | **POST** /nodegroups | Create a new node group
[**DeleteNodeGroup**](NodegroupsApi.md#deletenodegroup) | **DELETE** /nodegroups/{rkNodeGroupId} | Delete a node group
[**DisassociateNodeGroupableToNodeGroup**](NodegroupsApi.md#disassociatenodegroupabletonodegroup) | **DELETE** /nodegroups/{rkParentId}/links/{rkChildId} | Delete a link to a node group (since 1.7)
[**GetNodeGroupChildren**](NodegroupsApi.md#getnodegroupchildren) | **GET** /nodegroups/{rkNodeGroupId}/links | Get children of a node group (since 1.7)
[**GetNodeGroupDescendantNodes**](NodegroupsApi.md#getnodegroupdescendantnodes) | **GET** /nodegroups/{rkNodeGroupId}/descendantNodes | Get descendants of a node group (since 1.11)
[**GetNodeGroups**](NodegroupsApi.md#getnodegroups) | **GET** /nodegroups | Search all node groups (since 1.6)
[**GetRootNodeGroup**](NodegroupsApi.md#getrootnodegroup) | **GET** /nodegroups/root | Get root node group (since 1.6)


<a name="associatenodegroupabletonodegroup"></a>
# **AssociateNodeGroupableToNodeGroup**
> void AssociateNodeGroupableToNodeGroup (string rkParentId, string rkChildId)

Post a new link to a node group (since 1.7)

Creates a link between a node group and a node or other node group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateNodeGroupableToNodeGroupExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var rkParentId = rkParentId_example;  // string | Id of parent node group
            var rkChildId = rkChildId_example;  // string | Id of child node or node group

            try
            {
                // Post a new link to a node group (since 1.7)
                apiInstance.AssociateNodeGroupableToNodeGroup(rkParentId, rkChildId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.AssociateNodeGroupableToNodeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkParentId** | **string**| Id of parent node group | 
 **rkChildId** | **string**| Id of child node or node group | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnodegroup"></a>
# **CreateNodeGroup**
> NodeGroup CreateNodeGroup (NodeGroup body)

Create a new node group

Returns the newly created node group. A new node group will be in the unlinked group until it is linked with another group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateNodeGroupExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var body = new NodeGroup(); // NodeGroup | Node group object to be created in TE

            try
            {
                // Create a new node group
                NodeGroup result = apiInstance.CreateNodeGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.CreateNodeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeGroup**](NodeGroup.md)| Node group object to be created in TE | 

### Return type

[**NodeGroup**](NodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenodegroup"></a>
# **DeleteNodeGroup**
> void DeleteNodeGroup (string rkNodeGroupId)

Delete a node group

Removes a node group, leaving any child nodes or node groups in the unlinked group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNodeGroupExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var rkNodeGroupId = rkNodeGroupId_example;  // string | ID of node group to delete

            try
            {
                // Delete a node group
                apiInstance.DeleteNodeGroup(rkNodeGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.DeleteNodeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeGroupId** | **string**| ID of node group to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociatenodegroupabletonodegroup"></a>
# **DisassociateNodeGroupableToNodeGroup**
> void DisassociateNodeGroupableToNodeGroup (string rkParentId, string rkChildId)

Delete a link to a node group (since 1.7)

Removes a link between a node group and a node or other node group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisassociateNodeGroupableToNodeGroupExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var rkParentId = rkParentId_example;  // string | Id of parent node group
            var rkChildId = rkChildId_example;  // string | Id of child node or node group

            try
            {
                // Delete a link to a node group (since 1.7)
                apiInstance.DisassociateNodeGroupableToNodeGroup(rkParentId, rkChildId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.DisassociateNodeGroupableToNodeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkParentId** | **string**| Id of parent node group | 
 **rkChildId** | **string**| Id of child node or node group | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodegroupchildren"></a>
# **GetNodeGroupChildren**
> List<NodeGroupChild> GetNodeGroupChildren (string rkNodeGroupId)

Get children of a node group (since 1.7)

Returns a list of all visible, immediate children of a node group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeGroupChildrenExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var rkNodeGroupId = rkNodeGroupId_example;  // string | Id of parent node group

            try
            {
                // Get children of a node group (since 1.7)
                List&lt;NodeGroupChild&gt; result = apiInstance.GetNodeGroupChildren(rkNodeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.GetNodeGroupChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeGroupId** | **string**| Id of parent node group | 

### Return type

[**List<NodeGroupChild>**](NodeGroupChild.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodegroupdescendantnodes"></a>
# **GetNodeGroupDescendantNodes**
> List<NodeGroupChild> GetNodeGroupDescendantNodes (string rkNodeGroupId)

Get descendants of a node group (since 1.11)

Returns a list of all visible descendant nodes of a node group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeGroupDescendantNodesExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var rkNodeGroupId = rkNodeGroupId_example;  // string | Id of parent node group

            try
            {
                // Get descendants of a node group (since 1.11)
                List&lt;NodeGroupChild&gt; result = apiInstance.GetNodeGroupDescendantNodes(rkNodeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.GetNodeGroupDescendantNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeGroupId** | **string**| Id of parent node group | 

### Return type

[**List<NodeGroupChild>**](NodeGroupChild.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodegroups"></a>
# **GetNodeGroups**
> List<NodeGroup> GetNodeGroups (string pageLimit = null, string pageStart = null, List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> modifiedTime = null, List<string> importedTime = null, List<string> trackingId = null, List<string> type = null)

Search all node groups (since 1.6)

Return a list of all node groups or only those node groups that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeGroupsExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var id = new List<string>(); // List<string> | IDs of Node Groups to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of Node Groups to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of Node Groups to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Support for like search for description parameter. (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modified times of Node Groups to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Imported times of Node Groups to fetch. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking ids of Node Groups to fetch. (optional) 
            var type = new List<string>(); // List<string> | Types of Node Groups to fetch. (optional) 

            try
            {
                // Search all node groups (since 1.6)
                List&lt;NodeGroup&gt; result = apiInstance.GetNodeGroups(pageLimit, pageStart, id, name, description, subDescription, modifiedTime, importedTime, trackingId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.GetNodeGroups: " + e.Message );
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
 **id** | [**List&lt;string&gt;**](string.md)| IDs of Node Groups to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of Node Groups to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of Node Groups to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for like search for description parameter. | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modified times of Node Groups to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Imported times of Node Groups to fetch. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking ids of Node Groups to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Types of Node Groups to fetch. | [optional] 

### Return type

[**List<NodeGroup>**](NodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootnodegroup"></a>
# **GetRootNodeGroup**
> NodeGroup GetRootNodeGroup ()

Get root node group (since 1.6)

Returns the node group resource for the 'Root Node Group'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootNodeGroupExample
    {
        public void main()
        {
            var apiInstance = new NodegroupsApi();

            try
            {
                // Get root node group (since 1.6)
                NodeGroup result = apiInstance.GetRootNodeGroup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodegroupsApi.GetRootNodeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NodeGroup**](NodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

