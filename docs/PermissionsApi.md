# IO.Swagger.Api.PermissionsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAll**](PermissionsApi.md#getall) | **GET** /permissions | Search for permissions
[**GetPermissionById**](PermissionsApi.md#getpermissionbyid) | **GET** /permissions/{rkPermissionId} | Get permission details by Id


<a name="getall"></a>
# **GetAll**
> List<Permission> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null)

Search for permissions

Returns a list of all permissions or those that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllExample
    {
        public void main()
        {
            var apiInstance = new PermissionsApi();
            var id = new List<string>(); // List<string> | IDs of permissions to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of permissions to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of permissions to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Substring matching for description. (optional) 
            var target = new List<string>(); // List<string> | Targets of permissions to fetch. (optional) 
            var category = new List<string>(); // List<string> | Categories of permissions to fetch. (optional) 

            try
            {
                // Search for permissions
                List&lt;Permission&gt; result = apiInstance.GetAll(id, name, description, subDescription, target, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| IDs of permissions to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of permissions to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of permissions to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Substring matching for description. | [optional] 
 **target** | [**List&lt;string&gt;**](string.md)| Targets of permissions to fetch. | [optional] 
 **category** | [**List&lt;string&gt;**](string.md)| Categories of permissions to fetch. | [optional] 

### Return type

[**List<Permission>**](Permission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissionbyid"></a>
# **GetPermissionById**
> Permission GetPermissionById (string rkPermissionId)

Get permission details by Id

Returns the details of a single permission.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPermissionByIdExample
    {
        public void main()
        {
            var apiInstance = new PermissionsApi();
            var rkPermissionId = rkPermissionId_example;  // string | rkPermissionId to fetch

            try
            {
                // Get permission details by Id
                Permission result = apiInstance.GetPermissionById(rkPermissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetPermissionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPermissionId** | **string**| rkPermissionId to fetch | 

### Return type

[**Permission**](Permission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

