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
    /// A request for version promotion
    /// </summary>
    [DataContract]
    public partial class PromoteRequestCommand :  IEquatable<PromoteRequestCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteRequestCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PromoteRequestCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteRequestCommand" /> class.
        /// </summary>
        /// <param name="requestData">Data of the request (required).</param>
        public PromoteRequestCommand(PromoteRequestData requestData = default(PromoteRequestData))
        {
            // to ensure "requestData" is required (not null)
            if (requestData == null)
            {
                throw new InvalidDataException("requestData is a required property for PromoteRequestCommand and cannot be null");
            }
            else
            {
                this.RequestData = requestData;
            }
        }
        
        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Data of the request
        /// </summary>
        /// <value>Data of the request</value>
        [DataMember(Name="requestData", EmitDefaultValue=false)]
        public PromoteRequestData RequestData { get; set; }

        /// <summary>
        /// State of the request. Possible values are: PENDING, RUNNING, ABORTED, COMPLETED
        /// </summary>
        /// <value>State of the request. Possible values are: PENDING, RUNNING, ABORTED, COMPLETED</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Detailed description of the progress of the request
        /// </summary>
        /// <value>Detailed description of the progress of the request</value>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> StatusMessage { get; private set; }

        /// <summary>
        /// Timestamp indicating when the request was submitted
        /// </summary>
        /// <value>Timestamp indicating when the request was submitted</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public string CreationTime { get; private set; }

        /// <summary>
        /// Timestamp indicating when the request finished
        /// </summary>
        /// <value>Timestamp indicating when the request finished</value>
        [DataMember(Name="completionTime", EmitDefaultValue=false)]
        public string CompletionTime { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromoteRequestCommand {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestData: ").Append(RequestData).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  CompletionTime: ").Append(CompletionTime).Append("\n");
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
            return this.Equals(input as PromoteRequestCommand);
        }

        /// <summary>
        /// Returns true if PromoteRequestCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of PromoteRequestCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromoteRequestCommand input)
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
                    this.RequestData == input.RequestData ||
                    (this.RequestData != null &&
                    this.RequestData.Equals(input.RequestData))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    this.StatusMessage != null &&
                    this.StatusMessage.SequenceEqual(input.StatusMessage)
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.CompletionTime == input.CompletionTime ||
                    (this.CompletionTime != null &&
                    this.CompletionTime.Equals(input.CompletionTime))
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
                if (this.RequestData != null)
                    hashCode = hashCode * 59 + this.RequestData.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.CompletionTime != null)
                    hashCode = hashCode * 59 + this.CompletionTime.GetHashCode();
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
