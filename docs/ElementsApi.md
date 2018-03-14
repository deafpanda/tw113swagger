# IO.Swagger.Api.ElementsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomPropertyType**](ElementsApi.md#createcustompropertytype) | **POST** /elements/customPropertyTypes | Create an element custom property definition (since 1.8)
[**DeleteCustomPropertyType**](ElementsApi.md#deletecustompropertytype) | **DELETE** /elements/customPropertyTypes/{rkCustomPropertyTypeId} | Delete a custom property type (since 1.8)
[**DeleteElement**](ElementsApi.md#deleteelement) | **DELETE** /elements/{rkElementId} | Delete an element (since 1.11)
[**DeleteElementCustomProperty**](ElementsApi.md#deleteelementcustomproperty) | **DELETE** /elements/{rkElementId}/customProperties/{propertyName} | Delete a custom property value from an element (since 1.9)
[**GetCustomProperties**](ElementsApi.md#getcustomproperties) | **GET** /elements/{rkElementId}/customProperties | Get custom property values for an element (since 1.8)
[**GetCustomPropertyTypeById**](ElementsApi.md#getcustompropertytypebyid) | **GET** /elements/customPropertyTypes/{rkCustomPropertyTypeId} | Get a custom property type (since 1.8)
[**GetCustomPropertyTypes**](ElementsApi.md#getcustompropertytypes) | **GET** /elements/customPropertyTypes | Search custom property types (since 1.8)
[**GetElements**](ElementsApi.md#getelements) | **GET** /elements | Get elements (since 1.8)
[**SetElementCustomProperty**](ElementsApi.md#setelementcustomproperty) | **POST** /elements/{rkElementId}/customProperties/{propertyName} | Set a custom property value for an element (since 1.8)
[**UpdateCustomPropertyType**](ElementsApi.md#updatecustompropertytype) | **PUT** /elements/customPropertyTypes/{rkCustomPropertyTypeId} | Modifies an existing element custom property type (since 1.8)


<a name="createcustompropertytype"></a>
# **CreateCustomPropertyType**
> CustomPropertyType CreateCustomPropertyType (CustomPropertyType body)

Create an element custom property definition (since 1.8)

Allows creating models for custom meta-data that can be later applied to elements.

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
            var apiInstance = new ElementsApi();
            var body = new CustomPropertyType(); // CustomPropertyType | Custom property type to be created

            try
            {
                // Create an element custom property definition (since 1.8)
                CustomPropertyType result = apiInstance.CreateCustomPropertyType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.CreateCustomPropertyType: " + e.Message );
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

<a name="deletecustompropertytype"></a>
# **DeleteCustomPropertyType**
> void DeleteCustomPropertyType (string rkCustomPropertyTypeId)

Delete a custom property type (since 1.8)

Delete an existing element custom property type

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
            var apiInstance = new ElementsApi();
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Removes an element custom property type, and the value assignments to all elements

            try
            {
                // Delete a custom property type (since 1.8)
                apiInstance.DeleteCustomPropertyType(rkCustomPropertyTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.DeleteCustomPropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkCustomPropertyTypeId** | **string**| Removes an element custom property type, and the value assignments to all elements | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteelement"></a>
# **DeleteElement**
> void DeleteElement (string rkElementId)

Delete an element (since 1.11)

Removes an element and all of the versions of that element

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteElementExample
    {
        public void main()
        {
            var apiInstance = new ElementsApi();
            var rkElementId = rkElementId_example;  // string | Id of the element

            try
            {
                // Delete an element (since 1.11)
                apiInstance.DeleteElement(rkElementId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.DeleteElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkElementId** | **string**| Id of the element | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteelementcustomproperty"></a>
# **DeleteElementCustomProperty**
> void DeleteElementCustomProperty (string rkElementId, string propertyName)

Delete a custom property value from an element (since 1.9)

Removes the custom property assignment from the element. If the custom property type is configured to inherit default values, then the default for that custom property type will become active on the element. Inherited custom property values cannot be deleted and attempts to do so will result in a 404.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteElementCustomPropertyExample
    {
        public void main()
        {
            var apiInstance = new ElementsApi();
            var rkElementId = rkElementId_example;  // string | Id of element
            var propertyName = propertyName_example;  // string | Name of the element custom property type to unassign from the element.

            try
            {
                // Delete a custom property value from an element (since 1.9)
                apiInstance.DeleteElementCustomProperty(rkElementId, propertyName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.DeleteElementCustomProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkElementId** | **string**| Id of element | 
 **propertyName** | **string**| Name of the element custom property type to unassign from the element. | 

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
> CustomProperties GetCustomProperties (string rkElementId)

Get custom property values for an element (since 1.8)

Return the map of custom property names and their assigned value, either assigned directly to an element, or inherited by default.

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
            var apiInstance = new ElementsApi();
            var rkElementId = rkElementId_example;  // string | ID of element to fetch

            try
            {
                // Get custom property values for an element (since 1.8)
                CustomProperties result = apiInstance.GetCustomProperties(rkElementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.GetCustomProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkElementId** | **string**| ID of element to fetch | 

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

Get a custom property type (since 1.8)

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
            var apiInstance = new ElementsApi();
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Id of custom property type to fetch

            try
            {
                // Get a custom property type (since 1.8)
                CustomPropertyType result = apiInstance.GetCustomPropertyTypeById(rkCustomPropertyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.GetCustomPropertyTypeById: " + e.Message );
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
> List<CustomPropertyType> GetCustomPropertyTypes (List<string> id = null, List<string> type = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, bool? inheritDefault = null, List<string> defaultValue = null, List<string> minValue = null, List<string> maxValue = null, List<string> availableValues = null, List<string> maxCharacters = null, bool? allowMultilineValues = null, List<string> textEditorWidth = null)

Search custom property types (since 1.8)

Returns all custom property type definitions that can be applied to element, or those that meet the filter criteria.

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
            var apiInstance = new ElementsApi();
            var id = new List<string>(); // List<string> | IDs of custom property types to fetch. (optional) 
            var type = new List<string>(); // List<string> | Types of custom property types to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of custom property types to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of custom property types to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description. (optional) 
            var inheritDefault = true;  // bool? | Inherit default condition of custom property types to fetch. (optional) 
            var defaultValue = new List<string>(); // List<string> | Default values of custom property types to fetch. (optional) 
            var minValue = new List<string>(); // List<string> | Min values of custom property types to fetch. (optional) 
            var maxValue = new List<string>(); // List<string> | Max values of custom property types to fetch. (optional) 
            var availableValues = new List<string>(); // List<string> | Available values of custom property types to fetch. (optional) 
            var maxCharacters = new List<string>(); // List<string> | Max characters conditions of custom property types to fetch. (optional) 
            var allowMultilineValues = true;  // bool? | Allow multiline values condition of custom property types to fetch. (optional) 
            var textEditorWidth = new List<string>(); // List<string> | Text editor width conditions of custom property types to fetch. (optional) 

            try
            {
                // Search custom property types (since 1.8)
                List&lt;CustomPropertyType&gt; result = apiInstance.GetCustomPropertyTypes(id, type, name, description, subDescription, inheritDefault, defaultValue, minValue, maxValue, availableValues, maxCharacters, allowMultilineValues, textEditorWidth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.GetCustomPropertyTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| IDs of custom property types to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Types of custom property types to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of custom property types to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of custom property types to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description. | [optional] 
 **inheritDefault** | **bool?**| Inherit default condition of custom property types to fetch. | [optional] 
 **defaultValue** | [**List&lt;string&gt;**](string.md)| Default values of custom property types to fetch. | [optional] 
 **minValue** | [**List&lt;string&gt;**](string.md)| Min values of custom property types to fetch. | [optional] 
 **maxValue** | [**List&lt;string&gt;**](string.md)| Max values of custom property types to fetch. | [optional] 
 **availableValues** | [**List&lt;string&gt;**](string.md)| Available values of custom property types to fetch. | [optional] 
 **maxCharacters** | [**List&lt;string&gt;**](string.md)| Max characters conditions of custom property types to fetch. | [optional] 
 **allowMultilineValues** | **bool?**| Allow multiline values condition of custom property types to fetch. | [optional] 
 **textEditorWidth** | [**List&lt;string&gt;**](string.md)| Text editor width conditions of custom property types to fetch. | [optional] 

### Return type

[**List<CustomPropertyType>**](CustomPropertyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getelements"></a>
# **GetElements**
> List<Element> GetElements (string pageLimit = null, List<string> id = null, List<string> name = null, List<string> nodeId = null, List<string> ruleId = null, string previousId = null, string pageStart = null)

Get elements (since 1.8)

Returns a list of all elements or those that match the provided criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetElementsExample
    {
        public void main()
        {
            var apiInstance = new ElementsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var id = new List<string>(); // List<string> | Id of the element (optional) 
            var name = new List<string>(); // List<string> | Name of the element (optional) 
            var nodeId = new List<string>(); // List<string> | Id of the node for this element (optional) 
            var ruleId = new List<string>(); // List<string> | Id of the rule for this element (optional) 
            var previousId = previousId_example;  // string | When paging, this should be the last element id returned by the previous page. (optional) 
            var pageStart = pageStart_example;  // string |  (optional) 

            try
            {
                // Get elements (since 1.8)
                List&lt;Element&gt; result = apiInstance.GetElements(pageLimit, id, name, nodeId, ruleId, previousId, pageStart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.GetElements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| Id of the element | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Name of the element | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Id of the node for this element | [optional] 
 **ruleId** | [**List&lt;string&gt;**](string.md)| Id of the rule for this element | [optional] 
 **previousId** | **string**| When paging, this should be the last element id returned by the previous page. | [optional] 
 **pageStart** | **string**|  | [optional] 

### Return type

[**List<Element>**](Element.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setelementcustomproperty"></a>
# **SetElementCustomProperty**
> void SetElementCustomProperty (string rkElementId, string propertyName, PropertyValue body)

Set a custom property value for an element (since 1.8)

Assign a custom property value to an element. The value must meet the requirements of the specific custom property type. If a the custom property type is already assigned to the element, this will overwrite the existing value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetElementCustomPropertyExample
    {
        public void main()
        {
            var apiInstance = new ElementsApi();
            var rkElementId = rkElementId_example;  // string | Id of the element.
            var propertyName = propertyName_example;  // string | Name of the element custom property type to assign to the element.
            var body = new PropertyValue(); // PropertyValue | Value to assign to the custom property of the element.

            try
            {
                // Set a custom property value for an element (since 1.8)
                apiInstance.SetElementCustomProperty(rkElementId, propertyName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.SetElementCustomProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkElementId** | **string**| Id of the element. | 
 **propertyName** | **string**| Name of the element custom property type to assign to the element. | 
 **body** | [**PropertyValue**](PropertyValue.md)| Value to assign to the custom property of the element. | 

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

Modifies an existing element custom property type (since 1.8)

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
            var apiInstance = new ElementsApi();
            var body = new CustomPropertyType(); // CustomPropertyType | Custom property type to be updated
            var rkCustomPropertyTypeId = rkCustomPropertyTypeId_example;  // string | Id of custom property type be updated

            try
            {
                // Modifies an existing element custom property type (since 1.8)
                CustomPropertyType result = apiInstance.UpdateCustomPropertyType(body, rkCustomPropertyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementsApi.UpdateCustomPropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomPropertyType**](CustomPropertyType.md)| Custom property type to be updated | 
 **rkCustomPropertyTypeId** | **string**| Id of custom property type be updated | 

### Return type

[**CustomPropertyType**](CustomPropertyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

