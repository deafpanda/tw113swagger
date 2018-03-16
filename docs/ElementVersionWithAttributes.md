# IO.Swagger.Model.ElementVersionWithAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalId** | **string** | User supplied id used to correlate approvals to external tracking systems | 
**Attributes** | [**Dictionary&lt;string, ValueTypeAttribute&gt;**](ValueTypeAttribute.md) | ElementVersion attributes, will only be showned if exists is true | 
**Audits** | [**List&lt;AuditInfo&gt;**](AuditInfo.md) | A list of the associated audit event data collected for this element version. | 
**BaselineVersion** | **string** | Readable-key identity of previous baseline element version | 
**ChangeType** | **string** | Indicates if this change is an initial baseline snapshot, a modification, or removal of the element, or an additional element since the last scan | 
**ElementId** | **string** | Readable-Key identity of the element | 
**ElementName** | **string** | The name of the element, such as filename, or registry key name | 
**Exists** | **bool?** | True if the element existed on the monitored host at the time of the scan | [default to false]
**Id** | **string** | Readable-Key identity of the element version | 
**IsPromoted** | **bool?** | True if the element version has been promoted | [default to false]
**Md5** | **string** | The MD5 hash of the content of this element version | 
**NodeOid** | **string** | Object identity of the node | 
**OutsideMaintenanceWindow** | **bool?** |  | [default to false]
**PromotionComment** | **string** | User supplied meta data assigned when element versions are promoted to approved state | 
**RuleOid** | **string** | Object identity of the rule | 
**ScanId** | **string** | An id assigned to the scan occurance | 
**Severity** | **int?** | Assigned severity for this element based on options in the rule, startpoints, and attribute criteria (modifiable) | 
**Sha1** | **string** | The SHA-1 hash of the content of this element version | 
**Sha256** | **string** | The SHA-256 hash of the content of this element version | 
**Sha512** | **string** | The SHA-512 hash of the content of this element version | 
**TimeDetected** | **string** | Timestamp indicating when the scanning mechanism detected the change | 
**TimeReceived** | **string** | Timestamp indicating when the Tripwire Enterprise server received the change | [optional] 
**VersionNumber** | **int?** | The monotonically increasing number of this version. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

