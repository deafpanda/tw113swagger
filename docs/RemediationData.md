# IO.Swagger.Model.RemediationData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyTestResultIds** | **List&lt;string&gt;** | The list of policy test results to remediate | 
**ApprovalId** | **string** | Correlation ID for tracking approval of the work order | 
**ApprovalComment** | **string** | Additional meta-data for work order approvals | [optional] 
**DeleteWhenComplete** | **bool?** | if true, after the work order has finished execution and been closed, it will also be deleted from Tripwire Enterprise | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

