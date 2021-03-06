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
    /// TaskSchedule
    /// </summary>
    [DataContract]
    public partial class TaskSchedule :  IEquatable<TaskSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSchedule" /> class.
        /// </summary>
        /// <param name="type">Type of the schedule (modifiable)..</param>
        /// <param name="time">Time (hh:mm a) of the day when the task will execute, in server local time (modifiable)..</param>
        /// <param name="date">Date for Once schedules when the task will execute (modifiable)..</param>
        /// <param name="periodicTimeRange">Time range where (hh:mm a,hh:mm a)Periodic tasks will execute (modifiable)..</param>
        /// <param name="minutes">Minutes of the schedule (modifiable)..</param>
        /// <param name="day">Day of the month of the schedule (modifiable)..</param>
        /// <param name="daysOfWeek">Days of the week of the schedule (Monday, Tuesday, etc..) (modifiable)..</param>
        /// <param name="daysOcurrence">Days occurrence of the schedule (1st, 2nd, 3rd, 4th, last) (modifiable)..</param>
        public TaskSchedule(string type = default(string), string time = default(string), string date = default(string), string periodicTimeRange = default(string), int? minutes = default(int?), int? day = default(int?), List<string> daysOfWeek = default(List<string>), string daysOcurrence = default(string))
        {
            this.Type = type;
            this.Time = time;
            this.Date = date;
            this.PeriodicTimeRange = periodicTimeRange;
            this.Minutes = minutes;
            this.Day = day;
            this.DaysOfWeek = daysOfWeek;
            this.DaysOcurrence = daysOcurrence;
        }
        
        /// <summary>
        /// Type of the schedule (modifiable).
        /// </summary>
        /// <value>Type of the schedule (modifiable).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Time (hh:mm a) of the day when the task will execute, in server local time (modifiable).
        /// </summary>
        /// <value>Time (hh:mm a) of the day when the task will execute, in server local time (modifiable).</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Date for Once schedules when the task will execute (modifiable).
        /// </summary>
        /// <value>Date for Once schedules when the task will execute (modifiable).</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Time range where (hh:mm a,hh:mm a)Periodic tasks will execute (modifiable).
        /// </summary>
        /// <value>Time range where (hh:mm a,hh:mm a)Periodic tasks will execute (modifiable).</value>
        [DataMember(Name="periodicTimeRange", EmitDefaultValue=false)]
        public string PeriodicTimeRange { get; set; }

        /// <summary>
        /// Minutes of the schedule (modifiable).
        /// </summary>
        /// <value>Minutes of the schedule (modifiable).</value>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Day of the month of the schedule (modifiable).
        /// </summary>
        /// <value>Day of the month of the schedule (modifiable).</value>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }

        /// <summary>
        /// Days of the week of the schedule (Monday, Tuesday, etc..) (modifiable).
        /// </summary>
        /// <value>Days of the week of the schedule (Monday, Tuesday, etc..) (modifiable).</value>
        [DataMember(Name="daysOfWeek", EmitDefaultValue=false)]
        public List<string> DaysOfWeek { get; set; }

        /// <summary>
        /// Days occurrence of the schedule (1st, 2nd, 3rd, 4th, last) (modifiable).
        /// </summary>
        /// <value>Days occurrence of the schedule (1st, 2nd, 3rd, 4th, last) (modifiable).</value>
        [DataMember(Name="daysOcurrence", EmitDefaultValue=false)]
        public string DaysOcurrence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskSchedule {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  PeriodicTimeRange: ").Append(PeriodicTimeRange).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  DaysOcurrence: ").Append(DaysOcurrence).Append("\n");
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
            return this.Equals(input as TaskSchedule);
        }

        /// <summary>
        /// Returns true if TaskSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.PeriodicTimeRange == input.PeriodicTimeRange ||
                    (this.PeriodicTimeRange != null &&
                    this.PeriodicTimeRange.Equals(input.PeriodicTimeRange))
                ) && 
                (
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.DaysOfWeek == input.DaysOfWeek ||
                    this.DaysOfWeek != null &&
                    this.DaysOfWeek.SequenceEqual(input.DaysOfWeek)
                ) && 
                (
                    this.DaysOcurrence == input.DaysOcurrence ||
                    (this.DaysOcurrence != null &&
                    this.DaysOcurrence.Equals(input.DaysOcurrence))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.PeriodicTimeRange != null)
                    hashCode = hashCode * 59 + this.PeriodicTimeRange.GetHashCode();
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.DaysOfWeek != null)
                    hashCode = hashCode * 59 + this.DaysOfWeek.GetHashCode();
                if (this.DaysOcurrence != null)
                    hashCode = hashCode * 59 + this.DaysOcurrence.GetHashCode();
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
