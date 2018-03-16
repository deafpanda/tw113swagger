# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateHomePageToUser**](UsersApi.md#associatehomepagetouser) | **POST** /users/{rkUserId}/homepages/{rkHomePageId} | Add a homepage to a user (since 1.1)
[**AssociateRoleToUser**](UsersApi.md#associateroletouser) | **POST** /users/{rkUserId}/roles/{rkRoleId} | Associate a role to a user (since 1.1)
[**ChangePassword**](UsersApi.md#changepassword) | **POST** /users/{rkUserId}/password | Set or change a user&#39;s password (since 1.3)
[**CreateUser**](UsersApi.md#createuser) | **POST** /users | Create a new user (since 1.1)
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{rkUserId} | Delete a user (since 1.1)
[**DisassociateHomepageFromUser**](UsersApi.md#disassociatehomepagefromuser) | **DELETE** /users/{rkUserId}/homepages/{rkHomePageId} | Delete a homepage from a user&#39;s list of homepages (since 1.1)
[**DisassociateRoleFromUser**](UsersApi.md#disassociaterolefromuser) | **DELETE** /users/{rkUserId}/roles/{rkRoleId} | Delete a role from a user (since 1.1)
[**GetGroupsOfUser**](UsersApi.md#getgroupsofuser) | **GET** /users/{rkUserId}/user-groups | List the user groups a user is a member of (since 1.1)
[**GetHomepagesByUserId**](UsersApi.md#gethomepagesbyuserid) | **GET** /users/{rkUserId}/homepages | Get the user&#39;s homepages (since 1.1)
[**GetRolesByUserId**](UsersApi.md#getrolesbyuserid) | **GET** /users/{rkUserId}/roles | Get the roles for a user (since 1.1)
[**GetUserById**](UsersApi.md#getuserbyid) | **GET** /users/{rkUserId} | Get a user by ID (since 1.1)
[**GetUsers**](UsersApi.md#getusers) | **GET** /users | Search users (since 1.1)
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{rkUserId} | Update details of a user (since 1.1)


<a name="associatehomepagetouser"></a>
# **AssociateHomePageToUser**
> void AssociateHomePageToUser (string rkUserId, string rkHomePageId)

Add a homepage to a user (since 1.1)

Adds a homepage to the set of homepages available to a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateHomePageToUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to associate
            var rkHomePageId = rkHomePageId_example;  // string | ID of homepage to associate

            try
            {
                // Add a homepage to a user (since 1.1)
                apiInstance.AssociateHomePageToUser(rkUserId, rkHomePageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AssociateHomePageToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to associate | 
 **rkHomePageId** | **string**| ID of homepage to associate | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associateroletouser"></a>
# **AssociateRoleToUser**
> void AssociateRoleToUser (string rkUserId, string rkRoleId)

Associate a role to a user (since 1.1)

Associate a role to a user to grant them the permissions associated with that role. The TE user   interface for administering users and roles will not work correctly if multiple roles are applied   to a single user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateRoleToUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to associate
            var rkRoleId = rkRoleId_example;  // string | ID of role to associate

            try
            {
                // Associate a role to a user (since 1.1)
                apiInstance.AssociateRoleToUser(rkUserId, rkRoleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AssociateRoleToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to associate | 
 **rkRoleId** | **string**| ID of role to associate | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> Password ChangePassword (string rkUserId, Password body)

Set or change a user's password (since 1.3)

The API allows an authorized user (the admin user or the user himself) to change a password. If the  requesting user does not have the Administrator role, then the old password must be submitted, and rkUserId must be the user's own ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to change password
            var body = new Password(); // Password | Password object to be set/change for user

            try
            {
                // Set or change a user's password (since 1.3)
                Password result = apiInstance.ChangePassword(rkUserId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to change password | 
 **body** | [**Password**](Password.md)| Password object to be set/change for user | 

### Return type

[**Password**](Password.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> User CreateUser (User body)

Create a new user (since 1.1)

Returns the newly created user. The user has no password, and no role.  A role must be associated before the user logs in.  If using LDAP authentication with Tripwire Enterprise, the password may be left unset.  The TE UI will not support editing a user that does not have a password or role set.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new User(); // User | User object to be created in TE

            try
            {
                // Create a new user (since 1.1)
                User result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)| User object to be created in TE | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string rkUserId)

Delete a user (since 1.1)

Removes a user from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to fetch

            try
            {
                // Delete a user (since 1.1)
                apiInstance.DeleteUser(rkUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to fetch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociatehomepagefromuser"></a>
# **DisassociateHomepageFromUser**
> void DisassociateHomepageFromUser (string rkUserId, string rkHomePageId)

Delete a homepage from a user's list of homepages (since 1.1)

Removes the homepage from those available to the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisassociateHomepageFromUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | rkUserId
            var rkHomePageId = rkHomePageId_example;  // string | rkHomePageId

            try
            {
                // Delete a homepage from a user's list of homepages (since 1.1)
                apiInstance.DisassociateHomepageFromUser(rkUserId, rkHomePageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DisassociateHomepageFromUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| rkUserId | 
 **rkHomePageId** | **string**| rkHomePageId | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociaterolefromuser"></a>
# **DisassociateRoleFromUser**
> void DisassociateRoleFromUser (string rkUserId, string rkRoleId)

Delete a role from a user (since 1.1)

Removes a role from those associated with a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisassociateRoleFromUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to disassociate
            var rkRoleId = rkRoleId_example;  // string | ID of role to disassociate

            try
            {
                // Delete a role from a user (since 1.1)
                apiInstance.DisassociateRoleFromUser(rkUserId, rkRoleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DisassociateRoleFromUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to disassociate | 
 **rkRoleId** | **string**| ID of role to disassociate | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsofuser"></a>
# **GetGroupsOfUser**
> UserGroup GetGroupsOfUser (string rkUserId)

List the user groups a user is a member of (since 1.1)

Returns a list of the user groups that the specified user belongs to.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupsOfUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user

            try
            {
                // List the user groups a user is a member of (since 1.1)
                UserGroup result = apiInstance.GetGroupsOfUser(rkUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetGroupsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user | 

### Return type

[**UserGroup**](UserGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethomepagesbyuserid"></a>
# **GetHomepagesByUserId**
> Homepage GetHomepagesByUserId (string rkUserId)

Get the user's homepages (since 1.1)

Returns a list of the homepages that have been assigned to, or created by the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHomepagesByUserIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user

            try
            {
                // Get the user's homepages (since 1.1)
                Homepage result = apiInstance.GetHomepagesByUserId(rkUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetHomepagesByUserId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user | 

### Return type

[**Homepage**](Homepage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyuserid"></a>
# **GetRolesByUserId**
> Role GetRolesByUserId (string rkUserId)

Get the roles for a user (since 1.1)

Returns the roles associated with this user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByUserIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to fetch

            try
            {
                // Get the roles for a user (since 1.1)
                Role result = apiInstance.GetRolesByUserId(rkUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetRolesByUserId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to fetch | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyid"></a>
# **GetUserById**
> User GetUserById (string rkUserId)

Get a user by ID (since 1.1)

Returns the details of a single user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserByIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to fetch

            try
            {
                // Get a user by ID (since 1.1)
                User result = apiInstance.GetUserById(rkUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to fetch | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> User GetUsers (bool? builtin = null, List<string> description = null, List<string> email = null, List<string> id = null, List<string> lastLogin = null, List<string> lastLogout = null, List<string> name = null, List<string> roleId = null, List<string> subDescription = null)

Search users (since 1.1)

Returns a list of all users or those that match the filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var builtin = true;  // bool? | Fetch users that are builtin to TE deployments or only custom users. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of users to fetch. (optional) 
            var email = new List<string>(); // List<string> | Emails of users to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of users to fetch. (optional) 
            var lastLogin = new List<string>(); // List<string> | Last login dates of users to fetch. (optional) 
            var lastLogout = new List<string>(); // List<string> | Last logout dates of users to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of users to fetch. (optional) 
            var roleId = new List<string>(); // List<string> | The id of the role associated to the user (optional) 
            var subDescription = new List<string>(); // List<string> | Support for substring search for description parameter. (optional) 

            try
            {
                // Search users (since 1.1)
                User result = apiInstance.GetUsers(builtin, description, email, id, lastLogin, lastLogout, name, roleId, subDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **builtin** | **bool?**| Fetch users that are builtin to TE deployments or only custom users. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of users to fetch. | [optional] 
 **email** | [**List&lt;string&gt;**](string.md)| Emails of users to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of users to fetch. | [optional] 
 **lastLogin** | [**List&lt;string&gt;**](string.md)| Last login dates of users to fetch. | [optional] 
 **lastLogout** | [**List&lt;string&gt;**](string.md)| Last logout dates of users to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of users to fetch. | [optional] 
 **roleId** | [**List&lt;string&gt;**](string.md)| The id of the role associated to the user | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for substring search for description parameter. | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> User UpdateUser (string rkUserId, User body)

Update details of a user (since 1.1)

Modifies a user updating the user fields with those submitted in the request. Read-only fields should not be submitted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var rkUserId = rkUserId_example;  // string | ID of user to be updated
            var body = new User(); // User | User description to update the existing user

            try
            {
                // Update details of a user (since 1.1)
                User result = apiInstance.UpdateUser(rkUserId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkUserId** | **string**| ID of user to be updated | 
 **body** | [**User**](User.md)| User description to update the existing user | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

