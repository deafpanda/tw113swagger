# IO.Swagger.Model.Task
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the task | [optional] 
**Type** | **string** | Type of the task | [optional] 
**Name** | **string** | Name of the task (modifiable). | [optional] 
**Description** | **string** | Description of the task (modifiable). | [optional] 
**Status** | **string** | Indicates if a task is running or idle | [optional] 
**LastStart** | **string** | A timestamp indicating the previous time the task began execution | [optional] 
**LastDuration** | **long?** | Time in seconds of the last task execution | [optional] 
**NextStart** | **string** | A timestamp indicating when the task is expected to start next in the future | [optional] 
**UserId** | **string** | Readable key ID of the user the task will execute as, or 0 for the System User (modifiable). | [optional] 
**Schedule** | [**TaskSchedule**](TaskSchedule.md) | Defines when the task will run (modifiable). | [optional] 
**ArchiveLogsOlderThan** | **int?** | Number of days worth of latest logs to retain (modifiable). | [optional] 
**ArchiveLogsExceeding** | **int?** | Number of maximum latest messages to retain (modifiable). | [optional] 
**Timeout** | **long?** | Number of hours to allow the task to execute (modifiable). | [optional] 
**CompactVersionsOlderThan** | **int?** | Number of days to of element versions to retain (modifiable). | [optional] 
**CompactVersionsExceeding** | **int?** | Number of maximum latest element versions to retain (modifiable). | [optional] 
**ArchiveAuditEvents** | **bool?** | If true, audit events exceeding the retention age will be archived and removed (modifiable). | [optional] [default to false]
**NewBaselinesOnly** | **bool?** | If true, only create baseline element versions for new elements produced by the rules (modifiable). | [optional] [default to false]
**NodeId** | **string** | Node or node group to include in scope (modifiable). | [optional] 
**RuleId** | **string** | Rule or rule group to include in scope. A null value indicates that a baseline or check task should use the currently associated rules (modifiable). | [optional] 
**ActionIds** | **List&lt;string&gt;** | List of Action IDs to execute for changed element versions (modifiable). | [optional] 
**ReportId** | **string** | Report to execute (modifiable). | [optional] 
**ReportUserIds** | **List&lt;string&gt;** | List of users the report will be delivered to through email (modifiable). | [optional] 
**AdditionalEmailAddresses** | **List&lt;string&gt;** | List of additional email addresses that will receive the report (modifiable). | [optional] 
**EmailServer** | **string** | Name of the email server to send report through (modifiable). | [optional] 
**ReportFormat** | **string** | Choice of HTML, PDF, XML or CSV (modifiable). | [optional] 
**ArchiveReports** | **bool?** | If true, the report is archived to disk (modifiable). | [optional] [default to false]
**IgnoreEmptyReports** | **bool?** | If true, report is not archived or sent if it is empty (modifiable). | [optional] [default to false]
**Enabled** | **bool?** | When enabled, the task will execute automatically following the assigned schedule (modifiable)0 | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

