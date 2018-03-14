# IO.Swagger.Api.SettingsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomNodeTypes**](SettingsApi.md#createcustomnodetypes) | **POST** /settings/customNodeTypes | Create a custom node type (since 1.10)
[**CreateGlobalVariables**](SettingsApi.md#createglobalvariables) | **POST** /settings/variables | Create a new global variable (since 1.11)
[**DeleteCustomNodeType**](SettingsApi.md#deletecustomnodetype) | **DELETE** /settings/customNodeTypes/{rkCustomNodeTypeId} | Delete a custom node type (since 1.11)
[**DeleteGlobalVariable**](SettingsApi.md#deleteglobalvariable) | **DELETE** /settings/variables/{name} | Delete global variable (since 1.11)
[**GetCustomNodeTypes**](SettingsApi.md#getcustomnodetypes) | **GET** /settings/customNodeTypes | Get the set of custom node types (since 1.10)
[**GetFileSystem**](SettingsApi.md#getfilesystem) | **GET** /settings/filesystems | Get file system monitoring settings (since 1.9)
[**GetGlobalVariables**](SettingsApi.md#getglobalvariables) | **GET** /settings/variables | Get global variables (since 1.11)
[**GetLicenses**](SettingsApi.md#getlicenses) | **GET** /settings/licenses | Get the list of licensed features (since 1.8)
[**GetSeverityRange**](SettingsApi.md#getseverityrange) | **GET** /settings/system/severityRange | Get a list of all the SeverityRange definitions (since 1.6)
[**GetSystemProperties**](SettingsApi.md#getsystemproperties) | **GET** /settings/systemProperties | Get JVM system properties
[**UpdateGlobalVariables**](SettingsApi.md#updateglobalvariables) | **PUT** /settings/variables/{name} | Update a global variable (since 1.11)


<a name="createcustomnodetypes"></a>
# **CreateCustomNodeTypes**
> CustomNodeType CreateCustomNodeTypes (CustomNodeType body)

Create a custom node type (since 1.10)

Returns a newly created custom node type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomNodeTypesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var body = new CustomNodeType(); // CustomNodeType | A custom node type with id, name and description

            try
            {
                // Create a custom node type (since 1.10)
                CustomNodeType result = apiInstance.CreateCustomNodeTypes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.CreateCustomNodeTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomNodeType**](CustomNodeType.md)| A custom node type with id, name and description | 

### Return type

[**CustomNodeType**](CustomNodeType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createglobalvariables"></a>
# **CreateGlobalVariables**
> GlobalVariable CreateGlobalVariables (GlobalVariable body)

Create a new global variable (since 1.11)

Creates a new global variable. The name must be unique. Variable type can either be 'text' or 'password'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGlobalVariablesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var body = new GlobalVariable(); // GlobalVariable | A global variable definition

            try
            {
                // Create a new global variable (since 1.11)
                GlobalVariable result = apiInstance.CreateGlobalVariables(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.CreateGlobalVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GlobalVariable**](GlobalVariable.md)| A global variable definition | 

### Return type

[**GlobalVariable**](GlobalVariable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomnodetype"></a>
# **DeleteCustomNodeType**
> void DeleteCustomNodeType (string rkCustomNodeTypeId)

Delete a custom node type (since 1.11)

Removes a custom node type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCustomNodeTypeExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var rkCustomNodeTypeId = rkCustomNodeTypeId_example;  // string | ID of custom node type to delete

            try
            {
                // Delete a custom node type (since 1.11)
                apiInstance.DeleteCustomNodeType(rkCustomNodeTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteCustomNodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkCustomNodeTypeId** | **string**| ID of custom node type to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteglobalvariable"></a>
# **DeleteGlobalVariable**
> void DeleteGlobalVariable (string name)

Delete global variable (since 1.11)

Removes a global variable definition by name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGlobalVariableExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var name = name_example;  // string | Name of the global variable to delete

            try
            {
                // Delete global variable (since 1.11)
                apiInstance.DeleteGlobalVariable(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteGlobalVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the global variable to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomnodetypes"></a>
# **GetCustomNodeTypes**
> CustomNodeType GetCustomNodeTypes (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null)

Get the set of custom node types (since 1.10)

Returns a list of all the custom node types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomNodeTypesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var id = new List<string>(); // List<string> | ID of custom node types to fetch (optional) 
            var name = new List<string>(); // List<string> | Name of custom node types to fetch (optional) 
            var description = new List<string>(); // List<string> | Description of custom node types to fetch (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description of custom node types to fetch (optional) 

            try
            {
                // Get the set of custom node types (since 1.10)
                CustomNodeType result = apiInstance.GetCustomNodeTypes(id, name, description, subDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCustomNodeTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| ID of custom node types to fetch | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Name of custom node types to fetch | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Description of custom node types to fetch | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description of custom node types to fetch | [optional] 

### Return type

[**CustomNodeType**](CustomNodeType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilesystem"></a>
# **GetFileSystem**
> FileSystemSettings GetFileSystem ()

Get file system monitoring settings (since 1.9)

Returns the map of settings specific to file system server settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFileSystemExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();

            try
            {
                // Get file system monitoring settings (since 1.9)
                FileSystemSettings result = apiInstance.GetFileSystem();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetFileSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**FileSystemSettings**](FileSystemSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobalvariables"></a>
# **GetGlobalVariables**
> GlobalVariable GetGlobalVariables (List<string> name = null, List<string> description = null, List<string> subDescription = null, string type = null)

Get global variables (since 1.11)

List all global variables

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGlobalVariablesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var name = new List<string>(); // List<string> | Name of the variables (optional) 
            var description = new List<string>(); // List<string> | Description of the variables (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description of variables to fetch (optional) 
            var type = type_example;  // string | Either 'text' or 'password' indicating display restrictions for the value (optional) 

            try
            {
                // Get global variables (since 1.11)
                GlobalVariable result = apiInstance.GetGlobalVariables(name, description, subDescription, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetGlobalVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | [**List&lt;string&gt;**](string.md)| Name of the variables | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Description of the variables | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description of variables to fetch | [optional] 
 **type** | **string**| Either &#39;text&#39; or &#39;password&#39; indicating display restrictions for the value | [optional] 

### Return type

[**GlobalVariable**](GlobalVariable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicenses"></a>
# **GetLicenses**
> List<License> GetLicenses ()

Get the list of licensed features (since 1.8)

Returns a list of all licensed feature in TE including the feature consumption.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLicensesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();

            try
            {
                // Get the list of licensed features (since 1.8)
                List&lt;License&gt; result = apiInstance.GetLicenses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetLicenses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<License>**](License.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getseverityrange"></a>
# **GetSeverityRange**
> List<SeverityRange> GetSeverityRange ()

Get a list of all the SeverityRange definitions (since 1.6)

Returns a list of all the severity ranges and their attributes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSeverityRangeExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();

            try
            {
                // Get a list of all the SeverityRange definitions (since 1.6)
                List&lt;SeverityRange&gt; result = apiInstance.GetSeverityRange();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSeverityRange: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SeverityRange>**](SeverityRange.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemproperties"></a>
# **GetSystemProperties**
> Dictionary<string, Object> GetSystemProperties ()

Get JVM system properties

Returns a map of system properties currently active in the JVM

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemPropertiesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();

            try
            {
                // Get JVM system properties
                Dictionary&lt;string, Object&gt; result = apiInstance.GetSystemProperties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSystemProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateglobalvariables"></a>
# **UpdateGlobalVariables**
> GlobalVariable UpdateGlobalVariables (string name, GlobalVariable body)

Update a global variable (since 1.11)

Modifies an existing global variable based on the name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGlobalVariablesExample
    {
        public void main()
        {
            var apiInstance = new SettingsApi();
            var name = name_example;  // string | Name of the variable
            var body = new GlobalVariable(); // GlobalVariable | A global variable definition

            try
            {
                // Update a global variable (since 1.11)
                GlobalVariable result = apiInstance.UpdateGlobalVariables(name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.UpdateGlobalVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the variable | 
 **body** | [**GlobalVariable**](GlobalVariable.md)| A global variable definition | 

### Return type

[**GlobalVariable**](GlobalVariable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

