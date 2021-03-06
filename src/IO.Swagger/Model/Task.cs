/* 
 * Tripwire Enterprise TE REST API User Guide & Reference
 *
 * The TE REST API allows automation of many aspects of Tripwire Enterprise
 *
 * OpenAPI spec version: 1.12.1.bmaster.r20170922182356-4e84151.b1741
 * Contact: support@tripwire.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Contains the data associated to a specific Task
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">Id of the task.</param>
        /// <param name="type">Type of the task.</param>
        /// <param name="name">Name of the task (modifiable)..</param>
        /// <param name="description">Description of the task (modifiable)..</param>
        /// <param name="status">Indicates if a task is running or idle.</param>
        /// <param name="lastStart">A timestamp indicating the previous time the task began execution.</param>
        /// <param name="lastDuration">Time in seconds of the last task execution.</param>
        /// <param name="nextStart">A timestamp indicating when the task is expected to start next in the future.</param>
        /// <param name="userId">Readable key ID of the user the task will execute as, or 0 for the System User (modifiable)..</param>
        /// <param name="schedule">Defines when the task will run (modifiable)..</param>
        /// <param name="archiveLogsOlderThan">Number of days worth of latest logs to retain (modifiable)..</param>
        /// <param name="archiveLogsExceeding">Number of maximum latest messages to retain (modifiable)..</param>
        /// <param name="timeout">Number of hours to allow the task to execute (modifiable)..</param>
        /// <param name="compactVersionsOlderThan">Number of days to of element versions to retain (modifiable)..</param>
        /// <param name="compactVersionsExceeding">Number of maximum latest element versions to retain (modifiable)..</param>
        /// <param name="archiveAuditEvents">If true, audit events exceeding the retention age will be archived and removed (modifiable). (default to false).</param>
        /// <param name="newBaselinesOnly">If true, only create baseline element versions for new elements produced by the rules (modifiable). (default to false).</param>
        /// <param name="nodeId">Node or node group to include in scope (modifiable)..</param>
        /// <param name="ruleId">Rule or rule group to include in scope. A null value indicates that a baseline or check task should use the currently associated rules (modifiable)..</param>
        /// <param name="actionIds">List of Action IDs to execute for changed element versions (modifiable)..</param>
        /// <param name="reportId">Report to execute (modifiable)..</param>
        /// <param name="reportUserIds">List of users the report will be delivered to through email (modifiable)..</param>
        /// <param name="additionalEmailAddresses">List of additional email addresses that will receive the report (modifiable)..</param>
        /// <param name="emailServer">Name of the email server to send report through (modifiable)..</param>
        /// <param name="reportFormat">Choice of HTML, PDF, XML or CSV (modifiable)..</param>
        /// <param name="archiveReports">If true, the report is archived to disk (modifiable). (default to false).</param>
        /// <param name="ignoreEmptyReports">If true, report is not archived or sent if it is empty (modifiable). (default to false).</param>
        /// <param name="enabled">When enabled, the task will execute automatically following the assigned schedule (modifiable)0 (default to false).</param>
        public Task(string id = default(string), string type = default(string), string name = default(string), string description = default(string), string status = default(string), string lastStart = default(string), long? lastDuration = default(long?), string nextStart = default(string), string userId = default(string), TaskSchedule schedule = default(TaskSchedule), int? archiveLogsOlderThan = default(int?), int? archiveLogsExceeding = default(int?), long? timeout = default(long?), int? compactVersionsOlderThan = default(int?), int? compactVersionsExceeding = default(int?), bool? archiveAuditEvents = false, bool? newBaselinesOnly = false, string nodeId = default(string), string ruleId = default(string), List<string> actionIds = default(List<string>), string reportId = default(string), List<string> reportUserIds = default(List<string>), List<string> additionalEmailAddresses = default(List<string>), string emailServer = default(string), string reportFormat = default(string), bool? archiveReports = false, bool? ignoreEmptyReports = false, bool? enabled = false)
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.LastStart = lastStart;
            this.LastDuration = lastDuration;
            this.NextStart = nextStart;
            this.UserId = userId;
            this.Schedule = schedule;
            this.ArchiveLogsOlderThan = archiveLogsOlderThan;
            this.ArchiveLogsExceeding = archiveLogsExceeding;
            this.Timeout = timeout;
            this.CompactVersionsOlderThan = compactVersionsOlderThan;
            this.CompactVersionsExceeding = compactVersionsExceeding;
            // use default value if no "archiveAuditEvents" provided
            if (archiveAuditEvents == null)
            {
                this.ArchiveAuditEvents = false;
            }
            else
            {
                this.ArchiveAuditEvents = archiveAuditEvents;
            }
            // use default value if no "newBaselinesOnly" provided
            if (newBaselinesOnly == null)
            {
                this.NewBaselinesOnly = false;
            }
            else
            {
                this.NewBaselinesOnly = newBaselinesOnly;
            }
            this.NodeId = nodeId;
            this.RuleId = ruleId;
            this.ActionIds = actionIds;
            this.ReportId = reportId;
            this.ReportUserIds = reportUserIds;
            this.AdditionalEmailAddresses = additionalEmailAddresses;
            this.EmailServer = emailServer;
            this.ReportFormat = reportFormat;
            // use default value if no "archiveReports" provided
            if (archiveReports == null)
            {
                this.ArchiveReports = false;
            }
            else
            {
                this.ArchiveReports = archiveReports;
            }
            // use default value if no "ignoreEmptyReports" provided
            if (ignoreEmptyReports == null)
            {
                this.IgnoreEmptyReports = false;
            }
            else
            {
                this.IgnoreEmptyReports = ignoreEmptyReports;
            }
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = enabled;
            }
        }
        
        /// <summary>
        /// Id of the task
        /// </summary>
        /// <value>Id of the task</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Type of the task
        /// </summary>
        /// <value>Type of the task</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Name of the task (modifiable).
        /// </summary>
        /// <value>Name of the task (modifiable).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the task (modifiable).
        /// </summary>
        /// <value>Description of the task (modifiable).</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if a task is running or idle
        /// </summary>
        /// <value>Indicates if a task is running or idle</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// A timestamp indicating the previous time the task began execution
        /// </summary>
        /// <value>A timestamp indicating the previous time the task began execution</value>
        [DataMember(Name="lastStart", EmitDefaultValue=false)]
        public string LastStart { get; set; }

        /// <summary>
        /// Time in seconds of the last task execution
        /// </summary>
        /// <value>Time in seconds of the last task execution</value>
        [DataMember(Name="lastDuration", EmitDefaultValue=false)]
        public long? LastDuration { get; set; }

        /// <summary>
        /// A timestamp indicating when the task is expected to start next in the future
        /// </summary>
        /// <value>A timestamp indicating when the task is expected to start next in the future</value>
        [DataMember(Name="nextStart", EmitDefaultValue=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// Readable key ID of the user the task will execute as, or 0 for the System User (modifiable).
        /// </summary>
        /// <value>Readable key ID of the user the task will execute as, or 0 for the System User (modifiable).</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Defines when the task will run (modifiable).
        /// </summary>
        /// <value>Defines when the task will run (modifiable).</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public TaskSchedule Schedule { get; set; }

        /// <summary>
        /// Number of days worth of latest logs to retain (modifiable).
        /// </summary>
        /// <value>Number of days worth of latest logs to retain (modifiable).</value>
        [DataMember(Name="archiveLogsOlderThan", EmitDefaultValue=false)]
        public int? ArchiveLogsOlderThan { get; set; }

        /// <summary>
        /// Number of maximum latest messages to retain (modifiable).
        /// </summary>
        /// <value>Number of maximum latest messages to retain (modifiable).</value>
        [DataMember(Name="archiveLogsExceeding", EmitDefaultValue=false)]
        public int? ArchiveLogsExceeding { get; set; }

        /// <summary>
        /// Number of hours to allow the task to execute (modifiable).
        /// </summary>
        /// <value>Number of hours to allow the task to execute (modifiable).</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// Number of days to of element versions to retain (modifiable).
        /// </summary>
        /// <value>Number of days to of element versions to retain (modifiable).</value>
        [DataMember(Name="compactVersionsOlderThan", EmitDefaultValue=false)]
        public int? CompactVersionsOlderThan { get; set; }

        /// <summary>
        /// Number of maximum latest element versions to retain (modifiable).
        /// </summary>
        /// <value>Number of maximum latest element versions to retain (modifiable).</value>
        [DataMember(Name="compactVersionsExceeding", EmitDefaultValue=false)]
        public int? CompactVersionsExceeding { get; set; }

        /// <summary>
        /// If true, audit events exceeding the retention age will be archived and removed (modifiable).
        /// </summary>
        /// <value>If true, audit events exceeding the retention age will be archived and removed (modifiable).</value>
        [DataMember(Name="archiveAuditEvents", EmitDefaultValue=false)]
        public bool? ArchiveAuditEvents { get; set; }

        /// <summary>
        /// If true, only create baseline element versions for new elements produced by the rules (modifiable).
        /// </summary>
        /// <value>If true, only create baseline element versions for new elements produced by the rules (modifiable).</value>
        [DataMember(Name="newBaselinesOnly", EmitDefaultValue=false)]
        public bool? NewBaselinesOnly { get; set; }

        /// <summary>
        /// Node or node group to include in scope (modifiable).
        /// </summary>
        /// <value>Node or node group to include in scope (modifiable).</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Rule or rule group to include in scope. A null value indicates that a baseline or check task should use the currently associated rules (modifiable).
        /// </summary>
        /// <value>Rule or rule group to include in scope. A null value indicates that a baseline or check task should use the currently associated rules (modifiable).</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// List of Action IDs to execute for changed element versions (modifiable).
        /// </summary>
        /// <value>List of Action IDs to execute for changed element versions (modifiable).</value>
        [DataMember(Name="actionIds", EmitDefaultValue=false)]
        public List<string> ActionIds { get; set; }

        /// <summary>
        /// Report to execute (modifiable).
        /// </summary>
        /// <value>Report to execute (modifiable).</value>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// List of users the report will be delivered to through email (modifiable).
        /// </summary>
        /// <value>List of users the report will be delivered to through email (modifiable).</value>
        [DataMember(Name="reportUserIds", EmitDefaultValue=false)]
        public List<string> ReportUserIds { get; set; }

        /// <summary>
        /// List of additional email addresses that will receive the report (modifiable).
        /// </summary>
        /// <value>List of additional email addresses that will receive the report (modifiable).</value>
        [DataMember(Name="additionalEmailAddresses", EmitDefaultValue=false)]
        public List<string> AdditionalEmailAddresses { get; set; }

        /// <summary>
        /// Name of the email server to send report through (modifiable).
        /// </summary>
        /// <value>Name of the email server to send report through (modifiable).</value>
        [DataMember(Name="emailServer", EmitDefaultValue=false)]
        public string EmailServer { get; set; }

        /// <summary>
        /// Choice of HTML, PDF, XML or CSV (modifiable).
        /// </summary>
        /// <value>Choice of HTML, PDF, XML or CSV (modifiable).</value>
        [DataMember(Name="reportFormat", EmitDefaultValue=false)]
        public string ReportFormat { get; set; }

        /// <summary>
        /// If true, the report is archived to disk (modifiable).
        /// </summary>
        /// <value>If true, the report is archived to disk (modifiable).</value>
        [DataMember(Name="archiveReports", EmitDefaultValue=false)]
        public bool? ArchiveReports { get; set; }

        /// <summary>
        /// If true, report is not archived or sent if it is empty (modifiable).
        /// </summary>
        /// <value>If true, report is not archived or sent if it is empty (modifiable).</value>
        [DataMember(Name="ignoreEmptyReports", EmitDefaultValue=false)]
        public bool? IgnoreEmptyReports { get; set; }

        /// <summary>
        /// When enabled, the task will execute automatically following the assigned schedule (modifiable)0
        /// </summary>
        /// <value>When enabled, the task will execute automatically following the assigned schedule (modifiable)0</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastStart: ").Append(LastStart).Append("\n");
            sb.Append("  LastDuration: ").Append(LastDuration).Append("\n");
            sb.Append("  NextStart: ").Append(NextStart).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ArchiveLogsOlderThan: ").Append(ArchiveLogsOlderThan).Append("\n");
            sb.Append("  ArchiveLogsExceeding: ").Append(ArchiveLogsExceeding).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  CompactVersionsOlderThan: ").Append(CompactVersionsOlderThan).Append("\n");
            sb.Append("  CompactVersionsExceeding: ").Append(CompactVersionsExceeding).Append("\n");
            sb.Append("  ArchiveAuditEvents: ").Append(ArchiveAuditEvents).Append("\n");
            sb.Append("  NewBaselinesOnly: ").Append(NewBaselinesOnly).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  ActionIds: ").Append(ActionIds).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  ReportUserIds: ").Append(ReportUserIds).Append("\n");
            sb.Append("  AdditionalEmailAddresses: ").Append(AdditionalEmailAddresses).Append("\n");
            sb.Append("  EmailServer: ").Append(EmailServer).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  ArchiveReports: ").Append(ArchiveReports).Append("\n");
            sb.Append("  IgnoreEmptyReports: ").Append(IgnoreEmptyReports).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LastStart == input.LastStart ||
                    (this.LastStart != null &&
                    this.LastStart.Equals(input.LastStart))
                ) && 
                (
                    this.LastDuration == input.LastDuration ||
                    (this.LastDuration != null &&
                    this.LastDuration.Equals(input.LastDuration))
                ) && 
                (
                    this.NextStart == input.NextStart ||
                    (this.NextStart != null &&
                    this.NextStart.Equals(input.NextStart))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.ArchiveLogsOlderThan == input.ArchiveLogsOlderThan ||
                    (this.ArchiveLogsOlderThan != null &&
                    this.ArchiveLogsOlderThan.Equals(input.ArchiveLogsOlderThan))
                ) && 
                (
                    this.ArchiveLogsExceeding == input.ArchiveLogsExceeding ||
                    (this.ArchiveLogsExceeding != null &&
                    this.ArchiveLogsExceeding.Equals(input.ArchiveLogsExceeding))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.CompactVersionsOlderThan == input.CompactVersionsOlderThan ||
                    (this.CompactVersionsOlderThan != null &&
                    this.CompactVersionsOlderThan.Equals(input.CompactVersionsOlderThan))
                ) && 
                (
                    this.CompactVersionsExceeding == input.CompactVersionsExceeding ||
                    (this.CompactVersionsExceeding != null &&
                    this.CompactVersionsExceeding.Equals(input.CompactVersionsExceeding))
                ) && 
                (
                    this.ArchiveAuditEvents == input.ArchiveAuditEvents ||
                    (this.ArchiveAuditEvents != null &&
                    this.ArchiveAuditEvents.Equals(input.ArchiveAuditEvents))
                ) && 
                (
                    this.NewBaselinesOnly == input.NewBaselinesOnly ||
                    (this.NewBaselinesOnly != null &&
                    this.NewBaselinesOnly.Equals(input.NewBaselinesOnly))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.ActionIds == input.ActionIds ||
                    this.ActionIds != null &&
                    this.ActionIds.SequenceEqual(input.ActionIds)
                ) && 
                (
                    this.ReportId == input.ReportId ||
                    (this.ReportId != null &&
                    this.ReportId.Equals(input.ReportId))
                ) && 
                (
                    this.ReportUserIds == input.ReportUserIds ||
                    this.ReportUserIds != null &&
                    this.ReportUserIds.SequenceEqual(input.ReportUserIds)
                ) && 
                (
                    this.AdditionalEmailAddresses == input.AdditionalEmailAddresses ||
                    this.AdditionalEmailAddresses != null &&
                    this.AdditionalEmailAddresses.SequenceEqual(input.AdditionalEmailAddresses)
                ) && 
                (
                    this.EmailServer == input.EmailServer ||
                    (this.EmailServer != null &&
                    this.EmailServer.Equals(input.EmailServer))
                ) && 
                (
                    this.ReportFormat == input.ReportFormat ||
                    (this.ReportFormat != null &&
                    this.ReportFormat.Equals(input.ReportFormat))
                ) && 
                (
                    this.ArchiveReports == input.ArchiveReports ||
                    (this.ArchiveReports != null &&
                    this.ArchiveReports.Equals(input.ArchiveReports))
                ) && 
                (
                    this.IgnoreEmptyReports == input.IgnoreEmptyReports ||
                    (this.IgnoreEmptyReports != null &&
                    this.IgnoreEmptyReports.Equals(input.IgnoreEmptyReports))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastStart != null)
                    hashCode = hashCode * 59 + this.LastStart.GetHashCode();
                if (this.LastDuration != null)
                    hashCode = hashCode * 59 + this.LastDuration.GetHashCode();
                if (this.NextStart != null)
                    hashCode = hashCode * 59 + this.NextStart.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.ArchiveLogsOlderThan != null)
                    hashCode = hashCode * 59 + this.ArchiveLogsOlderThan.GetHashCode();
                if (this.ArchiveLogsExceeding != null)
                    hashCode = hashCode * 59 + this.ArchiveLogsExceeding.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.CompactVersionsOlderThan != null)
                    hashCode = hashCode * 59 + this.CompactVersionsOlderThan.GetHashCode();
                if (this.CompactVersionsExceeding != null)
                    hashCode = hashCode * 59 + this.CompactVersionsExceeding.GetHashCode();
                if (this.ArchiveAuditEvents != null)
                    hashCode = hashCode * 59 + this.ArchiveAuditEvents.GetHashCode();
                if (this.NewBaselinesOnly != null)
                    hashCode = hashCode * 59 + this.NewBaselinesOnly.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.ActionIds != null)
                    hashCode = hashCode * 59 + this.ActionIds.GetHashCode();
                if (this.ReportId != null)
                    hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                if (this.ReportUserIds != null)
                    hashCode = hashCode * 59 + this.ReportUserIds.GetHashCode();
                if (this.AdditionalEmailAddresses != null)
                    hashCode = hashCode * 59 + this.AdditionalEmailAddresses.GetHashCode();
                if (this.EmailServer != null)
                    hashCode = hashCode * 59 + this.EmailServer.GetHashCode();
                if (this.ReportFormat != null)
                    hashCode = hashCode * 59 + this.ReportFormat.GetHashCode();
                if (this.ArchiveReports != null)
                    hashCode = hashCode * 59 + this.ArchiveReports.GetHashCode();
                if (this.IgnoreEmptyReports != null)
                    hashCode = hashCode * 59 + this.IgnoreEmptyReports.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
