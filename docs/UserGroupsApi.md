# IO.Swagger.Api.UserGroupsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateUserToGroup**](UserGroupsApi.md#associateusertogroup) | **POST** /user-groups/{rkUserGroupId}/users/{rkUserId} | Add a user to a user group
[**Create**](UserGroupsApi.md#create) | **POST** /user-groups | Post a new user group
[**Delete**](UserGroupsApi.md#delete) | **DELETE** /user-groups/{rkUserGroupId} | Delete a user group
[**DisassociateUserFromGroup**](UserGroupsApi.md#disassociateuserfromgroup) | **DELETE** /user-groups/{rkUserGroupId}/users/{rkUserId} | Remove a user from a user group
[**GetAll**](UserGroupsApi.md#getall) | **GET** /user-groups | Search User Groups
[**GetUserGroupById**](UserGroupsApi.md#getusergroupbyid) | **GET** /user-groups/{rkUserGroupId} | Get User Group details by ID
[**GetUserGroupUsers**](UserGroupsApi.md#getusergroupusers) | **GET** /user-groups/{rkUserGroupId}/users | List users of a user group
[**Update**](UserGroupsApi.md#update) | **PUT** /user-groups/{rkUserGroupId} | Update an existing user group


<a name="associateusertogroup"></a>
# **AssociateUserToGroup**
> void AssociateUserToGroup (string rkUserGroupId, string rkUserId)

Add a user to a user group

Adds a user to the user group. Users may belong to multiple user groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateUserToGroupExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var rkUserGroupId = rkUserGroupId_example;  // string | rkUserGroupId
            var rkUserId = rkUserId_example;  // string | rkUserId

            try
            {
                // Add a user to a user group
                apiInstance.AssociateUserToGroup(rkUserGroupId, rkUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.AssociateUserToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserGroupId** | **string**| rkUserGroupId | 
 **rkUserId** | **string**| rkUserId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> UserGroup Create (UserGroup body)

Post a new user group

Creates a new user group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var body = new UserGroup(); // UserGroup | User group request

            try
            {
                // Post a new user group
                UserGroup result = apiInstance.Create(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroup**](UserGroup.md)| User group request | 

### Return type

[**UserGroup**](UserGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string rkUserGroupId)

Delete a user group

Removes an existing user group from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var rkUserGroupId = rkUserGroupId_example;  // string | rkUserGroupId to fetch

            try
            {
                // Delete a user group
                apiInstance.Delete(rkUserGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserGroupId** | **string**| rkUserGroupId to fetch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociateuserfromgroup"></a>
# **DisassociateUserFromGroup**
> void DisassociateUserFromGroup (string rkUserGroupId, string rkUserId)

Remove a user from a user group

Removes a user from a specified user group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisassociateUserFromGroupExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var rkUserGroupId = rkUserGroupId_example;  // string | rkUserGroupId
            var rkUserId = rkUserId_example;  // string | rkUserId

            try
            {
                // Remove a user from a user group
                apiInstance.DisassociateUserFromGroup(rkUserGroupId, rkUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.DisassociateUserFromGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserGroupId** | **string**| rkUserGroupId | 
 **rkUserId** | **string**| rkUserId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getall"></a>
# **GetAll**
> List<UserGroup> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, bool? builtin = null)

Search User Groups

Returns a list of all user groups or those that match the provided filter criteria.

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
            var apiInstance = new UserGroupsApi();
            var id = new List<string>(); // List<string> | IDs of groups to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of groups to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of groups to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Sub-descriptions of groups to fetch. (optional) 
            var builtin = true;  // bool? | User group builtin filter. (optional) 

            try
            {
                // Search User Groups
                List&lt;UserGroup&gt; result = apiInstance.GetAll(id, name, description, subDescription, builtin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| IDs of groups to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of groups to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of groups to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Sub-descriptions of groups to fetch. | [optional] 
 **builtin** | **bool?**| User group builtin filter. | [optional] 

### Return type

[**List<UserGroup>**](UserGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroupbyid"></a>
# **GetUserGroupById**
> UserGroup GetUserGroupById (string rkUserGroupId)

Get User Group details by ID

Returns the details of a single user group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserGroupByIdExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var rkUserGroupId = rkUserGroupId_example;  // string | rkUserGroupId to fetch

            try
            {
                // Get User Group details by ID
                UserGroup result = apiInstance.GetUserGroupById(rkUserGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.GetUserGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserGroupId** | **string**| rkUserGroupId to fetch | 

### Return type

[**UserGroup**](UserGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroupusers"></a>
# **GetUserGroupUsers**
> List<User> GetUserGroupUsers (string rkUserGroupId)

List users of a user group

Returns a list of the users that belong to the specified user group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserGroupUsersExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var rkUserGroupId = rkUserGroupId_example;  // string | rkUserGroupId to fetch

            try
            {
                // List users of a user group
                List&lt;User&gt; result = apiInstance.GetUserGroupUsers(rkUserGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.GetUserGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserGroupId** | **string**| rkUserGroupId to fetch | 

### Return type

[**List<User>**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> UserGroup Update (string rkUserGroupId, UserGroup body)

Update an existing user group

Replaces the values of the submitted fields in an existing user group. Read-only fields should not be submitted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            var apiInstance = new UserGroupsApi();
            var rkUserGroupId = rkUserGroupId_example;  // string | rkUserGroupId to fetch
            var body = new UserGroup(); // UserGroup | User group request

            try
            {
                // Update an existing user group
                UserGroup result = apiInstance.Update(rkUserGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupsApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserGroupId** | **string**| rkUserGroupId to fetch | 
 **body** | [**UserGroup**](UserGroup.md)| User group request | 

### Return type

[**UserGroup**](UserGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

