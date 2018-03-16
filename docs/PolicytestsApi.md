# IO.Swagger.Api.PolicytestsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePolicyTest**](PolicytestsApi.md#deletepolicytest) | **DELETE** /policytests/{rkPolicyTestId} | Delete a policy test (since 1.11)
[**GetExcludedNodes**](PolicytestsApi.md#getexcludednodes) | **GET** /policytests/{rkPolicyTestId}/excludedNodes | Get excluded nodes of a policy test (since 1.5)
[**GetPolicyTestById**](PolicytestsApi.md#getpolicytestbyid) | **GET** /policytests/{rkPolicyTestId} | Get policy test details by ID (since 1.5)
[**GetPolicyTestParentGroups**](PolicytestsApi.md#getpolicytestparentgroups) | **GET** /policytests/{rkPolicyTestId}/parentGroups | List parent groups for a policy test (since 1.5)
[**GetPolicyTestRemediation**](PolicytestsApi.md#getpolicytestremediation) | **GET** /policytests/{rkPolicyTestId}/remediation | Get remediation details of a policy test (since 1.5)
[**GetPolicyTests**](PolicytestsApi.md#getpolicytests) | **GET** /policytests | Search policy tests (since 1.5)


<a name="deletepolicytest"></a>
# **DeletePolicyTest**
> void DeletePolicyTest (string rkPolicyTestId)

Delete a policy test (since 1.11)

Removes a policy test and any related policy test results.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePolicyTestExample
    {
        public void main()
        {
            var apiInstance = new PolicytestsApi();
            var rkPolicyTestId = rkPolicyTestId_example;  // string | ID of policy test to delete

            try
            {
                // Delete a policy test (since 1.11)
                apiInstance.DeletePolicyTest(rkPolicyTestId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestsApi.DeletePolicyTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyTestId** | **string**| ID of policy test to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexcludednodes"></a>
# **GetExcludedNodes**
> string GetExcludedNodes (string rkPolicyTestId)

Get excluded nodes of a policy test (since 1.5)

Return a list of nodes that are excluded from this policy test by virtue of the node exclusions criteria on the policy test. This includes all descendants of all node groups in the criteria, as well as explicitly indicated nodes, fully expanded to a node list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExcludedNodesExample
    {
        public void main()
        {
            var apiInstance = new PolicytestsApi();
            var rkPolicyTestId = rkPolicyTestId_example;  // string | rkPolicyTestId to fetch

            try
            {
                // Get excluded nodes of a policy test (since 1.5)
                string result = apiInstance.GetExcludedNodes(rkPolicyTestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestsApi.GetExcludedNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyTestId** | **string**| rkPolicyTestId to fetch | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytestbyid"></a>
# **GetPolicyTestById**
> PolicyTest GetPolicyTestById (string rkPolicyTestId)

Get policy test details by ID (since 1.5)

Returns the details of a single policy test.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyTestByIdExample
    {
        public void main()
        {
            var apiInstance = new PolicytestsApi();
            var rkPolicyTestId = rkPolicyTestId_example;  // string | rkPolicyTestId to fetch

            try
            {
                // Get policy test details by ID (since 1.5)
                PolicyTest result = apiInstance.GetPolicyTestById(rkPolicyTestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestsApi.GetPolicyTestById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyTestId** | **string**| rkPolicyTestId to fetch | 

### Return type

[**PolicyTest**](PolicyTest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytestparentgroups"></a>
# **GetPolicyTestParentGroups**
> PolicyTestGroupPath GetPolicyTestParentGroups (string rkPolicyTestId)

List parent groups for a policy test (since 1.5)

Returns a list of the parent groups for a policy test with a specific ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyTestParentGroupsExample
    {
        public void main()
        {
            var apiInstance = new PolicytestsApi();
            var rkPolicyTestId = rkPolicyTestId_example;  // string | rkPolicyTestId to fetch

            try
            {
                // List parent groups for a policy test (since 1.5)
                PolicyTestGroupPath result = apiInstance.GetPolicyTestParentGroups(rkPolicyTestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestsApi.GetPolicyTestParentGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyTestId** | **string**| rkPolicyTestId to fetch | 

### Return type

[**PolicyTestGroupPath**](PolicyTestGroupPath.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytestremediation"></a>
# **GetPolicyTestRemediation**
> Remediation GetPolicyTestRemediation (string rkPolicyTestId)

Get remediation details of a policy test (since 1.5)

Returns the remediation details of a policy test.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyTestRemediationExample
    {
        public void main()
        {
            var apiInstance = new PolicytestsApi();
            var rkPolicyTestId = rkPolicyTestId_example;  // string | rkPolicyTestId

            try
            {
                // Get remediation details of a policy test (since 1.5)
                Remediation result = apiInstance.GetPolicyTestRemediation(rkPolicyTestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestsApi.GetPolicyTestRemediation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyTestId** | **string**| rkPolicyTestId | 

### Return type

[**Remediation**](Remediation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytests"></a>
# **GetPolicyTests**
> PolicyTest GetPolicyTests (List<string> description = null, List<string> id = null, List<string> importedTime = null, string importedTimeRange = null, List<string> modifiedTime = null, List<string> name = null, string pageLimit = null, string pageStart = null, List<string> policyId = null, List<string> rules = null, List<string> severity = null, List<string> subDescription = null, List<string> trackingId = null, List<string> type = null)

Search policy tests (since 1.5)

Returns a list of all policy tests or those that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyTestsExample
    {
        public void main()
        {
            var apiInstance = new PolicytestsApi();
            var description = new List<string>(); // List<string> | Descriptions of policy tests to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of policy tests to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Import times of policy tests to fetch. (optional) 
            var importedTimeRange = importedTimeRange_example;  // string | Imported time range of policy tests to fetch (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modification times of policy tests to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of Policy Tests to fetch. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var policyId = new List<string>(); // List<string> | IDs of policies associated to policy tests to fetch. (optional) 
            var rules = new List<string>(); // List<string> | IDs of rules associated to version tests to fetch. (optional) 
            var severity = new List<string>(); // List<string> | Severity levels of policy test to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Like descriptions of policy Tests to fetch. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking IDs of policy tests to fetch. (optional) 
            var type = new List<string>(); // List<string> | Types of version tests to fetch. (optional) 

            try
            {
                // Search policy tests (since 1.5)
                PolicyTest result = apiInstance.GetPolicyTests(description, id, importedTime, importedTimeRange, modifiedTime, name, pageLimit, pageStart, policyId, rules, severity, subDescription, trackingId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestsApi.GetPolicyTests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of policy tests to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of policy tests to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Import times of policy tests to fetch. | [optional] 
 **importedTimeRange** | **string**| Imported time range of policy tests to fetch | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modification times of policy tests to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of Policy Tests to fetch. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **policyId** | [**List&lt;string&gt;**](string.md)| IDs of policies associated to policy tests to fetch. | [optional] 
 **rules** | [**List&lt;string&gt;**](string.md)| IDs of rules associated to version tests to fetch. | [optional] 
 **severity** | [**List&lt;string&gt;**](string.md)| Severity levels of policy test to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Like descriptions of policy Tests to fetch. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking IDs of policy tests to fetch. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Types of version tests to fetch. | [optional] 

### Return type

[**PolicyTest**](PolicyTest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

