# IO.Swagger.Api.NodesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomPropertyType**](NodesApi.md#createcustompropertytype) | **POST** /nodes/customPropertyTypes | Create a node custom property definition (since 1.5)
[**CreateNode**](NodesApi.md#createnode) | **POST** /nodes | Create a node (since 1.11)
[**CreateNodeAcl**](NodesApi.md#createnodeacl) | **POST** /nodes/{rkNodeId}/acl | Post a new node access control list (since 1.4)
[**DeleteCustomPropertyType**](NodesApi.md#deletecustompropertytype) | **DELETE** /nodes/customPropertyTypes/{rkCustomPropertyTypeId} | Delete a custom property type (since 1.6)
[**DeleteNode**](NodesApi.md#deletenode) | **DELETE** /nodes/{rkNodeId} | Retire a node by removing all node licenses allocated to it (since 1.3)
[**DeleteNodeCustomProperty**](NodesApi.md#deletenodecustomproperty) | **DELETE** /nodes/{rkNodeId}/customProperties/{propertyName} | Delete a custom property value from a node (since 1.5)
[**GetCustomProperties**](NodesApi.md#getcustomproperties) | **GET** /nodes/{rkNodeId}/customProperties | Get custom property values for a node (since 1.5)
[**GetCustomPropertyTypeById**](NodesApi.md#getcustompropertytypebyid) | **GET** /nodes/customPropertyTypes/{rkCustomPropertyTypeId} | Get a custom property type (since 1.5)
[**GetCustomPropertyTypes**](NodesApi.md#getcustompropertytypes) | **GET** /nodes/customPropertyTypes | Search custom property types (since 1.5)
[**GetNodeAcl**](NodesApi.md#getnodeacl) | **GET** /nodes/{rkNodeId}/acl | Get node access control list (since 1.4)
[**GetNodeById**](NodesApi.md#getnodebyid) | **GET** /nodes/{rkNodeId} | Get node details by ID (since 1.3)
[**GetNodeParentGroups**](NodesApi.md#getnodeparentgroups) | **GET** /nodes/{rkNodeId}/parentGroups | List parent groups for a node (since 1.5)
[**GetNodes**](NodesApi.md#getnodes) | **GET** /nodes | Search nodes (since 1.3)
[**GetRuleRunRequestById**](NodesApi.md#getrulerunrequestbyid) | **GET** /nodes/ruleRunRequests/{requestId} | Get the status of a rule run request (since 1.11)
[**RestartNodes**](NodesApi.md#restartnodes) | **POST** /nodes/restart | Restart Agents to bring them back in sync with the TE Server (since 1.3)
[**RetireNode**](NodesApi.md#retirenode) | **POST** /nodes/{rkNodeId}/retire | Retire a node by removing all node licenses allocated to it (since 1.3)
[**RuleRunRequest**](NodesApi.md#rulerunrequest) | **POST** /nodes/ruleRunRequests | Run rules on nodes (since 1.11)
[**SetNodeCustomProperty**](NodesApi.md#setnodecustomproperty) | **POST** /nodes/{rkNodeId}/customProperties/{propertyName} | Set a custom property value for a node (since 1.5)
[**UnregisterCommonAgent**](NodesApi.md#unregistercommonagent) | **POST** /nodes/{rkNodeId}/unregisterCommonAgent | Unregister an Axon agent from the server node (since 1.4)
[**UpdateCustomPropertyType**](NodesApi.md#updatecustompropertytype) | **PUT** /nodes/customPropertyTypes/{rkCustomPropertyTypeId} | Update an existing node custom property type (since 1.6)
[**UpdateNode**](NodesApi.md#updatenode) | **PUT** /nodes/{rkNodeId} | Update a node (since 1.4)


<a name="createcustompropertytype"></a>
# **CreateCustomPropertyType**
> CustomPropertyType CreateCustomPropertyType (CustomPropertyType body)

Create a node custom property definition (since 1.5)

Allows creating models for custom meta-data that can be later applied to nodes to be retrieved later, or used in filtering.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomPropertyTypeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var body = new CustomPropertyType(); // CustomPropertyType | Custom property type to be created

            try
            {
                // Create a node custom property definition (since 1.5)
                CustomPropertyType result = apiInstance.CreateCustomPropertyType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.CreateCustomPropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomPropertyType**](CustomPropertyType.md)| Custom property type to be created | 

### Return type

[**CustomPropertyType**](CustomPropertyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnode"></a>
# **CreateNode**
> Node CreateNode (Node body)

Create a node (since 1.11)

Creates a node with the given configuration. Many node types are supported, with unique field sets. Please see <a href=\"help.html#CreateNode\">help.html</a> for additional detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateNodeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var body = new Node(); // Node | Node object to be created in TE

            try
            {
                // Create a node (since 1.11)
                Node result = apiInstance.CreateNode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.CreateNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Node**](Node.md)| Node object to be created in TE | 

### Return type

[**Node**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnodeacl"></a>
# **CreateNodeAcl**
> string CreateNodeAcl (string rkNodeId, Object body)

Post a new node access control list (since 1.4)

Replaces the access control list for a node with the new submitted set of entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateNodeAclExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of node to fetch the ACL
            var body = ;  // Object | ACL - Map of user or user group IDs to role IDs

            try
            {
                // Post a new node access control list (since 1.4)
                string result = apiInstance.CreateNodeAcl(rkNodeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.CreateNodeAcl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of node to fetch the ACL | 
 **body** | **Object**| ACL - Map of user or user group IDs to role IDs | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustompropertytype"></a>
# **DeleteCustomPropertyType**
> void DeleteCustomPropertyType (string rkCustomPropertyTypeId)

Delete a custom property type (since 1.6)

Delete an existing node custom property type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCustomPropertyTypeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Removes a node custom property type, and the value assignments to all nodes

            try
            {
                // Delete a custom property type (since 1.6)
                apiInstance.DeleteCustomPropertyType(rkCustomPropertyTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.DeleteCustomPropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkCustomPropertyTypeId** | **string**| Removes a node custom property type, and the value assignments to all nodes | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenode"></a>
# **DeleteNode**
> void DeleteNode (string rkNodeId)

Retire a node by removing all node licenses allocated to it (since 1.3)

Permissions needed: 'tool.node.load'

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNodeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of node to delete

            try
            {
                // Retire a node by removing all node licenses allocated to it (since 1.3)
                apiInstance.DeleteNode(rkNodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.DeleteNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of node to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenodecustomproperty"></a>
# **DeleteNodeCustomProperty**
> void DeleteNodeCustomProperty (string rkNodeId, string propertyName)

Delete a custom property value from a node (since 1.5)

Removes the custom property assignment from the node. If the custom property type is configured to inherit default values, then the default for that custom property type will become active on the node. Inherited custom property values cannot be deleted and attempts to do so will result in a 404

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNodeCustomPropertyExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | Id of node
            var propertyName = propertyName_example;  // string | Name of node custom property to unassign from the node

            try
            {
                // Delete a custom property value from a node (since 1.5)
                apiInstance.DeleteNodeCustomProperty(rkNodeId, propertyName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.DeleteNodeCustomProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| Id of node | 
 **propertyName** | **string**| Name of node custom property to unassign from the node | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomproperties"></a>
# **GetCustomProperties**
> CustomProperties GetCustomProperties (string rkNodeId)

Get custom property values for a node (since 1.5)

Return the map of custom properties names and their assigned value, either assigned directly to a node, or inherited by default.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomPropertiesExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of node to fetch

            try
            {
                // Get custom property values for a node (since 1.5)
                CustomProperties result = apiInstance.GetCustomProperties(rkNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetCustomProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of node to fetch | 

### Return type

[**CustomProperties**](CustomProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustompropertytypebyid"></a>
# **GetCustomPropertyTypeById**
> CustomPropertyType GetCustomPropertyTypeById (string rkCustomPropertyTypeId)

Get a custom property type (since 1.5)

Returns the details of a custom property type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomPropertyTypeByIdExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Id of custom property type to fetch

            try
            {
                // Get a custom property type (since 1.5)
                CustomPropertyType result = apiInstance.GetCustomPropertyTypeById(rkCustomPropertyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetCustomPropertyTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkCustomPropertyTypeId** | **string**| Id of custom property type to fetch | 

### Return type

[**CustomPropertyType**](CustomPropertyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustompropertytypes"></a>
# **GetCustomPropertyTypes**
> CustomPropertyType GetCustomPropertyTypes (bool? allowMultilineValues = null, List<string> availableValues = null, List<string> defaultValue = null, List<string> description = null, List<string> id = null, bool? inheritDefault = null, List<string> maxCharacters = null, List<string> maxValue = null, List<string> minValue = null, List<string> name = null, List<string> subDescription = null, List<string> textEditorWidth = null, List<string> type = null)

Search custom property types (since 1.5)

Returns all custom property type definitions that can be applied to nodes, or those that meet the filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomPropertyTypesExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var allowMultilineValues = true;  // bool? | Allow multiline values condition of custom property types to fetch. (optional) 
            var availableValues = new List<string>(); // List<string> | Available values of custom property types to fetch. (optional) 
            var defaultValue = new List<string>(); // List<string> | Default values of custom property types to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of custom property types to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of custom property types to fetch. (optional) 
            var inheritDefault = true;  // bool? | Inherit default condition of custom property types to fetch. (optional) 
            var maxCharacters = new List<string>(); // List<string> | Max characters conditions of custom property types to fetch. (optional) 
            var maxValue = new List<string>(); // List<string> | Max values of custom property types to fetch. (optional) 
            var minValue = new List<string>(); // List<string> | Min values of custom property types to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of custom property types to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description. (optional) 
            var textEditorWidth = new List<string>(); // List<string> | Text editor width conditions of custom property types to fetch. (optional) 
            var type = new List<string>(); // List<string> | Types of custom property types to fetch. (optional) 

            try
            {
                // Search custom property types (since 1.5)
                CustomPropertyType result = apiInstance.GetCustomPropertyTypes(allowMultilineValues, availableValues, defaultValue, description, id, inheritDefault, maxCharacters, maxValue, minValue, name, subDescription, textEditorWidth, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetCustomPropertyTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allowMultilineValues** | **bool?**| Allow multiline values condition of custom property types to fetch. | [optional] 
 **availableValues** | [**List&lt;string&gt;**](string.md)| Available values of custom property types to fetch. | [optional] 
 **defaultValue** | [**List&lt;string&gt;**](string.md)| Default values of custom property types to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of custom property types to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of custom property types to fetch. | [optional] 
 **inheritDefault** | **bool?**| Inherit default condition of custom property types to fetch. | [optional] 
 **maxCharacters** | [**List&lt;string&gt;**](string.md)| Max characters conditions of custom property types to fetch. | [optional] 
 **maxValue** | [**List&lt;string&gt;**](string.md)| Max values of custom property types to fetch. | [optional] 
 **minValue** | [**List&lt;string&gt;**](string.md)| Min values of custom property types to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of custom property types to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description. | [optional] 
 **textEditorWidth** | [**List&lt;string&gt;**](string.md)| Text editor width conditions of custom property types to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Types of custom property types to fetch. | [optional] 

### Return type

[**CustomPropertyType**](CustomPropertyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodeacl"></a>
# **GetNodeAcl**
> string GetNodeAcl (string rkNodeId)

Get node access control list (since 1.4)

Returns the access control list for the specified node.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeAclExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of Node to fetch the ACL

            try
            {
                // Get node access control list (since 1.4)
                string result = apiInstance.GetNodeAcl(rkNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetNodeAcl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of Node to fetch the ACL | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodebyid"></a>
# **GetNodeById**
> Node GetNodeById (string rkNodeId)

Get node details by ID (since 1.3)

Returns the details of a single node.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeByIdExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of node to fetch

            try
            {
                // Get node details by ID (since 1.3)
                Node result = apiInstance.GetNodeById(rkNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetNodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of node to fetch | 

### Return type

[**Node**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodeparentgroups"></a>
# **GetNodeParentGroups**
> NodeGroupPath GetNodeParentGroups (string rkNodeId)

List parent groups for a node (since 1.5)

Returns a list of the parent groups for a node with a specific ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeParentGroupsExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of the node

            try
            {
                // List parent groups for a node (since 1.5)
                NodeGroupPath result = apiInstance.GetNodeParentGroups(rkNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetNodeParentGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of the node | 

### Return type

[**NodeGroupPath**](NodeGroupPath.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodes"></a>
# **GetNodes**
> Node GetNodes (List<string> agentVersion = null, bool? auditEnabled = null, List<string> commonAgentCapabilities = null, List<string> commonAgentOsName = null, List<string> commonAgentOsVersion = null, List<string> commonAgentUuid = null, List<string> commonAgentVersion = null, List<string> customProperty = null, List<string> description = null, List<string> elementCount = null, bool? eventGeneratorEnabled = null, bool? eventGeneratorInstalled = null, bool? hasFailures = null, List<string> icName = null, List<string> id = null, List<string> importedTime = null, string importedTimeRange = null, List<string> ipAddress = null, bool? isDisabled = null, bool? isSocksProxy = null, bool? isSSLSupported = null, List<string> lastCheck = null, List<string> lastRegistration = null, List<string> licensedFeature = null, List<string> macAddress = null, List<string> make = null, List<string> maxSeverity = null, List<string> model = null, List<string> modifiedTime = null, List<string> name = null, List<string> oid = null, string pageLimit = null, string pageStart = null, List<string> proxyHost = null, List<string> proxyPort = null, bool? realTimeEnabled = null, List<string> rmiHost = null, List<string> rmiPort = null, List<string> subDescription = null, List<string> subName = null, List<string> tag = null, List<string> trackingId = null, List<string> type = null, bool? usingSSL = null, List<string> version = null)

Search nodes (since 1.3)

Returns a list of all nodes or those that match the provided filter criteria. Nodes that the user does not have access to will be omitted from the search results. Filtering for nodes by ip-address only works for agent nodes, because the ip-addresses for other node types are not persisted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodesExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var agentVersion = new List<string>(); // List<string> | Agent versions of nodes to fetch. (optional) 
            var auditEnabled = true;  // bool? | Audit enabled condition of nodes to fetch. (optional) 
            var commonAgentCapabilities = new List<string>(); // List<string> | Axon agent capabilities of nodes to fetch. (optional) 
            var commonAgentOsName = new List<string>(); // List<string> | Axon agent OS names of nodes to fetch. (optional) 
            var commonAgentOsVersion = new List<string>(); // List<string> | Axon agent OS versions of nodes to fetch. (optional) 
            var commonAgentUuid = new List<string>(); // List<string> | Axon agent uuids of nodes to fetch. (optional) 
            var commonAgentVersion = new List<string>(); // List<string> | Axon agent versions of nodes to fetch. (optional) 
            var customProperty = new List<string>(); // List<string> | Custom properties values of nodes to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of nodes to fetch. (optional) 
            var elementCount = new List<string>(); // List<string> | Element counts of nodes to fetch. (optional) 
            var eventGeneratorEnabled = true;  // bool? | Event generator enabled condition of nodes to fetch. (optional) 
            var eventGeneratorInstalled = true;  // bool? | Event generator installed condition of nodes to fetch. (optional) 
            var hasFailures = true;  // bool? | Has failures condition of nodes to fetch. (optional) 
            var icName = new List<string>(); // List<string> | Support for case insensitive search for name parameter. (optional) 
            var id = new List<string>(); // List<string> | IDs of nodes to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Imported times of nodes to fetch. (optional) 
            var importedTimeRange = importedTimeRange_example;  // string | Imported time range of nodes to fetch (optional) 
            var ipAddress = new List<string>(); // List<string> | IP addresses of nodes to fetch (only finds agent nodes). (optional) 
            var isDisabled = true;  // bool? | Is disabled condition of nodes to fetch. (optional) 
            var isSocksProxy = true;  // bool? | Is socks proxy condition of nodes to fetch. (optional) 
            var isSSLSupported = true;  // bool? | Is SSL supported condition of nodes to fetch. (optional) 
            var lastCheck = new List<string>(); // List<string> | Last checks of nodes to fetch. (optional) 
            var lastRegistration = new List<string>(); // List<string> | Last registration dates of nodes to fetch. (optional) 
            var licensedFeature = new List<string>(); // List<string> | Licensed features of nodes to fetch. (optional) 
            var macAddress = new List<string>(); // List<string> | MAC addresses of nodes to fetch. (optional) 
            var make = new List<string>(); // List<string> | Make of nodes to fetch. (optional) 
            var maxSeverity = new List<string>(); // List<string> | Max severities of nodes to fetch. (optional) 
            var model = new List<string>(); // List<string> | Models of nodes to fetch. (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modified times of nodes to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of nodes to fetch. (optional) 
            var oid = new List<string>(); // List<string> | Return nodes with the given database object id. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var proxyHost = new List<string>(); // List<string> | Proxy hosts of nodes to fetch. (optional) 
            var proxyPort = new List<string>(); // List<string> | Proxy ports of nodes to fetch. (optional) 
            var realTimeEnabled = true;  // bool? | Real time enabled condition of nodes to fetch. (optional) 
            var rmiHost = new List<string>(); // List<string> | RMI hosts of nodes to fetch. (optional) 
            var rmiPort = new List<string>(); // List<string> | RMI ports of nodes to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Support for like search for description parameter. (optional) 
            var subName = new List<string>(); // List<string> | Support for like search for name parameter. (optional) 
            var tag = new List<string>(); // List<string> | Tags of nodes to fetch. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking IDs of nodes to fetch. (optional) 
            var type = new List<string>(); // List<string> | Node type of nodes to fetch. (optional) 
            var usingSSL = true;  // bool? | Using SSL condition of nodes to fetch. For Oracle: false -> SECURITY_NONE, true -> SECURITY_ANO_ENCRYPTION and SECURITY_SSL. For SQL Server: false -> SSL_OFF, true -> SSL_REQUEST, SSL_REQUIRE and SSL_AUTHENTICATE. (optional) 
            var version = new List<string>(); // List<string> | Versions of nodes to fetch. (optional) 

            try
            {
                // Search nodes (since 1.3)
                Node result = apiInstance.GetNodes(agentVersion, auditEnabled, commonAgentCapabilities, commonAgentOsName, commonAgentOsVersion, commonAgentUuid, commonAgentVersion, customProperty, description, elementCount, eventGeneratorEnabled, eventGeneratorInstalled, hasFailures, icName, id, importedTime, importedTimeRange, ipAddress, isDisabled, isSocksProxy, isSSLSupported, lastCheck, lastRegistration, licensedFeature, macAddress, make, maxSeverity, model, modifiedTime, name, oid, pageLimit, pageStart, proxyHost, proxyPort, realTimeEnabled, rmiHost, rmiPort, subDescription, subName, tag, trackingId, type, usingSSL, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentVersion** | [**List&lt;string&gt;**](string.md)| Agent versions of nodes to fetch. | [optional] 
 **auditEnabled** | **bool?**| Audit enabled condition of nodes to fetch. | [optional] 
 **commonAgentCapabilities** | [**List&lt;string&gt;**](string.md)| Axon agent capabilities of nodes to fetch. | [optional] 
 **commonAgentOsName** | [**List&lt;string&gt;**](string.md)| Axon agent OS names of nodes to fetch. | [optional] 
 **commonAgentOsVersion** | [**List&lt;string&gt;**](string.md)| Axon agent OS versions of nodes to fetch. | [optional] 
 **commonAgentUuid** | [**List&lt;string&gt;**](string.md)| Axon agent uuids of nodes to fetch. | [optional] 
 **commonAgentVersion** | [**List&lt;string&gt;**](string.md)| Axon agent versions of nodes to fetch. | [optional] 
 **customProperty** | [**List&lt;string&gt;**](string.md)| Custom properties values of nodes to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of nodes to fetch. | [optional] 
 **elementCount** | [**List&lt;string&gt;**](string.md)| Element counts of nodes to fetch. | [optional] 
 **eventGeneratorEnabled** | **bool?**| Event generator enabled condition of nodes to fetch. | [optional] 
 **eventGeneratorInstalled** | **bool?**| Event generator installed condition of nodes to fetch. | [optional] 
 **hasFailures** | **bool?**| Has failures condition of nodes to fetch. | [optional] 
 **icName** | [**List&lt;string&gt;**](string.md)| Support for case insensitive search for name parameter. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of nodes to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Imported times of nodes to fetch. | [optional] 
 **importedTimeRange** | **string**| Imported time range of nodes to fetch | [optional] 
 **ipAddress** | [**List&lt;string&gt;**](string.md)| IP addresses of nodes to fetch (only finds agent nodes). | [optional] 
 **isDisabled** | **bool?**| Is disabled condition of nodes to fetch. | [optional] 
 **isSocksProxy** | **bool?**| Is socks proxy condition of nodes to fetch. | [optional] 
 **isSSLSupported** | **bool?**| Is SSL supported condition of nodes to fetch. | [optional] 
 **lastCheck** | [**List&lt;string&gt;**](string.md)| Last checks of nodes to fetch. | [optional] 
 **lastRegistration** | [**List&lt;string&gt;**](string.md)| Last registration dates of nodes to fetch. | [optional] 
 **licensedFeature** | [**List&lt;string&gt;**](string.md)| Licensed features of nodes to fetch. | [optional] 
 **macAddress** | [**List&lt;string&gt;**](string.md)| MAC addresses of nodes to fetch. | [optional] 
 **make** | [**List&lt;string&gt;**](string.md)| Make of nodes to fetch. | [optional] 
 **maxSeverity** | [**List&lt;string&gt;**](string.md)| Max severities of nodes to fetch. | [optional] 
 **model** | [**List&lt;string&gt;**](string.md)| Models of nodes to fetch. | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modified times of nodes to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of nodes to fetch. | [optional] 
 **oid** | [**List&lt;string&gt;**](string.md)| Return nodes with the given database object id. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **proxyHost** | [**List&lt;string&gt;**](string.md)| Proxy hosts of nodes to fetch. | [optional] 
 **proxyPort** | [**List&lt;string&gt;**](string.md)| Proxy ports of nodes to fetch. | [optional] 
 **realTimeEnabled** | **bool?**| Real time enabled condition of nodes to fetch. | [optional] 
 **rmiHost** | [**List&lt;string&gt;**](string.md)| RMI hosts of nodes to fetch. | [optional] 
 **rmiPort** | [**List&lt;string&gt;**](string.md)| RMI ports of nodes to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for like search for description parameter. | [optional] 
 **subName** | [**List&lt;string&gt;**](string.md)| Support for like search for name parameter. | [optional] 
 **tag** | [**List&lt;string&gt;**](string.md)| Tags of nodes to fetch. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking IDs of nodes to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Node type of nodes to fetch. | [optional] 
 **usingSSL** | **bool?**| Using SSL condition of nodes to fetch. For Oracle: false -&gt; SECURITY_NONE, true -&gt; SECURITY_ANO_ENCRYPTION and SECURITY_SSL. For SQL Server: false -&gt; SSL_OFF, true -&gt; SSL_REQUEST, SSL_REQUIRE and SSL_AUTHENTICATE. | [optional] 
 **version** | [**List&lt;string&gt;**](string.md)| Versions of nodes to fetch. | [optional] 

### Return type

[**Node**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulerunrequestbyid"></a>
# **GetRuleRunRequestById**
> RuleRunRequestCommand GetRuleRunRequestById (string requestId)

Get the status of a rule run request (since 1.11)

Returns the status of a rule run request, including the original request details. If ACL failures occur during processing, the status includes the list of nodes the requesting user did not have permission to scan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleRunRequestByIdExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var requestId = requestId_example;  // string | ID of command to fetch

            try
            {
                // Get the status of a rule run request (since 1.11)
                RuleRunRequestCommand result = apiInstance.GetRuleRunRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetRuleRunRequestById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| ID of command to fetch | 

### Return type

[**RuleRunRequestCommand**](RuleRunRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restartnodes"></a>
# **RestartNodes**
> NodeRestartResult RestartNodes (NodeRestart body = null)

Restart Agents to bring them back in sync with the TE Server (since 1.3)

Permissions needed: 'tool.node.load'

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestartNodesExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var body = new NodeRestart(); // NodeRestart | List of IDs of nodes to restart (optional) 

            try
            {
                // Restart Agents to bring them back in sync with the TE Server (since 1.3)
                NodeRestartResult result = apiInstance.RestartNodes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.RestartNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeRestart**](NodeRestart.md)| List of IDs of nodes to restart | [optional] 

### Return type

[**NodeRestartResult**](NodeRestartResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retirenode"></a>
# **RetireNode**
> void RetireNode (string rkNodeId)

Retire a node by removing all node licenses allocated to it (since 1.3)

Permissions needed: 'tool.node.load'

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetireNodeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of node to retire

            try
            {
                // Retire a node by removing all node licenses allocated to it (since 1.3)
                apiInstance.RetireNode(rkNodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.RetireNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of node to retire | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulerunrequest"></a>
# **RuleRunRequest**
> RuleRunRequestCommand RuleRunRequest (RuleRunRequestCommand body)

Run rules on nodes (since 1.11)

Queues a request to run specified set of rules on the given set of nodes. ACL permissions are checked during queue processing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RuleRunRequestExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var body = new RuleRunRequestCommand(); // RuleRunRequestCommand | Rule run creation request to be executed

            try
            {
                // Run rules on nodes (since 1.11)
                RuleRunRequestCommand result = apiInstance.RuleRunRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.RuleRunRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RuleRunRequestCommand**](RuleRunRequestCommand.md)| Rule run creation request to be executed | 

### Return type

[**RuleRunRequestCommand**](RuleRunRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setnodecustomproperty"></a>
# **SetNodeCustomProperty**
> void SetNodeCustomProperty (string rkNodeId, string propertyName, PropertyValue body)

Set a custom property value for a node (since 1.5)

Assign a custom property value to a node. The value must meet the requirements of the specific custom property type. If a the custom property type is already assigned to the node, this will overwrite the existing value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetNodeCustomPropertyExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | Id of the node.
            var propertyName = propertyName_example;  // string | Name of the node custom property type to assign to the node.
            var body = new PropertyValue(); // PropertyValue | Value to assign to the custom property of the node.

            try
            {
                // Set a custom property value for a node (since 1.5)
                apiInstance.SetNodeCustomProperty(rkNodeId, propertyName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.SetNodeCustomProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| Id of the node. | 
 **propertyName** | **string**| Name of the node custom property type to assign to the node. | 
 **body** | [**PropertyValue**](PropertyValue.md)| Value to assign to the custom property of the node. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregistercommonagent"></a>
# **UnregisterCommonAgent**
> void UnregisterCommonAgent (string rkNodeId)

Unregister an Axon agent from the server node (since 1.4)

Clears all Axon agent registration data attached to the server node. All subsequent usage of the node will attempt to interact with the Java based agent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnregisterCommonAgentExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of the node

            try
            {
                // Unregister an Axon agent from the server node (since 1.4)
                apiInstance.UnregisterCommonAgent(rkNodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.UnregisterCommonAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of the node | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustompropertytype"></a>
# **UpdateCustomPropertyType**
> CustomPropertyType UpdateCustomPropertyType (CustomPropertyType body, string rkCustomPropertyTypeId)

Update an existing node custom property type (since 1.6)

Modifies a node custom property type to update the submitted fields with new values. The 'id' and 'type' fields can not be updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCustomPropertyTypeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var body = new CustomPropertyType(); // CustomPropertyType | Custom property type to be updated
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Id of custom property type to update

            try
            {
                // Update an existing node custom property type (since 1.6)
                CustomPropertyType result = apiInstance.UpdateCustomPropertyType(body, rkCustomPropertyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.UpdateCustomPropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomPropertyType**](CustomPropertyType.md)| Custom property type to be updated | 
 **rkCustomPropertyTypeId** | **string**| Id of custom property type to update | 

### Return type

[**CustomPropertyType**](CustomPropertyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenode"></a>
# **UpdateNode**
> Node UpdateNode (string rkNodeId, Node body)

Update a node (since 1.4)

Modifies a node updating the provided fields with new values. Read-only fields are ignored.<br />Licenses are restricted by node type, and can be applied as follows:<br /> * Agents:    * FSI    * FSI-Policy    * FSI-Remediation  * Database Servers:   * DBI   * DBI-Policy * Directory Servers:   * DSI   * DSI-Policy * Network Devices:   * TWRouter   * TWRouter-Policy * VMWare:   * VMWare-ESX   * VMWare-ESX-Policy <br /><br /> See endpoint GET /api/v1/settings/licenses for a listing of feature names to product display names.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateNodeExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var rkNodeId = rkNodeId_example;  // string | ID of node to be updated
            var body = new Node(); // Node | Node description to update the existing node

            try
            {
                // Update a node (since 1.4)
                Node result = apiInstance.UpdateNode(rkNodeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.UpdateNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkNodeId** | **string**| ID of node to be updated | 
 **body** | [**Node**](Node.md)| Node description to update the existing node | 

### Return type

[**Node**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

