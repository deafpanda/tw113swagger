# IO.Swagger.Model.TaskSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the schedule (modifiable). | [optional] 
**Time** | **string** | Time (hh:mm a) of the day when the task will execute, in server local time (modifiable). | [optional] 
**Date** | **string** | Date for Once schedules when the task will execute (modifiable). | [optional] 
**PeriodicTimeRange** | **string** | Time range where (hh:mm a,hh:mm a)Periodic tasks will execute (modifiable). | [optional] 
**Minutes** | **int?** | Minutes of the schedule (modifiable). | [optional] 
**Day** | **int?** | Day of the month of the schedule (modifiable). | [optional] 
**DaysOfWeek** | **List&lt;string&gt;** | Days of the week of the schedule (Monday, Tuesday, etc..) (modifiable). | [optional] 
**DaysOcurrence** | **string** | Days occurrence of the schedule (1st, 2nd, 3rd, 4th, last) (modifiable). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

