# IO.Swagger.Model.Role
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Readable-Key identity for the role (restrictions: read-only) | 
**Name** | **string** | Name of the role (modifiable). | 
**Description** | **string** | Long description of the purpose of the role (modifiable). | 
**Builtin** | **bool?** | Indicates if the role is defined internal by Tripwire Enterprise. Builtin roles cannot be changed. (restrictions: read-only) | [optional] [default to false]
**Administrator** | **bool?** | Indicates if the role implies full Administrator permissions. (restrictions: read-only) | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

