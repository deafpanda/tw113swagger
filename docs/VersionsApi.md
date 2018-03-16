# IO.Swagger.Api.VersionsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomPropertyType**](VersionsApi.md#createcustompropertytype) | **POST** /versions/customPropertyTypes | Create an element version custom property definition (since 1.9)
[**CreateVersionRequest**](VersionsApi.md#createversionrequest) | **POST** /versions/createVersionRequests | Request processing submitted change events for External Rules (since 1.5)
[**DeleteCustomPropertyType**](VersionsApi.md#deletecustompropertytype) | **DELETE** /versions/customPropertyTypes/{rkCustomPropertyTypeId} | Delete a custom property type (since 1.9)
[**DeleteElementVersion**](VersionsApi.md#deleteelementversion) | **DELETE** /versions/{rkVersionId} | Delete a single element version (since 1.6)
[**DeleteElementVersionCustomProperty**](VersionsApi.md#deleteelementversioncustomproperty) | **DELETE** /versions/{rkVersionId}/customProperties/{propertyName} | Delete a custom property value from an element version (since 1.9)
[**GetAuditDataByReadableKeyVersionId**](VersionsApi.md#getauditdatabyreadablekeyversionid) | **GET** /versions/{rkVersionId}/audit | Get audit event data for an element version (since 1.0)
[**GetCreateVersionRequestById**](VersionsApi.md#getcreateversionrequestbyid) | **GET** /versions/createVersionRequests/{requestId} | Get updated state of element version change requests (since 1.5)
[**GetCustomProperties**](VersionsApi.md#getcustomproperties) | **GET** /versions/{rkVersionId}/customProperties | Get custom property values for an element version (since 1.9)
[**GetCustomPropertyTypeById**](VersionsApi.md#getcustompropertytypebyid) | **GET** /versions/customPropertyTypes/{rkCustomPropertyTypeId} | Get a custom property type (since 1.9)
[**GetCustomPropertyTypes**](VersionsApi.md#getcustompropertytypes) | **GET** /versions/customPropertyTypes | Search custom property types (since 1.9)
[**GetElementVersionAttributes**](VersionsApi.md#getelementversionattributes) | **GET** /versions/{rkVersionId}/attributes | Get element version attributes by ID (since 1.5)
[**GetElementVersionContent**](VersionsApi.md#getelementversioncontent) | **GET** /versions/{rkVersionId}/content | Get element version content by ID (since 1.5)
[**GetElementVersionDetailsById**](VersionsApi.md#getelementversiondetailsbyid) | **GET** /versions/{rkVersionId} | Get element version details by ID (since 1.5)
[**GetElementVersionsExtract**](VersionsApi.md#getelementversionsextract) | **GET** /versions/_extract | Extract large sets of element versions incrementally (since 1.7)
[**GetHistoricalElementVersions**](VersionsApi.md#gethistoricalelementversions) | **GET** /versions | Search all element versions (since 1.5)
[**GetLatestElementVersions**](VersionsApi.md#getlatestelementversions) | **GET** /versions/latest | Search for latest element versions only (since 1.5)
[**GetPromoteRequestById**](VersionsApi.md#getpromoterequestbyid) | **GET** /versions/promoteRequests/{requestId} | Get promote request status (since 1.11)
[**PromoteRequest**](VersionsApi.md#promoterequest) | **POST** /versions/promoteRequests | Request promotion of a set of element versions (since 1.11)
[**SetElementVersionCustomProperty**](VersionsApi.md#setelementversioncustomproperty) | **POST** /versions/{rkVersionId}/customProperties/{propertyName} | Set a custom property value for an element version (since 1.9)
[**UpdateCustomPropertyType**](VersionsApi.md#updatecustompropertytype) | **PUT** /versions/customPropertyTypes/{rkCustomPropertyTypeId} | Update an existing element version custom property type (since 1.9)
[**UpdateElementVersion**](VersionsApi.md#updateelementversion) | **PUT** /versions/{rkVersionId} | Put an update to an element version (since 1.7)


<a name="createcustompropertytype"></a>
# **CreateCustomPropertyType**
> CustomPropertyType CreateCustomPropertyType (CustomPropertyType body)

Create an element version custom property definition (since 1.9)

Allows creating models for custom meta-data that can be later applied to element versions.

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
            var apiInstance = new VersionsApi();
            var body = new CustomPropertyType(); // CustomPropertyType | Custom property type to be created

            try
            {
                // Create an element version custom property definition (since 1.9)
                CustomPropertyType result = apiInstance.CreateCustomPropertyType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.CreateCustomPropertyType: " + e.Message );
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

<a name="createversionrequest"></a>
# **CreateVersionRequest**
> CreateVersionRequest CreateVersionRequest (CreateVersionRequest body)

Request processing submitted change events for External Rules (since 1.5)

Queues the processing of change events for a Node and External Rule. Changes are processed by any actions and policy tests that are scoped appropriately. Processing is asynchronous. The request will return to the caller once the input has been validated. The result can be queried at /api/v1/versions/changeRequests/{rkChangeRequestId}. Version descriptions with the exists field set or defaulting to true must have one of the MD5, SHA-1, SHA-256 or SHA-512 hash attributes set. If no hash attribute is set, an MD5 hash will be computed for you based on the value of the content field, including when the content field is empty, null, or unspecified. When the exists field is set to false, then content and attributes fields must not be specified. Data submitted by the TE REST API is subject to XSS filtering. To provide literal value for the content of an element version, base64 encode the data, and submit that in the 'contentBase64' field instead of the 'content' field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateVersionRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var body = new CreateVersionRequest(); // CreateVersionRequest | Version creation request to be executed

            try
            {
                // Request processing submitted change events for External Rules (since 1.5)
                CreateVersionRequest result = apiInstance.CreateVersionRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.CreateVersionRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateVersionRequest**](CreateVersionRequest.md)| Version creation request to be executed | 

### Return type

[**CreateVersionRequest**](CreateVersionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustompropertytype"></a>
# **DeleteCustomPropertyType**
> void DeleteCustomPropertyType (string rkCustomPropertyTypeId)

Delete a custom property type (since 1.9)

Delete an existing version custom property type

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
            var apiInstance = new VersionsApi();
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Removes a version custom property type, and the value assignments to all versions

            try
            {
                // Delete a custom property type (since 1.9)
                apiInstance.DeleteCustomPropertyType(rkCustomPropertyTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.DeleteCustomPropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkCustomPropertyTypeId** | **string**| Removes a version custom property type, and the value assignments to all versions | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteelementversion"></a>
# **DeleteElementVersion**
> void DeleteElementVersion (string rkVersionId)

Delete a single element version (since 1.6)

Removes an element version from the TE history. It will not delete the Baseline version referenced by existing change versions, so deletion would typically be performed newest to oldest, however selective deletions are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteElementVersionExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | ID of Element Version to fetch

            try
            {
                // Delete a single element version (since 1.6)
                apiInstance.DeleteElementVersion(rkVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.DeleteElementVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| ID of Element Version to fetch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteelementversioncustomproperty"></a>
# **DeleteElementVersionCustomProperty**
> void DeleteElementVersionCustomProperty (string rkVersionId, string propertyName)

Delete a custom property value from an element version (since 1.9)

Removes the custom property assignment from the element version. If the custom property type is configured to inherit default values, then the default for that custom property type will become active on the element version. Inherited custom property values cannot be deleted and attempts to do so will result in a 404.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteElementVersionCustomPropertyExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | Id of the element version
            var propertyName = propertyName_example;  // string | Name of the element version custom property type to unassign from the version.

            try
            {
                // Delete a custom property value from an element version (since 1.9)
                apiInstance.DeleteElementVersionCustomProperty(rkVersionId, propertyName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.DeleteElementVersionCustomProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| Id of the element version | 
 **propertyName** | **string**| Name of the element version custom property type to unassign from the version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauditdatabyreadablekeyversionid"></a>
# **GetAuditDataByReadableKeyVersionId**
> AuditInfo GetAuditDataByReadableKeyVersionId (string rkVersionId)

Get audit event data for an element version (since 1.0)

Lists all associated audit data in the form of the usernames and process names that correspond to an element version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuditDataByReadableKeyVersionIdExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | rkVersionId to fetch

            try
            {
                // Get audit event data for an element version (since 1.0)
                AuditInfo result = apiInstance.GetAuditDataByReadableKeyVersionId(rkVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetAuditDataByReadableKeyVersionId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| rkVersionId to fetch | 

### Return type

[**AuditInfo**](AuditInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreateversionrequestbyid"></a>
# **GetCreateVersionRequestById**
> CreateVersionRequest GetCreateVersionRequestById (string requestId)

Get updated state of element version change requests (since 1.5)

Returns the element version change request with current status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreateVersionRequestByIdExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var requestId = requestId_example;  // string | ID of command to fetch

            try
            {
                // Get updated state of element version change requests (since 1.5)
                CreateVersionRequest result = apiInstance.GetCreateVersionRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetCreateVersionRequestById: " + e.Message );
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

[**CreateVersionRequest**](CreateVersionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomproperties"></a>
# **GetCustomProperties**
> CustomProperties GetCustomProperties (string rkVersionId)

Get custom property values for an element version (since 1.9)

Return the map of custom property names and their assigned value, either assigned directly to an element version, or inherited by default.

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
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | ID of element version to fetch

            try
            {
                // Get custom property values for an element version (since 1.9)
                CustomProperties result = apiInstance.GetCustomProperties(rkVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetCustomProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| ID of element version to fetch | 

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

Get a custom property type (since 1.9)

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
            var apiInstance = new VersionsApi();
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Id of custom property type to fetch

            try
            {
                // Get a custom property type (since 1.9)
                CustomPropertyType result = apiInstance.GetCustomPropertyTypeById(rkCustomPropertyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetCustomPropertyTypeById: " + e.Message );
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

Search custom property types (since 1.9)

Returns all custom property type definitions that can be applied to an element version, or those that meet the filter criteria.

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
            var apiInstance = new VersionsApi();
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
                // Search custom property types (since 1.9)
                CustomPropertyType result = apiInstance.GetCustomPropertyTypes(allowMultilineValues, availableValues, defaultValue, description, id, inheritDefault, maxCharacters, maxValue, minValue, name, subDescription, textEditorWidth, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetCustomPropertyTypes: " + e.Message );
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

<a name="getelementversionattributes"></a>
# **GetElementVersionAttributes**
> ValueTypeAttribute GetElementVersionAttributes (string rkVersionId)

Get element version attributes by ID (since 1.5)

Returns the attributes map for an element version with a specific ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetElementVersionAttributesExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | ID of element version attributes to fetch

            try
            {
                // Get element version attributes by ID (since 1.5)
                ValueTypeAttribute result = apiInstance.GetElementVersionAttributes(rkVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetElementVersionAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| ID of element version attributes to fetch | 

### Return type

[**ValueTypeAttribute**](ValueTypeAttribute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getelementversioncontent"></a>
# **GetElementVersionContent**
> string GetElementVersionContent (string rkVersionId, string sizeLimit = null)

Get element version content by ID (since 1.5)

Returns the archived content data for the given element version. Binary content is not supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetElementVersionContentExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | ID of element version details to fetch
            var sizeLimit = sizeLimit_example;  // string | Fail if content size exceeds this limit of size in bytes. (optional) 

            try
            {
                // Get element version content by ID (since 1.5)
                string result = apiInstance.GetElementVersionContent(rkVersionId, sizeLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetElementVersionContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| ID of element version details to fetch | 
 **sizeLimit** | **string**| Fail if content size exceeds this limit of size in bytes. | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getelementversiondetailsbyid"></a>
# **GetElementVersionDetailsById**
> ElementVersion GetElementVersionDetailsById (string rkVersionId)

Get element version details by ID (since 1.5)

Returns an element version with a specific ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetElementVersionDetailsByIdExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | ID of element version details to fetch

            try
            {
                // Get element version details by ID (since 1.5)
                ElementVersion result = apiInstance.GetElementVersionDetailsById(rkVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetElementVersionDetailsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| ID of element version details to fetch | 

### Return type

[**ElementVersion**](ElementVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getelementversionsextract"></a>
# **GetElementVersionsExtract**
> ElementVersionWithAttributes GetElementVersionsExtract (string pageLimit = null, string previousId = null, List<string> scanId = null, string timeDetectedRange = null, string timeReceivedRange = null)

Extract large sets of element versions incrementally (since 1.7)

Search for element versions by time ranges. Time received is a valid for element versions created after TE 8.5.0. However it may be null in the database for element versions in the  prior to that. Time detected can be used for legacy element versions prior to the existence of time Received. Results will be sorted by the element version id, in ascending order. One of timeDetectedRange or timeReceivedRange must be specified.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetElementVersionsExtractExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var pageLimit = pageLimit_example;  // string | The maximum number of element versions to return per request. (optional) 
            var previousId = previousId_example;  // string | When paging, this should be the last element version id returned by the previous page (optional) 
            var scanId = new List<string>(); // List<string> | Scan IDs of elements versions to fetch. (optional) 
            var timeDetectedRange = timeDetectedRange_example;  // string | Time detected range of element versions to fetch. (optional) 
            var timeReceivedRange = timeReceivedRange_example;  // string | Time received range of element versions to fetch. (optional) 

            try
            {
                // Extract large sets of element versions incrementally (since 1.7)
                ElementVersionWithAttributes result = apiInstance.GetElementVersionsExtract(pageLimit, previousId, scanId, timeDetectedRange, timeReceivedRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetElementVersionsExtract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageLimit** | **string**| The maximum number of element versions to return per request. | [optional] 
 **previousId** | **string**| When paging, this should be the last element version id returned by the previous page | [optional] 
 **scanId** | [**List&lt;string&gt;**](string.md)| Scan IDs of elements versions to fetch. | [optional] 
 **timeDetectedRange** | **string**| Time detected range of element versions to fetch. | [optional] 
 **timeReceivedRange** | **string**| Time received range of element versions to fetch. | [optional] 

### Return type

[**ElementVersionWithAttributes**](ElementVersionWithAttributes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricalelementversions"></a>
# **GetHistoricalElementVersions**
> ElementVersion GetHistoricalElementVersions (List<string> approvalId = null, string at = null, List<string> baselineVersion = null, List<string> changeType = null, List<string> elementId = null, List<string> elementName = null, bool? exists = null, List<string> hash = null, List<string> id = null, bool? isPromoted = null, List<string> md5 = null, List<string> nodeId = null, List<string> nodeLabel = null, bool? outsideMaintenanceWindow = null, string pageLimit = null, string pageStart = null, List<string> promotionComment = null, List<string> ruleId = null, List<string> ruleName = null, List<string> scanId = null, List<string> severity = null, string severityRange = null, List<string> sha1 = null, List<string> sha256 = null, List<string> sha512 = null, List<string> timeDetected = null, string timeDetectedRange = null, List<string> timeReceived = null, string timeReceivedRange = null)

Search all element versions (since 1.5)

Returns all Element Versions that meet the search critiera. This can be used to include historical Element Versions. Element Versions for Nodes that the user does not have access to will be omitted from the search results. The 'at' and 'timeDetectedRange' filters are mutually exclusive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricalElementVersionsExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var approvalId = new List<string>(); // List<string> | Approval IDs of elements versions to fetch. (optional) 
            var at = at_example;  // string | Include the latest element versions that are at or prior to the specified time. (optional) 
            var baselineVersion = new List<string>(); // List<string> | Last baseline versions of elements versions to fetch. (optional) 
            var changeType = new List<string>(); // List<string> | Change types of elements versions to fetch. (optional) 
            var elementId = new List<string>(); // List<string> | Elements IDs of elements versions to fetch. (optional) 
            var elementName = new List<string>(); // List<string> | Element names of elements versions to fetch. (optional) 
            var exists = true;  // bool? | Exists condition of elements versions to fetch. (optional) 
            var hash = new List<string>(); // List<string> | Possible Hashes value (md5, sha1, sha256, sha512) of elements versions to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of element versions to fetch. (optional) 
            var isPromoted = true;  // bool? | True if the element version has been promoted. (optional) 
            var md5 = new List<string>(); // List<string> | MD5 hashes of elements versions to fetch. (optional) 
            var nodeId = new List<string>(); // List<string> | Nodes IDs of elements versions to fetch. (optional) 
            var nodeLabel = new List<string>(); // List<string> | Nodes names of elements versions to fetch. (optional) 
            var outsideMaintenanceWindow = true;  // bool? | Outside maintenance window condition of elements versions to fetch. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var promotionComment = new List<string>(); // List<string> | Promotion comments of elements versions to fetch. (optional) 
            var ruleId = new List<string>(); // List<string> | Rules IDs of elements versions to fetch. (optional) 
            var ruleName = new List<string>(); // List<string> | Rules names of elements versions to fetch. (optional) 
            var scanId = new List<string>(); // List<string> | Scan IDs of elements versions to fetch. (optional) 
            var severity = new List<string>(); // List<string> | Severities of elements versions to fetch. (optional) 
            var severityRange = severityRange_example;  // string | Filter for element versions with severity in the comma separated range of values, inclusively (optional) 
            var sha1 = new List<string>(); // List<string> | SHA1 hashes of elements versions to fetch. (optional) 
            var sha256 = new List<string>(); // List<string> | SHA256 hashes of elements versions to fetch. (optional) 
            var sha512 = new List<string>(); // List<string> | SHA512 hashes of elements versions to fetch. (optional) 
            var timeDetected = new List<string>(); // List<string> | Times detected of elements versions to fetch. (optional) 
            var timeDetectedRange = timeDetectedRange_example;  // string | Time detected range of element versions to fetch. (optional) 
            var timeReceived = new List<string>(); // List<string> | Times received of elements versions to fetch. (optional) 
            var timeReceivedRange = timeReceivedRange_example;  // string | Time received range of element versions to fetch. (optional) 

            try
            {
                // Search all element versions (since 1.5)
                ElementVersion result = apiInstance.GetHistoricalElementVersions(approvalId, at, baselineVersion, changeType, elementId, elementName, exists, hash, id, isPromoted, md5, nodeId, nodeLabel, outsideMaintenanceWindow, pageLimit, pageStart, promotionComment, ruleId, ruleName, scanId, severity, severityRange, sha1, sha256, sha512, timeDetected, timeDetectedRange, timeReceived, timeReceivedRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetHistoricalElementVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approvalId** | [**List&lt;string&gt;**](string.md)| Approval IDs of elements versions to fetch. | [optional] 
 **at** | **string**| Include the latest element versions that are at or prior to the specified time. | [optional] 
 **baselineVersion** | [**List&lt;string&gt;**](string.md)| Last baseline versions of elements versions to fetch. | [optional] 
 **changeType** | [**List&lt;string&gt;**](string.md)| Change types of elements versions to fetch. | [optional] 
 **elementId** | [**List&lt;string&gt;**](string.md)| Elements IDs of elements versions to fetch. | [optional] 
 **elementName** | [**List&lt;string&gt;**](string.md)| Element names of elements versions to fetch. | [optional] 
 **exists** | **bool?**| Exists condition of elements versions to fetch. | [optional] 
 **hash** | [**List&lt;string&gt;**](string.md)| Possible Hashes value (md5, sha1, sha256, sha512) of elements versions to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of element versions to fetch. | [optional] 
 **isPromoted** | **bool?**| True if the element version has been promoted. | [optional] 
 **md5** | [**List&lt;string&gt;**](string.md)| MD5 hashes of elements versions to fetch. | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Nodes IDs of elements versions to fetch. | [optional] 
 **nodeLabel** | [**List&lt;string&gt;**](string.md)| Nodes names of elements versions to fetch. | [optional] 
 **outsideMaintenanceWindow** | **bool?**| Outside maintenance window condition of elements versions to fetch. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **promotionComment** | [**List&lt;string&gt;**](string.md)| Promotion comments of elements versions to fetch. | [optional] 
 **ruleId** | [**List&lt;string&gt;**](string.md)| Rules IDs of elements versions to fetch. | [optional] 
 **ruleName** | [**List&lt;string&gt;**](string.md)| Rules names of elements versions to fetch. | [optional] 
 **scanId** | [**List&lt;string&gt;**](string.md)| Scan IDs of elements versions to fetch. | [optional] 
 **severity** | [**List&lt;string&gt;**](string.md)| Severities of elements versions to fetch. | [optional] 
 **severityRange** | **string**| Filter for element versions with severity in the comma separated range of values, inclusively | [optional] 
 **sha1** | [**List&lt;string&gt;**](string.md)| SHA1 hashes of elements versions to fetch. | [optional] 
 **sha256** | [**List&lt;string&gt;**](string.md)| SHA256 hashes of elements versions to fetch. | [optional] 
 **sha512** | [**List&lt;string&gt;**](string.md)| SHA512 hashes of elements versions to fetch. | [optional] 
 **timeDetected** | [**List&lt;string&gt;**](string.md)| Times detected of elements versions to fetch. | [optional] 
 **timeDetectedRange** | **string**| Time detected range of element versions to fetch. | [optional] 
 **timeReceived** | [**List&lt;string&gt;**](string.md)| Times received of elements versions to fetch. | [optional] 
 **timeReceivedRange** | **string**| Time received range of element versions to fetch. | [optional] 

### Return type

[**ElementVersion**](ElementVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatestelementversions"></a>
# **GetLatestElementVersions**
> ElementVersion GetLatestElementVersions (List<string> approvalId = null, List<string> baselineVersion = null, List<string> changeType = null, List<string> elementId = null, List<string> elementName = null, bool? exists = null, List<string> hash = null, List<string> id = null, bool? isPromoted = null, List<string> md5 = null, List<string> nodeId = null, List<string> nodeLabel = null, bool? outsideMaintenanceWindow = null, string pageLimit = null, string pageStart = null, List<string> promotionComment = null, List<string> ruleId = null, List<string> ruleName = null, List<string> scanId = null, List<string> severity = null, string severityRange = null, List<string> sha1 = null, List<string> sha256 = null, List<string> sha512 = null, List<string> timeDetected = null, string timeDetectedRange = null, List<string> timeReceived = null, string timeReceivedRange = null)

Search for latest element versions only (since 1.5)

Returns only the most recent element version for each element that matches the search criteria. Element versions for nodes that the user does not have access to will be omitted from the search results.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLatestElementVersionsExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var approvalId = new List<string>(); // List<string> | Approval IDs of elements versions to fetch. (optional) 
            var baselineVersion = new List<string>(); // List<string> | Last baseline versions of elements versions to fetch. (optional) 
            var changeType = new List<string>(); // List<string> | Change types of elements versions to fetch. (optional) 
            var elementId = new List<string>(); // List<string> | Elements IDs of elements versions to fetch. (optional) 
            var elementName = new List<string>(); // List<string> | Element names of elements versions to fetch. (optional) 
            var exists = true;  // bool? | Exists condition of elements versions to fetch. (optional) 
            var hash = new List<string>(); // List<string> | Possible Hashes value (md5, sha1, sha256, sha512) of elements versions to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of element versions to fetch. (optional) 
            var isPromoted = true;  // bool? | True if the element version has been promoted. (optional) 
            var md5 = new List<string>(); // List<string> | MD5 hashes of elements versions to fetch. (optional) 
            var nodeId = new List<string>(); // List<string> | Nodes IDs of elements versions to fetch. (optional) 
            var nodeLabel = new List<string>(); // List<string> | Nodes names of elements versions to fetch. (optional) 
            var outsideMaintenanceWindow = true;  // bool? | Outside maintenance window condition of elements versions to fetch. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var promotionComment = new List<string>(); // List<string> | Promotion comments of elements versions to fetch. (optional) 
            var ruleId = new List<string>(); // List<string> | Rules IDs of elements versions to fetch. (optional) 
            var ruleName = new List<string>(); // List<string> | Rules names of elements versions to fetch. (optional) 
            var scanId = new List<string>(); // List<string> | Scan IDs of elements versions to fetch. (optional) 
            var severity = new List<string>(); // List<string> | Severities of elements versions to fetch. (optional) 
            var severityRange = severityRange_example;  // string | Filter for element versions with severity in the comma separated range of values, inclusively (optional) 
            var sha1 = new List<string>(); // List<string> | SHA1 hashes of elements versions to fetch. (optional) 
            var sha256 = new List<string>(); // List<string> | SHA256 hashes of elements versions to fetch. (optional) 
            var sha512 = new List<string>(); // List<string> | SHA512 hashes of elements versions to fetch. (optional) 
            var timeDetected = new List<string>(); // List<string> | Times detected of elements versions to fetch. (optional) 
            var timeDetectedRange = timeDetectedRange_example;  // string | Time detected range of element versions to fetch. (optional) 
            var timeReceived = new List<string>(); // List<string> | Times received of elements versions to fetch. (optional) 
            var timeReceivedRange = timeReceivedRange_example;  // string | Time received range of element versions to fetch. (optional) 

            try
            {
                // Search for latest element versions only (since 1.5)
                ElementVersion result = apiInstance.GetLatestElementVersions(approvalId, baselineVersion, changeType, elementId, elementName, exists, hash, id, isPromoted, md5, nodeId, nodeLabel, outsideMaintenanceWindow, pageLimit, pageStart, promotionComment, ruleId, ruleName, scanId, severity, severityRange, sha1, sha256, sha512, timeDetected, timeDetectedRange, timeReceived, timeReceivedRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetLatestElementVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approvalId** | [**List&lt;string&gt;**](string.md)| Approval IDs of elements versions to fetch. | [optional] 
 **baselineVersion** | [**List&lt;string&gt;**](string.md)| Last baseline versions of elements versions to fetch. | [optional] 
 **changeType** | [**List&lt;string&gt;**](string.md)| Change types of elements versions to fetch. | [optional] 
 **elementId** | [**List&lt;string&gt;**](string.md)| Elements IDs of elements versions to fetch. | [optional] 
 **elementName** | [**List&lt;string&gt;**](string.md)| Element names of elements versions to fetch. | [optional] 
 **exists** | **bool?**| Exists condition of elements versions to fetch. | [optional] 
 **hash** | [**List&lt;string&gt;**](string.md)| Possible Hashes value (md5, sha1, sha256, sha512) of elements versions to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of element versions to fetch. | [optional] 
 **isPromoted** | **bool?**| True if the element version has been promoted. | [optional] 
 **md5** | [**List&lt;string&gt;**](string.md)| MD5 hashes of elements versions to fetch. | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Nodes IDs of elements versions to fetch. | [optional] 
 **nodeLabel** | [**List&lt;string&gt;**](string.md)| Nodes names of elements versions to fetch. | [optional] 
 **outsideMaintenanceWindow** | **bool?**| Outside maintenance window condition of elements versions to fetch. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **promotionComment** | [**List&lt;string&gt;**](string.md)| Promotion comments of elements versions to fetch. | [optional] 
 **ruleId** | [**List&lt;string&gt;**](string.md)| Rules IDs of elements versions to fetch. | [optional] 
 **ruleName** | [**List&lt;string&gt;**](string.md)| Rules names of elements versions to fetch. | [optional] 
 **scanId** | [**List&lt;string&gt;**](string.md)| Scan IDs of elements versions to fetch. | [optional] 
 **severity** | [**List&lt;string&gt;**](string.md)| Severities of elements versions to fetch. | [optional] 
 **severityRange** | **string**| Filter for element versions with severity in the comma separated range of values, inclusively | [optional] 
 **sha1** | [**List&lt;string&gt;**](string.md)| SHA1 hashes of elements versions to fetch. | [optional] 
 **sha256** | [**List&lt;string&gt;**](string.md)| SHA256 hashes of elements versions to fetch. | [optional] 
 **sha512** | [**List&lt;string&gt;**](string.md)| SHA512 hashes of elements versions to fetch. | [optional] 
 **timeDetected** | [**List&lt;string&gt;**](string.md)| Times detected of elements versions to fetch. | [optional] 
 **timeDetectedRange** | **string**| Time detected range of element versions to fetch. | [optional] 
 **timeReceived** | [**List&lt;string&gt;**](string.md)| Times received of elements versions to fetch. | [optional] 
 **timeReceivedRange** | **string**| Time received range of element versions to fetch. | [optional] 

### Return type

[**ElementVersion**](ElementVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpromoterequestbyid"></a>
# **GetPromoteRequestById**
> PromoteRequestCommand GetPromoteRequestById (string requestId)

Get promote request status (since 1.11)

Returns the promote versions request along with the completion status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPromoteRequestByIdExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var requestId = requestId_example;  // string | ID of command to fetch

            try
            {
                // Get promote request status (since 1.11)
                PromoteRequestCommand result = apiInstance.GetPromoteRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetPromoteRequestById: " + e.Message );
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

[**PromoteRequestCommand**](PromoteRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="promoterequest"></a>
# **PromoteRequest**
> PromoteRequestCommand PromoteRequest (PromoteRequestCommand body)

Request promotion of a set of element versions (since 1.11)

Creates an asynchronous command to queue promotion of element versions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PromoteRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var body = new PromoteRequestCommand(); // PromoteRequestCommand | Version creation request to be executed

            try
            {
                // Request promotion of a set of element versions (since 1.11)
                PromoteRequestCommand result = apiInstance.PromoteRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.PromoteRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PromoteRequestCommand**](PromoteRequestCommand.md)| Version creation request to be executed | 

### Return type

[**PromoteRequestCommand**](PromoteRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setelementversioncustomproperty"></a>
# **SetElementVersionCustomProperty**
> void SetElementVersionCustomProperty (string rkVersionId, string propertyName, PropertyValue body)

Set a custom property value for an element version (since 1.9)

Assign a custom property value to an element version. The value must meet the requirements of the specific custom property type. If a the custom property type is already assigned to the element version, this will overwrite the existing value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetElementVersionCustomPropertyExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | Id of the element version.
            var propertyName = propertyName_example;  // string | Name of the custom property type to assign to the element version.
            var body = new PropertyValue(); // PropertyValue | Value to assign to the custom property of the element version.

            try
            {
                // Set a custom property value for an element version (since 1.9)
                apiInstance.SetElementVersionCustomProperty(rkVersionId, propertyName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.SetElementVersionCustomProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| Id of the element version. | 
 **propertyName** | **string**| Name of the custom property type to assign to the element version. | 
 **body** | [**PropertyValue**](PropertyValue.md)| Value to assign to the custom property of the element version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustompropertytype"></a>
# **UpdateCustomPropertyType**
> CustomPropertyType UpdateCustomPropertyType (CustomPropertyType body, string rkCustomPropertyTypeId)

Update an existing element version custom property type (since 1.9)

Modifies an element custom property type to update the submitted fields with new values. The 'id' and 'type' fields can not be updated.

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
            var apiInstance = new VersionsApi();
            var body = new CustomPropertyType(); // CustomPropertyType | Custom property type to be updated
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Id of custom property type to update

            try
            {
                // Update an existing element version custom property type (since 1.9)
                CustomPropertyType result = apiInstance.UpdateCustomPropertyType(body, rkCustomPropertyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.UpdateCustomPropertyType: " + e.Message );
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

<a name="updateelementversion"></a>
# **UpdateElementVersion**
> ElementVersion UpdateElementVersion (string rkVersionId, ElementVersionSeverity body)

Put an update to an element version (since 1.7)

Modifies the specified element version with a new severity value. Only the severity field is modifiable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateElementVersionExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var rkVersionId = rkVersionId_example;  // string | Id of the element version to modify
            var body = new ElementVersionSeverity(); // ElementVersionSeverity | Element version description to update the existing element version.

            try
            {
                // Put an update to an element version (since 1.7)
                ElementVersion result = apiInstance.UpdateElementVersion(rkVersionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.UpdateElementVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkVersionId** | **string**| Id of the element version to modify | 
 **body** | [**ElementVersionSeverity**](ElementVersionSeverity.md)| Element version description to update the existing element version. | 

### Return type

[**ElementVersion**](ElementVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

