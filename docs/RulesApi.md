# IO.Swagger.Api.RulesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRule**](RulesApi.md#createrule) | **POST** /rules | Create a new rule (since 1.5)
[**DeleteRule**](RulesApi.md#deleterule) | **DELETE** /rules/{rkRuleId} | Delete a rule (since 1.13)
[**GetRuleById**](RulesApi.md#getrulebyid) | **GET** /rules/{rkRuleId} | Get rule details by ID (since 1.5)
[**GetRuleParentGroups**](RulesApi.md#getruleparentgroups) | **GET** /rules/{rkRuleId}/parentGroups | List parent groups for a rule (since 1.5)
[**GetRules**](RulesApi.md#getrules) | **GET** /rules | Search rules (since 1.5)
[**UpdateRule**](RulesApi.md#updaterule) | **PUT** /rules/{rkRuleId} | Update details of a rule (since 1.5)


<a name="createrule"></a>
# **CreateRule**
> Rule CreateRule (Rule body)

Create a new rule (since 1.5)

Creates a rule of the given type. Type must be \"External Rule\" or \"Command Output Capture Rule\". Rules created are in the unlinked rule group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRuleExample
    {
        public void main()
        {
            var apiInstance = new RulesApi();
            var body = new Rule(); // Rule | Rule object to be created in TE

            try
            {
                // Create a new rule (since 1.5)
                Rule result = apiInstance.CreateRule(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.CreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Rule**](Rule.md)| Rule object to be created in TE | 

### Return type

[**Rule**](Rule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterule"></a>
# **DeleteRule**
> void DeleteRule (string rkRuleId)

Delete a rule (since 1.13)

Delete a rule, along with any results associated to the rule. Will fail if rule in direct use by tasks, reports, etc as a scoped target.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRuleExample
    {
        public void main()
        {
            var apiInstance = new RulesApi();
            var rkRuleId = rkRuleId_example;  // string | ID of rule to be deleted

            try
            {
                // Delete a rule (since 1.13)
                apiInstance.DeleteRule(rkRuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.DeleteRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleId** | **string**| ID of rule to be deleted | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulebyid"></a>
# **GetRuleById**
> Rule GetRuleById (string rkRuleId)

Get rule details by ID (since 1.5)

Returns the details of a single rule.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleByIdExample
    {
        public void main()
        {
            var apiInstance = new RulesApi();
            var rkRuleId = rkRuleId_example;  // string | ID of rule to fetch

            try
            {
                // Get rule details by ID (since 1.5)
                Rule result = apiInstance.GetRuleById(rkRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.GetRuleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleId** | **string**| ID of rule to fetch | 

### Return type

[**Rule**](Rule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruleparentgroups"></a>
# **GetRuleParentGroups**
> RuleGroupPath GetRuleParentGroups (string rkRuleId)

List parent groups for a rule (since 1.5)

Returns a list of the parent groups for a rule with a specific ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleParentGroupsExample
    {
        public void main()
        {
            var apiInstance = new RulesApi();
            var rkRuleId = rkRuleId_example;  // string | ID of the Rule

            try
            {
                // List parent groups for a rule (since 1.5)
                RuleGroupPath result = apiInstance.GetRuleParentGroups(rkRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.GetRuleParentGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleId** | **string**| ID of the Rule | 

### Return type

[**RuleGroupPath**](RuleGroupPath.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrules"></a>
# **GetRules**
> Rule GetRules (List<string> description = null, List<string> elementName = null, List<string> id = null, List<string> importedTime = null, string importedTimeRange = null, List<string> modifiedTime = null, List<string> name = null, List<string> oid = null, string pageLimit = null, string pageStart = null, List<string> subDescription = null, List<string> timeoutMillis = null, List<string> trackingId = null, List<string> type = null)

Search rules (since 1.5)

Returns a list of all rules or those that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRulesExample
    {
        public void main()
        {
            var apiInstance = new RulesApi();
            var description = new List<string>(); // List<string> | Descriptions of rules to fetch. (optional) 
            var elementName = new List<string>(); // List<string> | Include Command Output Capture Rules with matching element name (optional) 
            var id = new List<string>(); // List<string> | IDs of rules to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Imported times of rules to fetch. (optional) 
            var importedTimeRange = importedTimeRange_example;  // string | Imported time range of rules to fetch. (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modified times of rules to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of rules to fetch. (optional) 
            var oid = new List<string>(); // List<string> | Return rules with the given database object id. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var subDescription = new List<string>(); // List<string> | Support for substring search for description parameter. (optional) 
            var timeoutMillis = new List<string>(); // List<string> | Include Command Output Capture Rules with matching timeout in milliseconds (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking ids of rules to fetch. (optional) 
            var type = new List<string>(); // List<string> | Types of rules to fetch. (optional) 

            try
            {
                // Search rules (since 1.5)
                Rule result = apiInstance.GetRules(description, elementName, id, importedTime, importedTimeRange, modifiedTime, name, oid, pageLimit, pageStart, subDescription, timeoutMillis, trackingId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.GetRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of rules to fetch. | [optional] 
 **elementName** | [**List&lt;string&gt;**](string.md)| Include Command Output Capture Rules with matching element name | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of rules to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Imported times of rules to fetch. | [optional] 
 **importedTimeRange** | **string**| Imported time range of rules to fetch. | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modified times of rules to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of rules to fetch. | [optional] 
 **oid** | [**List&lt;string&gt;**](string.md)| Return rules with the given database object id. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for substring search for description parameter. | [optional] 
 **timeoutMillis** | [**List&lt;string&gt;**](string.md)| Include Command Output Capture Rules with matching timeout in milliseconds | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking ids of rules to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Types of rules to fetch. | [optional] 

### Return type

[**Rule**](Rule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterule"></a>
# **UpdateRule**
> Rule UpdateRule (string rkRuleId, Rule body)

Update details of a rule (since 1.5)

Modifies a rule updating the rule fields with those submitted in the request. Submitted read-only fields will not be updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRuleExample
    {
        public void main()
        {
            var apiInstance = new RulesApi();
            var rkRuleId = rkRuleId_example;  // string | ID of rule to be updated
            var body = new Rule(); // Rule | Rule description to update the existing rule

            try
            {
                // Update details of a rule (since 1.5)
                Rule result = apiInstance.UpdateRule(rkRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.UpdateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkRuleId** | **string**| ID of rule to be updated | 
 **body** | [**Rule**](Rule.md)| Rule description to update the existing rule | 

### Return type

[**Rule**](Rule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

