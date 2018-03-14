# IO.Swagger.Api.RulegroupsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateRuleGroupableToRuleGroup**](RulegroupsApi.md#associaterulegroupabletorulegroup) | **POST** /rulegroups/{rkRuleGroupId}/links/{rkRuleGroupableId} | Add a rule group link
[**CreateRuleGroup**](RulegroupsApi.md#createrulegroup) | **POST** /rulegroups | Create a new rule group
[**DeleteRuleGroup**](RulegroupsApi.md#deleterulegroup) | **DELETE** /rulegroups/{rkRuleGroupId} | Delete a rule group
[**DisassociateRuleGroupableFromRuleGroup**](RulegroupsApi.md#disassociaterulegroupablefromrulegroup) | **DELETE** /rulegroups/{rkRuleGroupId}/links/{rkRuleGroupableId} | Delete a rule group link
[**GetRootRuleGroup**](RulegroupsApi.md#getrootrulegroup) | **GET** /rulegroups/root | Get root rule group
[**GetRuleGroupById**](RulegroupsApi.md#getrulegroupbyid) | **GET** /rulegroups/{rkRuleGroupId} | Get the details of a single RuleGroup
[**GetRuleGroups**](RulegroupsApi.md#getrulegroups) | **GET** /rulegroups | Search all RuleGroups


<a name="associaterulegroupabletorulegroup"></a>
# **AssociateRuleGroupableToRuleGroup**
> void AssociateRuleGroupableToRuleGroup (string rkRuleGroupId, string rkRuleGroupableId)

Add a rule group link

Links a rule or rule group as a child in another rule group. Rules and rule groups may be linked into many rule groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateRuleGroupableToRuleGroupExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();
            var rkRuleGroupId = rkRuleGroupId_example;  // string | Id of parent rule group
            var rkRuleGroupableId = rkRuleGroupableId_example;  // string | ID of child rule or rule group

            try
            {
                // Add a rule group link
                apiInstance.AssociateRuleGroupableToRuleGroup(rkRuleGroupId, rkRuleGroupableId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.AssociateRuleGroupableToRuleGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleGroupId** | **string**| Id of parent rule group | 
 **rkRuleGroupableId** | **string**| ID of child rule or rule group | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrulegroup"></a>
# **CreateRuleGroup**
> RuleGroup CreateRuleGroup (RuleGroup body)

Create a new rule group

Returns the newly created rule group. New rule groups are in the unlinked group until linked with another rule group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRuleGroupExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();
            var body = new RuleGroup(); // RuleGroup | Rule Group object to be created in TE

            try
            {
                // Create a new rule group
                RuleGroup result = apiInstance.CreateRuleGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.CreateRuleGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RuleGroup**](RuleGroup.md)| Rule Group object to be created in TE | 

### Return type

[**RuleGroup**](RuleGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterulegroup"></a>
# **DeleteRuleGroup**
> void DeleteRuleGroup (string rkRuleGroupId)

Delete a rule group

Removes a rule group from TE. Child rules and rule groups with no other links will be move to the unlinked group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRuleGroupExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();
            var rkRuleGroupId = rkRuleGroupId_example;  // string | ID of Rule Group to delete

            try
            {
                // Delete a rule group
                apiInstance.DeleteRuleGroup(rkRuleGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.DeleteRuleGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleGroupId** | **string**| ID of Rule Group to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociaterulegroupablefromrulegroup"></a>
# **DisassociateRuleGroupableFromRuleGroup**
> void DisassociateRuleGroupableFromRuleGroup (string rkRuleGroupId, string rkRuleGroupableId)

Delete a rule group link

Removes a child rule or rule group from a parent rule group. If the child is no longer linked to any other rule groups, then it is moved to the unlinked group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisassociateRuleGroupableFromRuleGroupExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();
            var rkRuleGroupId = rkRuleGroupId_example;  // string | Id of parent rule group
            var rkRuleGroupableId = rkRuleGroupableId_example;  // string | ID of child rule or rule group

            try
            {
                // Delete a rule group link
                apiInstance.DisassociateRuleGroupableFromRuleGroup(rkRuleGroupId, rkRuleGroupableId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.DisassociateRuleGroupableFromRuleGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleGroupId** | **string**| Id of parent rule group | 
 **rkRuleGroupableId** | **string**| ID of child rule or rule group | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootrulegroup"></a>
# **GetRootRuleGroup**
> RuleGroup GetRootRuleGroup ()

Get root rule group

Returns the rule group resource for the 'Root Rule Group'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootRuleGroupExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();

            try
            {
                // Get root rule group
                RuleGroup result = apiInstance.GetRootRuleGroup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.GetRootRuleGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RuleGroup**](RuleGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulegroupbyid"></a>
# **GetRuleGroupById**
> RuleGroup GetRuleGroupById (string rkRuleGroupId)

Get the details of a single RuleGroup

Permissions needed: 'tool.rule.load'

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleGroupByIdExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();
            var rkRuleGroupId = rkRuleGroupId_example;  // string | ID of Rule Group to fetch

            try
            {
                // Get the details of a single RuleGroup
                RuleGroup result = apiInstance.GetRuleGroupById(rkRuleGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.GetRuleGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleGroupId** | **string**| ID of Rule Group to fetch | 

### Return type

[**RuleGroup**](RuleGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulegroups"></a>
# **GetRuleGroups**
> List<RuleGroup> GetRuleGroups (string pageLimit = null, string pageStart = null, List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> modifiedTime = null, List<string> importedTime = null, List<string> trackingId = null)

Search all RuleGroups

Return a list of all RuleGroups or only those RuleGroups that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleGroupsExample
    {
        public void main()
        {
            var apiInstance = new RulegroupsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var id = new List<string>(); // List<string> | IDs of Rule Groups to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of Rule Groups to fetch. (optional) 
            var description = new List<string>(); // List<string> | Descriptions of Rule Groups to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Support for like search for description parameter. (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modified times of Rule Groups to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Imported times of Rule Groups to fetch. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking ids of Rule Groups to fetch. (optional) 

            try
            {
                // Search all RuleGroups
                List&lt;RuleGroup&gt; result = apiInstance.GetRuleGroups(pageLimit, pageStart, id, name, description, subDescription, modifiedTime, importedTime, trackingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulegroupsApi.GetRuleGroups: " + e.Message );
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
 **id** | [**List&lt;string&gt;**](string.md)| IDs of Rule Groups to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of Rule Groups to fetch. | [optional] 
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of Rule Groups to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for like search for description parameter. | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modified times of Rule Groups to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Imported times of Rule Groups to fetch. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking ids of Rule Groups to fetch. | [optional] 

### Return type

[**List<RuleGroup>**](RuleGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

