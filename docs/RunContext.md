# IO.Swagger.Model.RunContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndTime** | **string** | Time at which the task completed or was cancelled | [optional] 
**HasErrors** | **bool?** | True if any of the nodes in scope had a problem executing any of the rules | [optional] [default to false]
**Id** | **string** | ID of Run Context | [optional] 
**RunType** | **string** | One of BASELINE_NEW, CHECK or BASELINE_ALL indicating rule run type of the task. | [optional] 
**StartTime** | **string** | Time at which the task began executing | [optional] 
**StopType** | **string** | One of MANUAL, TIMEOUT, or NORMAL, indicating if the task was cancelled by the user, exceeded allowed duration, or finished as expected | [optional] 
**TaskId** | **string** | ID of Task | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

