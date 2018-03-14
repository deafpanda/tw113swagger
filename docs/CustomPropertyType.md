# IO.Swagger.Model.CustomPropertyType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Readable key of custom property type. | [optional] 
**Type** | **string** | One of \&quot;Date\&quot;, \&quot;Numeric\&quot;, \&quot;Select\&quot;, \&quot;Text\&quot;, \&quot;YesNo\&quot;. | 
**Name** | **string** | The name of the property (modifiable). | 
**Description** | **string** | The description of the property (modifiable). | [optional] 
**InheritDefault** | **bool?** | If true, the default value is considered active when objects are queried by custom properties (modifiable). | [default to false]
**DefaultValue** | **string** | The default value for inherited properties. For Numeric types, the value must be a number, for date types, the value must be an ISO8601 formatted date, for Select and YesNo types the value must be in the possible values (modifiable). | 
**MinValue** | **long?** | If type is Numeric, the minimum allowed value for the property (modifiable). | [optional] 
**MaxValue** | **long?** | If type is Numeric, the maximum allowed value for the property (modifiable). | [optional] 
**AvailableValues** | **List&lt;string&gt;** | If type is Select, the set of allowable values for the property (modifiable). | [optional] 
**MaxCharacters** | **int?** | If type is Text, limits the number of characters for the value of the property (modifiable). | [optional] 
**AllowMultilineValues** | **bool?** | If type is Text, allows multiple lines in value (modifiable). | [optional] [default to false]
**TextEditorWidth** | **int?** | If type is Text, provides a UI hint as to the desired width of edit boxes (modifiable). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

