# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateHomePageToUser**](UsersApi.md#associatehomepagetouser) | **POST** /users/{rkUserId}/homepages/{rkHomePageId} | Add a homepage to a user
[**AssociateRoleToUser**](UsersApi.md#associateroletouser) | **POST** /users/{rkUserId}/roles/{rkRoleId} | Associate a role to a user
[**ChangePassword**](UsersApi.md#changepassword) | **POST** /users/{rkUserId}/password | Set or change a user&#39;s password
[**CreateUser**](UsersApi.md#createuser) | **POST** /users | Create a new user
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{rkUserId} | Delete a user
[**DisassociateHomepageFromUser**](UsersApi.md#disassociatehomepagefromuser) | **DELETE** /users/{rkUserId}/homepages/{rkHomePageId} | Delete a homepage from a user&#39;s list of homepages
[**DisassociateRoleFromUser**](UsersApi.md#disassociaterolefromuser) | **DELETE** /users/{rkUserId}/roles/{rkRoleId} | Delete a role from a user
[**GetGroupsOfUser**](UsersApi.md#getgroupsofuser) | **GET** /users/{rkUserId}/user-groups | List the user groups a user is a member of
[**GetHomepagesByUserId**](UsersApi.md#gethomepagesbyuserid) | **GET** /users/{rkUserId}/homepages | Get the user&#39;s homepages
[**GetRolesByUserId**](UsersApi.md#getrolesbyuserid) | **GET** /users/{rkUserId}/roles | Get the roles for a user
[**GetUserById**](UsersApi.md#getuserbyid) | **GET** /users/{rkUserId} | Get a user by ID
[**GetUsers**](UsersApi.md#getusers) | **GET** /users | Search users
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{rkUserId} | Update details of a user


<a name="associatehomepagetouser"></a>
# **AssociateHomePageToUser**
> void AssociateHomePageToUser (string rkUserId, string rkHomePageId)

Add a homepage to a user

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
                // Add a homepage to a user
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

Associate a role to a user

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
                // Associate a role to a user
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

Set or change a user's password

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
                // Set or change a user's password
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

Create a new user

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
                // Create a new user
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

Delete a user

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
                // Delete a user
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

Delete a homepage from a user's list of homepages

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
                // Delete a homepage from a user's list of homepages
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

Delete a role from a user

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
                // Delete a role from a user
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
> List<UserGroup> GetGroupsOfUser (string rkUserId)

List the user groups a user is a member of

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
                // List the user groups a user is a member of
                List&lt;UserGroup&gt; result = apiInstance.GetGroupsOfUser(rkUserId);
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

[**List<UserGroup>**](UserGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethomepagesbyuserid"></a>
# **GetHomepagesByUserId**
> List<Homepage> GetHomepagesByUserId (string rkUserId)

Get the user's homepages

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
                // Get the user's homepages
                List&lt;Homepage&gt; result = apiInstance.GetHomepagesByUserId(rkUserId);
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

[**List<Homepage>**](Homepage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyuserid"></a>
# **GetRolesByUserId**
> List<Role> GetRolesByUserId (string rkUserId)

Get the roles for a user

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
                // Get the roles for a user
                List&lt;Role&gt; result = apiInstance.GetRolesByUserId(rkUserId);
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

[**List<Role>**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyid"></a>
# **GetUserById**
> User GetUserById (string rkUserId)

Get a user by ID

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
                // Get a user by ID
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
> List<User> GetUsers (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, bool? builtin = null, List<string> lastLogin = null, List<string> lastLogout = null, List<string> email = null)

Search users

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
            var id = new List<string>(); // List<string> | IDs of users to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of users to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of users to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Support for substring search for description parameter. (optional) 
            var builtin = true;  // bool? | Fetch users that are builtin to TE deployments or only custom users. (optional) 
            var lastLogin = new List<string>(); // List<string> | Last login dates of users to fetch. (optional) 
            var lastLogout = new List<string>(); // List<string> | Last logout dates of users to fetch. (optional) 
            var email = new List<string>(); // List<string> | Emails of users to fetch. (optional) 

            try
            {
                // Search users
                List&lt;User&gt; result = apiInstance.GetUsers(id, name, description, subDescription, builtin, lastLogin, lastLogout, email);
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
 **id** | [**List&lt;string&gt;**](string.md)| IDs of users to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of users to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of users to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for substring search for description parameter. | [optional] 
 **builtin** | **bool?**| Fetch users that are builtin to TE deployments or only custom users. | [optional] 
 **lastLogin** | [**List&lt;string&gt;**](string.md)| Last login dates of users to fetch. | [optional] 
 **lastLogout** | [**List&lt;string&gt;**](string.md)| Last logout dates of users to fetch. | [optional] 
 **email** | [**List&lt;string&gt;**](string.md)| Emails of users to fetch. | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> User UpdateUser (string rkUserId, User body)

Update details of a user

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
                // Update details of a user
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

