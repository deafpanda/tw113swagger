# IO.Swagger.Api.PolicytestresultsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRemediation**](PolicytestresultsApi.md#createremediation) | **POST** /policytestresults/remediationRequests | Submit request for the automated remediation. (since 1.5)
[**GetLatestPolicyTestResults**](PolicytestresultsApi.md#getlatestpolicytestresults) | **GET** /policytestresults/latest | Search the latest policy test results
[**GetPolicyTestResultById**](PolicytestresultsApi.md#getpolicytestresultbyid) | **GET** /policytestresults/{rkPolicyTestResultId} | Get policy test result details by ID
[**GetPolicyTestResults**](PolicytestresultsApi.md#getpolicytestresults) | **GET** /policytestresults | Search all policy test results
[**GetRemediationById**](PolicytestresultsApi.md#getremediationbyid) | **GET** /policytestresults/remediationRequests/{requestId} | Get the status of a remediationRequest (since 1.5)
[**GetUnknownTestResults**](PolicytestresultsApi.md#getunknowntestresults) | **GET** /policytestresults/unknownTestResults | Get a list of missing results (since 1.8)
[**PolicyTestResultsExtract**](PolicytestresultsApi.md#policytestresultsextract) | **GET** /policytestresults/_extract | Extract large sets of policy test results incrementally (since 1.8)


<a name="createremediation"></a>
# **CreateRemediation**
> RemediationRequestCommand CreateRemediation (RemediationRequestCommand body)

Submit request for the automated remediation. (since 1.5)

Create and execute a work order for the remediation of policy test result failures using the automated remediation scripts attached to policy tests.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRemediationExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var body = new RemediationRequestCommand(); // RemediationRequestCommand | A request for Policy Test Results Remediation

            try
            {
                // Submit request for the automated remediation. (since 1.5)
                RemediationRequestCommand result = apiInstance.CreateRemediation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.CreateRemediation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RemediationRequestCommand**](RemediationRequestCommand.md)| A request for Policy Test Results Remediation | 

### Return type

[**RemediationRequestCommand**](RemediationRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatestpolicytestresults"></a>
# **GetLatestPolicyTestResults**
> List<PolicyTestResult> GetLatestPolicyTestResults (string pageLimit = null, string pageStart = null, List<string> id = null, List<string> policyTestId = null, List<string> policyTestName = null, List<string> elementId = null, List<string> elementName = null, List<string> elementVersionId = null, List<string> nodeId = null, List<string> nodeLabel = null, List<string> state = null, List<string> creationTime = null, string creationTimeRange = null)

Search the latest policy test results

Returns a list of only those policy test results that are the latest result for a given policy test and node combination, or of those, the results that match the filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLatestPolicyTestResultsExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var id = new List<string>(); // List<string> | IDs of policy test results to fetch. (optional) 
            var policyTestId = new List<string>(); // List<string> | Policy Test IDs of policy test results to fetch. (optional) 
            var policyTestName = new List<string>(); // List<string> | Policy test names of policy test results to fetch. (optional) 
            var elementId = new List<string>(); // List<string> | Element IDs of policy tests results to fetch. (optional) 
            var elementName = new List<string>(); // List<string> | Element names of policy tests results to fetch. (optional) 
            var elementVersionId = new List<string>(); // List<string> | Element version IDs of policy tests results to fetch. (optional) 
            var nodeId = new List<string>(); // List<string> | Node IDs of policy test results to fetch. (optional) 
            var nodeLabel = new List<string>(); // List<string> | Node labels of policy test results to fetch. (optional) 
            var state = state_example;  // List<string> | States of policy test results to fetch. Possible values: PASSED, FAILED, UNKNOWN, ERROR. (optional) 
            var creationTime = new List<string>(); // List<string> | States of policy test results to fetch. Possible values: PASSED, FAILED, UNKNOWN, ERROR. (optional) 
            var creationTimeRange = creationTimeRange_example;  // string | Creation time range of policy test results to fetch (optional) 

            try
            {
                // Search the latest policy test results
                List&lt;PolicyTestResult&gt; result = apiInstance.GetLatestPolicyTestResults(pageLimit, pageStart, id, policyTestId, policyTestName, elementId, elementName, elementVersionId, nodeId, nodeLabel, state, creationTime, creationTimeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.GetLatestPolicyTestResults: " + e.Message );
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
 **id** | [**List&lt;string&gt;**](string.md)| IDs of policy test results to fetch. | [optional] 
 **policyTestId** | [**List&lt;string&gt;**](string.md)| Policy Test IDs of policy test results to fetch. | [optional] 
 **policyTestName** | [**List&lt;string&gt;**](string.md)| Policy test names of policy test results to fetch. | [optional] 
 **elementId** | [**List&lt;string&gt;**](string.md)| Element IDs of policy tests results to fetch. | [optional] 
 **elementName** | [**List&lt;string&gt;**](string.md)| Element names of policy tests results to fetch. | [optional] 
 **elementVersionId** | [**List&lt;string&gt;**](string.md)| Element version IDs of policy tests results to fetch. | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Node IDs of policy test results to fetch. | [optional] 
 **nodeLabel** | [**List&lt;string&gt;**](string.md)| Node labels of policy test results to fetch. | [optional] 
 **state** | **List&lt;string&gt;**| States of policy test results to fetch. Possible values: PASSED, FAILED, UNKNOWN, ERROR. | [optional] 
 **creationTime** | [**List&lt;string&gt;**](string.md)| States of policy test results to fetch. Possible values: PASSED, FAILED, UNKNOWN, ERROR. | [optional] 
 **creationTimeRange** | **string**| Creation time range of policy test results to fetch | [optional] 

### Return type

[**List<PolicyTestResult>**](PolicyTestResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytestresultbyid"></a>
# **GetPolicyTestResultById**
> PolicyTestResult GetPolicyTestResultById (string rkPolicyTestResultId)

Get policy test result details by ID

Returns details of a single policy test result.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyTestResultByIdExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var rkPolicyTestResultId = rkPolicyTestResultId_example;  // string | rkPolicyTestResultId to fetch

            try
            {
                // Get policy test result details by ID
                PolicyTestResult result = apiInstance.GetPolicyTestResultById(rkPolicyTestResultId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.GetPolicyTestResultById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rkPolicyTestResultId** | **string**| rkPolicyTestResultId to fetch | 

### Return type

[**PolicyTestResult**](PolicyTestResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytestresults"></a>
# **GetPolicyTestResults**
> List<PolicyTestResult> GetPolicyTestResults (string pageLimit = null, string pageStart = null, List<string> id = null, List<string> policyTestId = null, List<string> policyTestName = null, List<string> elementId = null, List<string> elementName = null, List<string> elementVersionId = null, List<string> nodeId = null, List<string> nodeLabel = null, List<string> state = null, List<string> creationTime = null, string creationTimeRange = null, string at = null)

Search all policy test results

Returns a list of all policy test results or those that match the provided filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPolicyTestResultsExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var pageStart = pageStart_example;  // string | Page start for paging support (optional) 
            var id = new List<string>(); // List<string> | IDs of policy test results to fetch. (optional) 
            var policyTestId = new List<string>(); // List<string> | Policy Test IDs of policy test results to fetch. (optional) 
            var policyTestName = new List<string>(); // List<string> | Policy test names of policy test results to fetch. (optional) 
            var elementId = new List<string>(); // List<string> | Element IDs of policy tests results to fetch. (optional) 
            var elementName = new List<string>(); // List<string> | Element names of policy tests results to fetch. (optional) 
            var elementVersionId = new List<string>(); // List<string> | Element version IDs of policy tests results to fetch. (optional) 
            var nodeId = new List<string>(); // List<string> | Node IDs of policy test results to fetch. (optional) 
            var nodeLabel = new List<string>(); // List<string> | Node labels of policy test results to fetch. (optional) 
            var state = state_example;  // List<string> | States of policy test results to fetch. Possible values: PASSED, FAILED, UNKNOWN, ERROR. (optional) 
            var creationTime = new List<string>(); // List<string> | Creation times of policy test results to fetch. (optional) 
            var creationTimeRange = creationTimeRange_example;  // string | Creation time range of policy test results to fetch (optional) 
            var at = at_example;  // string | Include the latest policy test results that are at or prior to the specified time. (optional) 

            try
            {
                // Search all policy test results
                List&lt;PolicyTestResult&gt; result = apiInstance.GetPolicyTestResults(pageLimit, pageStart, id, policyTestId, policyTestName, elementId, elementName, elementVersionId, nodeId, nodeLabel, state, creationTime, creationTimeRange, at);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.GetPolicyTestResults: " + e.Message );
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
 **id** | [**List&lt;string&gt;**](string.md)| IDs of policy test results to fetch. | [optional] 
 **policyTestId** | [**List&lt;string&gt;**](string.md)| Policy Test IDs of policy test results to fetch. | [optional] 
 **policyTestName** | [**List&lt;string&gt;**](string.md)| Policy test names of policy test results to fetch. | [optional] 
 **elementId** | [**List&lt;string&gt;**](string.md)| Element IDs of policy tests results to fetch. | [optional] 
 **elementName** | [**List&lt;string&gt;**](string.md)| Element names of policy tests results to fetch. | [optional] 
 **elementVersionId** | [**List&lt;string&gt;**](string.md)| Element version IDs of policy tests results to fetch. | [optional] 
 **nodeId** | [**List&lt;string&gt;**](string.md)| Node IDs of policy test results to fetch. | [optional] 
 **nodeLabel** | [**List&lt;string&gt;**](string.md)| Node labels of policy test results to fetch. | [optional] 
 **state** | **List&lt;string&gt;**| States of policy test results to fetch. Possible values: PASSED, FAILED, UNKNOWN, ERROR. | [optional] 
 **creationTime** | [**List&lt;string&gt;**](string.md)| Creation times of policy test results to fetch. | [optional] 
 **creationTimeRange** | **string**| Creation time range of policy test results to fetch | [optional] 
 **at** | **string**| Include the latest policy test results that are at or prior to the specified time. | [optional] 

### Return type

[**List<PolicyTestResult>**](PolicyTestResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremediationbyid"></a>
# **GetRemediationById**
> RemediationRequestCommand GetRemediationById (string requestId)

Get the status of a remediationRequest (since 1.5)

Returns the remediationRequest updated with the latest status for the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemediationByIdExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var requestId = requestId_example;  // string | Id of request to fetch

            try
            {
                // Get the status of a remediationRequest (since 1.5)
                RemediationRequestCommand result = apiInstance.GetRemediationById(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.GetRemediationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| Id of request to fetch | 

### Return type

[**RemediationRequestCommand**](RemediationRequestCommand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunknowntestresults"></a>
# **GetUnknownTestResults**
> List<UnknownPolicyTestResult> GetUnknownTestResults (string at = null)

Get a list of missing results (since 1.8)

Returns an enumeration of every policy test for nodes that are in scope for which there is no result in TE, either because it has been deleted or has never been successfully scanned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUnknownTestResultsExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var at = at_example;  // string | Return status of unknown test results as of the given timestamp, excluding test results that are newer. This is from the perspective of the current policy scoping configuration. (optional) 

            try
            {
                // Get a list of missing results (since 1.8)
                List&lt;UnknownPolicyTestResult&gt; result = apiInstance.GetUnknownTestResults(at);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.GetUnknownTestResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **at** | **string**| Return status of unknown test results as of the given timestamp, excluding test results that are newer. This is from the perspective of the current policy scoping configuration. | [optional] 

### Return type

[**List<UnknownPolicyTestResult>**](UnknownPolicyTestResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policytestresultsextract"></a>
# **PolicyTestResultsExtract**
> List<PolicyTestResult> PolicyTestResultsExtract (string pageLimit = null, string previousId = null, string creationTimeRange = null)

Extract large sets of policy test results incrementally (since 1.8)

Search for policy test results by time ranges. Results will be sorted by the policy test result id, in ascending order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PolicyTestResultsExtractExample
    {
        public void main()
        {
            var apiInstance = new PolicytestresultsApi();
            var pageLimit = pageLimit_example;  // string | Page limit for paging support (optional) 
            var previousId = previousId_example;  // string | When paging, this should be the last policy test result id returned by the previous page. (optional) 
            var creationTimeRange = creationTimeRange_example;  // string | Creation time range of policy test results to fetch (optional) 

            try
            {
                // Extract large sets of policy test results incrementally (since 1.8)
                List&lt;PolicyTestResult&gt; result = apiInstance.PolicyTestResultsExtract(pageLimit, previousId, creationTimeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicytestresultsApi.PolicyTestResultsExtract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageLimit** | **string**| Page limit for paging support | [optional] 
 **previousId** | **string**| When paging, this should be the last policy test result id returned by the previous page. | [optional] 
 **creationTimeRange** | **string**| Creation time range of policy test results to fetch | [optional] 

### Return type

[**List<PolicyTestResult>**](PolicyTestResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

