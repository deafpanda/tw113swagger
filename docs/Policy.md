# IO.Swagger.Model.Policy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Readable-key identity of this policy | [optional] 
**Name** | **string** | The name of the policy | [optional] 
**Description** | **string** | A description of the policy | [optional] 
**ModifiedTime** | **string** | Timestamp indicating when the policy definition was last modified | [optional] 
**ImportedTime** | **string** | Timestamp indicating when the policy definition was imported from xml | [optional] 
**TrackingId** | **string** | An ID for the policy that is tracked across exports and imports | [optional] 
**PurgeOldData** | **bool?** | If true, TE will clean out results and waivers older than a threshold | [optional] [default to false]
**PurgeDataOlderThanDays** | **int?** | Number of days worth of data to keep when purgeOldData is true | [optional] 
**NodeScope** | **List&lt;string&gt;** | List of nodes or node groups in scope for this policy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

