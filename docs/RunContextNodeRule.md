# IO.Swagger.Model.RunContextNodeRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentType** | **string** | One of CAP, JAVA, or NDI | [optional] 
**ContextId** | **string** | Id of rule run context | [optional] 
**EndTime** | **string** | Time at which the task completed or was cancelled | [optional] 
**HasErrors** | **bool?** | True if rule execution encountered an error | [optional] [default to false]
**HasTimeout** | **bool?** | True if rule timed out executing on node | [optional] [default to false]
**LastUpdated** | **string** | Time the status record was last updated | [optional] 
**NodeId** | **string** | Id of the node | [optional] 
**ReceivedEnd** | **bool?** | True if status of rule execution on the node is complete | [optional] [default to false]
**RuleId** | **string** | Id of the rule | [optional] 
**RunType** | **string** | One of BASELINE_NEW, CHECK or BASELINE_ALL indicating actual rule run type of the task. | [optional] 
**StartTime** | **string** | Time at which the task began executing | [optional] 
**WasCancelled** | **bool?** | True if task was cancelled before rule completed on the node | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

