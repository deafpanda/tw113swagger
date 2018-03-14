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
    /// A Tripwire remediation of a policy test
    /// </summary>
    [DataContract]
    public partial class Remediation :  IEquatable<Remediation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Remediation" /> class.
        /// </summary>
        /// <param name="instructions">Manual remediation instructions to restore compliance.</param>
        /// <param name="command">The command line used to invoke automated remediation.</param>
        /// <param name="script">The script to execute, usually as a parameter in command, for automated remediation.</param>
        /// <param name="category">Indicates the kind of action taken by remediation, such as reconfiguration, or stopping a service.</param>
        /// <param name="elementNames">Element names that will be remediated.</param>
        /// <param name="postRemediationSteps">Additional required steps to take to ensure remediation is complete.</param>
        public Remediation(string instructions = default(string), string command = default(string), string script = default(string), string category = default(string), List<string> elementNames = default(List<string>), string postRemediationSteps = default(string))
        {
            this.Instructions = instructions;
            this.Command = command;
            this.Script = script;
            this.Category = category;
            this.ElementNames = elementNames;
            this.PostRemediationSteps = postRemediationSteps;
        }
        
        /// <summary>
        /// Manual remediation instructions to restore compliance
        /// </summary>
        /// <value>Manual remediation instructions to restore compliance</value>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// The command line used to invoke automated remediation
        /// </summary>
        /// <value>The command line used to invoke automated remediation</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public string Command { get; set; }

        /// <summary>
        /// The script to execute, usually as a parameter in command, for automated remediation
        /// </summary>
        /// <value>The script to execute, usually as a parameter in command, for automated remediation</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public string Script { get; set; }

        /// <summary>
        /// Indicates the kind of action taken by remediation, such as reconfiguration, or stopping a service
        /// </summary>
        /// <value>Indicates the kind of action taken by remediation, such as reconfiguration, or stopping a service</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Element names that will be remediated
        /// </summary>
        /// <value>Element names that will be remediated</value>
        [DataMember(Name="elementNames", EmitDefaultValue=false)]
        public List<string> ElementNames { get; set; }

        /// <summary>
        /// Additional required steps to take to ensure remediation is complete
        /// </summary>
        /// <value>Additional required steps to take to ensure remediation is complete</value>
        [DataMember(Name="postRemediationSteps", EmitDefaultValue=false)]
        public string PostRemediationSteps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Remediation {\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ElementNames: ").Append(ElementNames).Append("\n");
            sb.Append("  PostRemediationSteps: ").Append(PostRemediationSteps).Append("\n");
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
            return this.Equals(input as Remediation);
        }

        /// <summary>
        /// Returns true if Remediation instances are equal
        /// </summary>
        /// <param name="input">Instance of Remediation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Remediation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Script == input.Script ||
                    (this.Script != null &&
                    this.Script.Equals(input.Script))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ElementNames == input.ElementNames ||
                    this.ElementNames != null &&
                    this.ElementNames.SequenceEqual(input.ElementNames)
                ) && 
                (
                    this.PostRemediationSteps == input.PostRemediationSteps ||
                    (this.PostRemediationSteps != null &&
                    this.PostRemediationSteps.Equals(input.PostRemediationSteps))
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
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Script != null)
                    hashCode = hashCode * 59 + this.Script.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ElementNames != null)
                    hashCode = hashCode * 59 + this.ElementNames.GetHashCode();
                if (this.PostRemediationSteps != null)
                    hashCode = hashCode * 59 + this.PostRemediationSteps.GetHashCode();
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
