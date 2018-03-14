# IO.Swagger.Api.RolesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociatePermissionToRole**](RolesApi.md#associatepermissiontorole) | **POST** /roles/{rkRoleId}/permissions/{rkPermissionId} | Add a permission to a role
[**CreateRole**](RolesApi.md#createrole) | **POST** /roles | Post a new role
[**DeletePermissionFromRole**](RolesApi.md#deletepermissionfromrole) | **DELETE** /roles/{rkRoleId}/permissions/{rkPermissionId} | Delete association between a role and a permission
[**DeleteRole**](RolesApi.md#deleterole) | **DELETE** /roles/{rkRoleId} | Delete a role
[**GetRole**](RolesApi.md#getrole) | **GET** /roles/{rkRoleId} | Get role details by ID
[**GetRolePermissions**](RolesApi.md#getrolepermissions) | **GET** /roles/{rkRoleId}/permissions | Get the list of permissions associated with a role
[**GetRoles**](RolesApi.md#getroles) | **GET** /roles | Search roles
[**UpdateRole**](RolesApi.md#updaterole) | **PUT** /roles/{rkRoleId} | Update an existing role


<a name="associatepermissiontorole"></a>
# **AssociatePermissionToRole**
> void AssociatePermissionToRole (string rkRoleId, string rkPermissionId)

Add a permission to a role

Associates a Permission with a role, granting it to all users that have that Role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociatePermissionToRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var rkRoleId = rkRoleId_example;  // string | ID of role to create the association
            var rkPermissionId = rkPermissionId_example;  // string | ID of permission to create the association

            try
            {
                // Add a permission to a role
                apiInstance.AssociatePermissionToRole(rkRoleId, rkPermissionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.AssociatePermissionToRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRoleId** | **string**| ID of role to create the association | 
 **rkPermissionId** | **string**| ID of permission to create the association | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrole"></a>
# **CreateRole**
> Role CreateRole (Role body)

Post a new role

Posts a request to create a new role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var body = new Role(); // Role | Role object to be created in TE

            try
            {
                // Post a new role
                Role result = apiInstance.CreateRole(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Role**](Role.md)| Role object to be created in TE | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepermissionfromrole"></a>
# **DeletePermissionFromRole**
> void DeletePermissionFromRole (string rkRoleId, string rkPermissionId)

Delete association between a role and a permission

Removes a permission from the role, no longer granting it to users with that role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePermissionFromRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var rkRoleId = rkRoleId_example;  // string | ID of role to remove the association
            var rkPermissionId = rkPermissionId_example;  // string | ID of permission to remove the association

            try
            {
                // Delete association between a role and a permission
                apiInstance.DeletePermissionFromRole(rkRoleId, rkPermissionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeletePermissionFromRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRoleId** | **string**| ID of role to remove the association | 
 **rkPermissionId** | **string**| ID of permission to remove the association | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> void DeleteRole (string rkRoleId)

Delete a role

Removes an existing role from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var rkRoleId = rkRoleId_example;  // string | ID of role to fetch

            try
            {
                // Delete a role
                apiInstance.DeleteRole(rkRoleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRoleId** | **string**| ID of role to fetch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
> Role GetRole (string rkRoleId)

Get role details by ID

Returns the details of a single role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var rkRoleId = rkRoleId_example;  // string | ID of role to fetch

            try
            {
                // Get role details by ID
                Role result = apiInstance.GetRole(rkRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRoleId** | **string**| ID of role to fetch | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolepermissions"></a>
# **GetRolePermissions**
> List<Permission> GetRolePermissions (string rkRoleId)

Get the list of permissions associated with a role

Returns a list that includes all the permissions that a user is granted by having the specified role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolePermissionsExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var rkRoleId = rkRoleId_example;  // string | ID of role to fetch the permissions from

            try
            {
                // Get the list of permissions associated with a role
                List&lt;Permission&gt; result = apiInstance.GetRolePermissions(rkRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRolePermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRoleId** | **string**| ID of role to fetch the permissions from | 

### Return type

[**List<Permission>**](Permission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> List<Role> GetRoles (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, bool? builtin = null, bool? administrator = null)

Search roles

Returns a list of all roles, or those that match the filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var id = new List<string>(); // List<string> | Role IDs to search. (optional) 
            var name = new List<string>(); // List<string> | Role names to search. (optional) 
            var description = new List<string>(); // List<string> | Role description to search. (optional) 
            var subDescription = new List<string>(); // List<string> | Role substring criteria for description to search. (optional) 
            var builtin = true;  // bool? | Role builtin filter. (optional) 
            var administrator = true;  // bool? | Role administrator filter. (optional) 

            try
            {
                // Search roles
                List&lt;Role&gt; result = apiInstance.GetRoles(id, name, description, subDescription, builtin, administrator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| Role IDs to search. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Role names to search. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Role description to search. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Role substring criteria for description to search. | [optional] 
 **builtin** | **bool?**| Role builtin filter. | [optional] 
 **administrator** | **bool?**| Role administrator filter. | [optional] 

### Return type

[**List<Role>**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> Role UpdateRole (string rkRoleId, Role body)

Update an existing role

Modifies an existing role to update the submitted fields with new values. Read-only fields should not be submitted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var rkRoleId = rkRoleId_example;  // string | ID of role to be updated
            var body = new Role(); // Role | Role description to update the existing role

            try
            {
                // Update an existing role
                Role result = apiInstance.UpdateRole(rkRoleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRoleId** | **string**| ID of role to be updated | 
 **body** | [**Role**](Role.md)| Role description to update the existing role | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

