# IO.Swagger.Api.PoliciesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePolicy**](PoliciesApi.md#deletepolicy) | **DELETE** /policies/{rkPolicyId} | Delete a policy (since 1.11)
[**GetIncludedNodes**](PoliciesApi.md#getincludednodes) | **GET** /policies/{rkPolicyId}/includedNodes | Get included nodes of a policy (since 1.5)
[**GetPolicies**](PoliciesApi.md#getpolicies) | **GET** /policies | Search policies (since 1.5)
[**GetPolicyById**](PoliciesApi.md#getpolicybyid) | **GET** /policies/{rkPolicyId} | Get policy details by ID (since 1.5)
[**RunPolicies**](PoliciesApi.md#runpolicies) | **POST** /policies/run | Post a request to run policies (since 1.5)


<a name="deletepolicy"></a>
# **DeletePolicy**
> void DeletePolicy (string rkPolicyId)

Delete a policy (since 1.11)

Removes a policy, leaving any child policy groups and tests in the unlinked group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePolicyExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var rkPolicyId = rkPolicyId_example;  // string | ID of policy to delete

            try
            {
                // Delete a policy (since 1.11)
                apiInstance.DeletePolicy(rkPolicyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyId** | **string**| ID of policy to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getincludednodes"></a>
# **GetIncludedNodes**
> string GetIncludedNodes (string rkPolicyId)

Get included nodes of a policy (since 1.5)

Returns a list of all nodes in scope for a policy by virtue of the 3 policy level node scoping criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIncludedNodesExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var rkPolicyId = rkPolicyId_example;  // string | ID of policy to fetch

            try
            {
                // Get included nodes of a policy (since 1.5)
                string result = apiInstance.GetIncludedNodes(rkPolicyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetIncludedNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyId** | **string**| ID of policy to fetch | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicies"></a>
# **GetPolicies**
> Policy GetPolicies (List<string> description = null, List<string> id = null, List<string> importedTime = null, string importedTimeRange = null, List<string> modifiedTime = null, List<string> name = null, List<string> nodeScope = null, string pageLimit = null, string pageStart = null, List<string> purgeDataOlderThanDays = null, bool? purgeOldData = null, List<string> subDescription = null, List<string> trackingId = null)

Search policies (since 1.5)

Returns a list of all policies or those that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPoliciesExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var description = new List<string>(); // List<string> | Descriptions of policies to fetch. (optional) 
            var id = new List<string>(); // List<string> | IDs of policies to fetch. (optional) 
            var importedTime = new List<string>(); // List<string> | Imported times of policies to fetch. (optional) 
            var importedTimeRange = importedTimeRange_example;  // string | Imported time range of policy to fetch (optional) 
            var modifiedTime = new List<string>(); // List<string> | Modified times of policies to fetch. (optional) 
            var name = new List<string>(); // List<string> | Names of policies to fetch. (optional) 
            var nodeScope = new List<string>(); // List<string> | Node scopes of policies to fetch. (optional) 
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var purgeDataOlderThanDays = new List<string>(); // List<string> | Days to purge old data of policies to fetch. (optional) 
            var purgeOldData = true;  // bool? | If should be purged old data of policies to fetch. (optional) 
            var subDescription = new List<string>(); // List<string> | Support for like search for description parameter. (optional) 
            var trackingId = new List<string>(); // List<string> | Tracking IDs of policies to fetch. (optional) 

            try
            {
                // Search policies (since 1.5)
                Policy result = apiInstance.GetPolicies(description, id, importedTime, importedTimeRange, modifiedTime, name, nodeScope, pageLimit, pageStart, purgeDataOlderThanDays, purgeOldData, subDescription, trackingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **description** | [**List&lt;string&gt;**](string.md)| Descriptions of policies to fetch. | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| IDs of policies to fetch. | [optional] 
 **importedTime** | [**List&lt;string&gt;**](string.md)| Imported times of policies to fetch. | [optional] 
 **importedTimeRange** | **string**| Imported time range of policy to fetch | [optional] 
 **modifiedTime** | [**List&lt;string&gt;**](string.md)| Modified times of policies to fetch. | [optional] 
 **name** | [**List&lt;string&gt;**](string.md)| Names of policies to fetch. | [optional] 
 **nodeScope** | [**List&lt;string&gt;**](string.md)| Node scopes of policies to fetch. | [optional] 
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **pageStart** | **string**| Page start for paging support | [optional] 
 **purgeDataOlderThanDays** | [**List&lt;string&gt;**](string.md)| Days to purge old data of policies to fetch. | [optional] 
 **purgeOldData** | **bool?**| If should be purged old data of policies to fetch. | [optional] 
 **subDescription** | [**List&lt;string&gt;**](string.md)| Support for like search for description parameter. | [optional] 
 **trackingId** | [**List&lt;string&gt;**](string.md)| Tracking IDs of policies to fetch. | [optional] 

### Return type

[**Policy**](Policy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicybyid"></a>
# **GetPolicyById**
> Policy GetPolicyById (string rkPolicyId)

Get policy details by ID (since 1.5)

Returns the details of a single policy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyByIdExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var rkPolicyId = rkPolicyId_example;  // string | ID of policy to fetch

            try
            {
                // Get policy details by ID (since 1.5)
                Policy result = apiInstance.GetPolicyById(rkPolicyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyId** | **string**| ID of policy to fetch | 

### Return type

[**Policy**](Policy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runpolicies"></a>
# **RunPolicies**
> void RunPolicies (PolicyRun body = null)

Post a request to run policies (since 1.5)

Allows evaluation of policy test criteria against previously harvested element versions for a specified set of policies and nodes. This does not harvest state from monitored hosts.   Use this after updating or importing policy content to refresh policy test results.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunPoliciesExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var body = new PolicyRun(); // PolicyRun | List of Policies and list of Nodes where Policies should be run. List of Nodes is optional. (optional) 

            try
            {
                // Post a request to run policies (since 1.5)
                apiInstance.RunPolicies(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.RunPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PolicyRun**](PolicyRun.md)| List of Policies and list of Nodes where Policies should be run. List of Nodes is optional. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

