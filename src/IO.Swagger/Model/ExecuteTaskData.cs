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
    /// The payload needed to request a Task execution
    /// </summary>
    [DataContract]
    public partial class ExecuteTaskData :  IEquatable<ExecuteTaskData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteTaskData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecuteTaskData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteTaskData" /> class.
        /// </summary>
        /// <param name="taskId">The id of the Task to be executed (required).</param>
        public ExecuteTaskData(string taskId = default(string))
        {
            // to ensure "taskId" is required (not null)
            if (taskId == null)
            {
                throw new InvalidDataException("taskId is a required property for ExecuteTaskData and cannot be null");
            }
            else
            {
                this.TaskId = taskId;
            }
        }
        
        /// <summary>
        /// The id of the Task to be executed
        /// </summary>
        /// <value>The id of the Task to be executed</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteTaskData {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
            return this.Equals(input as ExecuteTaskData);
        }

        /// <summary>
        /// Returns true if ExecuteTaskData instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteTaskData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteTaskData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
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
