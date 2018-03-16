# IO.Swagger.Model.Rule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Command line to execute | [optional] 
**Description** | **string** | A description of the rule (modifiable). | [optional] 
**ElementName** | **string** | Name of element to create | [optional] 
**ExcludePattern** | **string** | Regex pattern. If content in output of command match this pattern, the matched string is replaced with the value of replaceString | [optional] 
**Id** | **string** | Readable-key identity of this rule (read only) | [optional] 
**ImportedTime** | **string** | Timestamp indicating when the rule definition was imported from xml (read only) | [optional] 
**ModifiedTime** | **string** | Timestamp indicating when the rule definition was last modified (read only) | [optional] 
**Name** | **string** | The name of the rule (modifiable). | [optional] 
**ReplaceString** | **string** | New value for excludePattern matches | [optional] 
**StartPoints** | [**List&lt;StartPoint&gt;**](StartPoint.md) | A list of locations to beginning scanning for elements | [optional] 
**StopPoints** | [**List&lt;StopPoint&gt;**](StopPoint.md) | A list of locations to stop scanning for elements | [optional] 
**TimeoutMillis** | **long?** | Maximum time to wait for command to execute | [optional] 
**TrackingId** | **string** | An ID for the rule that is tracked across exports and imports (modifiable). | [optional] 
**Type** | **string** | The type of the rule | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

