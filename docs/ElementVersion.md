# IO.Swagger.Model.ElementVersion
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Readable-Key identity of the element version | 
**ElementName** | **string** | The name of the element, such as filename, or registry key name | 
**NodeName** | **string** | The name of the Node the element version was detected on | 
**RuleName** | **string** | The name of the rule the defining how the element version should be monitored | 
**ElementId** | **string** | Readable-Key identity of the element | 
**NodeId** | **string** | Readable-Key identity of the node | 
**RuleId** | **string** | Readable-Key identity of the rule | 
**BaselineVersion** | **string** | Readable-key identity of previous baseline element version | 
**ChangeType** | **string** | Indicates if this change is an initial baseline snapshot, a modification, or removal of the element, or an additional element since the last scan | 
**Exists** | **bool?** | True if the element existed on the monitored host at the time of the scan | [default to false]
**Severity** | **int?** | Assigned severity for this element based on options in the rule, startpoints, and attribute criteria (modifiable) | 
**TimeDetected** | **string** | Timestamp indicating when the scanning mechanism detected the change | 
**TimeReceived** | **string** | Timestamp indicating when the Tripwire Enterprise server received the change | [optional] 
**PromotionComment** | **string** | User supplied meta data assigned when element versions are promoted to approved state | 
**ApprovalId** | **string** | User supplied id used to correlate approvals to external tracking systems | 
**OutsideMaintenanceWindow** | **bool?** |  | [default to false]
**ScanId** | **string** | An id assigned to the scan occurance | 
**Md5** | **string** | The MD5 hash of the content of this element version | 
**Sha1** | **string** | The SHA-1 hash of the content of this element version | 
**Sha256** | **string** | The SHA-256 hash of the content of this element version | 
**Sha512** | **string** | The SHA-512 hash of the content of this element version | 
**IsPromoted** | **bool?** | True if the element version has been promoted | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

