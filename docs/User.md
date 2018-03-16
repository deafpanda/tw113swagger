# IO.Swagger.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Builtin** | **bool?** | If true, the user is provided by Tripwire Enterprise and cannot be modified or removed (restrictions: read-only) | [optional] [default to false]
**Description** | **string** | Free form notes describing the user (modifiable). | [optional] 
**Email** | **string** | An email address for the user (modifiable). | [optional] 
**Id** | **string** | Readable-Key identity of the user | [optional] 
**LastLogin** | **string** | A timestamp noting the last time the user logged into Tripwire Enterprise (restrictions: read-only) | [optional] 
**LastLogout** | **string** | A timestamp noting the last time the user logged out of Tripwire Enterprise (restrictions: read-only) | [optional] 
**Name** | **string** | The login name of the user (modifiable). | 
**RoleId** | **string** | The id of the role associated to the user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

