# IO.Swagger.Model.Waiver
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the waiver. | [optional] 
**Name** | **string** | Name of the waiver. | [optional] 
**Description** | **string** | Descriptive data characterizing the waiver. | [optional] 
**PolicyId** | **string** | Id of the policy this waiver is restricted to. | [optional] 
**PolicyName** | **string** | Name of the policy this waiver is restricted to. | [optional] 
**StartTime** | **string** | When the waiver begins to be valid. | [optional] 
**Expiration** | **string** | When the waiver expires or is no longer valid. | [optional] 
**GrantedBy** | **string** | Identifies who granted the waiver. | [optional] 
**Responsible** | **string** | Identifies who is responsible for fixing the failed tests. | [optional] 
**Closed** | **bool?** | Indicates all operations required prior to expiration have been executed. | [optional] [default to false]
**WaivedTests** | [**List&lt;PolicyTestNodeWaiver&gt;**](PolicyTestNodeWaiver.md) | Set of policy tests and node pairs that have been waived. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

