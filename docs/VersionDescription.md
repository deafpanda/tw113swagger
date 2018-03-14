# IO.Swagger.Model.VersionDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElementName** | **string** | The name of the element | 
**Attributes** | [**Dictionary&lt;string, AttributeValue&gt;**](AttributeValue.md) | The optional attributes map of an element version | [optional] 
**Content** | **string** | The optional content aspect of an element version | [optional] 
**ContentBase64** | **string** | The API will decode this field and use the result as the element version content | [optional] 
**ChangeType** | **string** | The change type for this version: BASELINE, ADDED, MODIFIED, REMOVED. Default is MODIFIED | [optional] 
**Exists** | **bool?** | If false, indicates that the element represents something that was expected but missing. Default is true | [optional] [default to false]
**Severity** | **int?** | A required value from 0 to 10000, indicating the severity of the change. 0 indicates no severity | 
**TimeDetected** | **string** | The timestamp indicating when the data was harvested | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

