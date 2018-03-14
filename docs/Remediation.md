# IO.Swagger.Model.Remediation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instructions** | **string** | Manual remediation instructions to restore compliance | [optional] 
**Command** | **string** | The command line used to invoke automated remediation | [optional] 
**Script** | **string** | The script to execute, usually as a parameter in command, for automated remediation | [optional] 
**Category** | **string** | Indicates the kind of action taken by remediation, such as reconfiguration, or stopping a service | [optional] 
**ElementNames** | **List&lt;string&gt;** | Element names that will be remediated | [optional] 
**PostRemediationSteps** | **string** | Additional required steps to take to ensure remediation is complete | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

