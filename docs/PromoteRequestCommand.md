# IO.Swagger.Model.PromoteRequestCommand
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the request | [optional] 
**RequestData** | [**PromoteRequestData**](PromoteRequestData.md) | Data of the request | 
**Status** | **string** | State of the request. Possible values are: PENDING, RUNNING, ABORTED, COMPLETED | [optional] 
**StatusMessage** | **List&lt;Dictionary&lt;string, string&gt;&gt;** | Detailed description of the progress of the request | [optional] 
**CreationTime** | **string** | Timestamp indicating when the request was submitted | [optional] 
**CompletionTime** | **string** | Timestamp indicating when the request finished | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

