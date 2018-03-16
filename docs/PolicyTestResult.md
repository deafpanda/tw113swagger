# IO.Swagger.Model.PolicyTestResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actual** | **string** | The actual value found on the node | [optional] 
**CreationTime** | **string** | Timestamp indicating when this policy test result was produced. | [optional] 
**ElementId** | **string** | The ID of the element that produced this policy test result. | [optional] 
**ElementName** | **string** | The name of the element that produced this policy test result. | [optional] 
**ElementVersionId** | **string** | The ID of the element version that produced this policy test result. | [optional] 
**Expected** | **string** | The value or expression required to pass the test | [optional] 
**Id** | **string** | Readable-key identity of the policy test result | [optional] 
**NodeId** | **string** | Readable-key identity of the node that produced this result | [optional] 
**NodeLabel** | **string** | Name of the node that produced this result | [optional] 
**PolicyTestId** | **string** | Readable-key identity of the policy test that produced this result | [optional] 
**PolicyTestName** | **string** | Name of the policy test that produced this result | [optional] 
**State** | **string** | One of PASSED, FAILED, ERROR, or UNKNOWN, where UNKNOWN indicates no result value was produced, ERROR indicates that policy test evaluation failed, and PASSED or FAILED indicate the compliance state | [optional] 
**SummaryState** | **string** | Summary state for all element versions that comprise the policy test result. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

