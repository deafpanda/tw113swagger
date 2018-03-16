# IO.Swagger.Model.Waiver
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Closed** | **bool?** | Indicates all operations required prior to expiration have been executed. | [optional] [default to false]
**Description** | **string** | Descriptive data characterizing the waiver. | [optional] 
**Expiration** | **string** | When the waiver expires or is no longer valid. | [optional] 
**GrantedBy** | **string** | Identifies who granted the waiver. | [optional] 
**Id** | **string** | Id of the waiver. | [optional] 
**Name** | **string** | Name of the waiver. | [optional] 
**PolicyId** | **string** | Id of the policy this waiver is restricted to. | [optional] 
**PolicyName** | **string** | Name of the policy this waiver is restricted to. | [optional] 
**Responsible** | **string** | Identifies who is responsible for fixing the failed tests. | [optional] 
**StartTime** | **string** | When the waiver begins to be valid. | [optional] 
**WaivedTests** | [**List&lt;PolicyTestNodeWaiver&gt;**](PolicyTestNodeWaiver.md) | Set of policy tests and node pairs that have been waived. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

