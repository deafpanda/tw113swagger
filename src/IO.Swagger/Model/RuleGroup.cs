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
    /// A group of Rules or other RuleGroups
    /// </summary>
    [DataContract]
    public partial class RuleGroup :  IEquatable<RuleGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleGroup" /> class.
        /// </summary>
        /// <param name="name">The name of the RuleGroup (required).</param>
        /// <param name="description">A description of the RuleGroup.</param>
        /// <param name="trackingId">An ID for the RuleGroup that is tracked across exports and imports.</param>
        public RuleGroup(string name = default(string), string description = default(string), string trackingId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RuleGroup and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
            this.TrackingId = trackingId;
        }
        
        /// <summary>
        /// Readable-key identity of this RuleGroup Object (restrictions: read-only)
        /// </summary>
        /// <value>Readable-key identity of this RuleGroup Object (restrictions: read-only)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the RuleGroup
        /// </summary>
        /// <value>The name of the RuleGroup</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the RuleGroup
        /// </summary>
        /// <value>A description of the RuleGroup</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Timestamp indicating when the RuleGroup definition was last modified (restrictions: read-only)
        /// </summary>
        /// <value>Timestamp indicating when the RuleGroup definition was last modified (restrictions: read-only)</value>
        [DataMember(Name="modifiedTime", EmitDefaultValue=false)]
        public string ModifiedTime { get; private set; }

        /// <summary>
        /// Timestamp indicating when the RuleGroup definition was imported from xml (restrictions: read-only)
        /// </summary>
        /// <value>Timestamp indicating when the RuleGroup definition was imported from xml (restrictions: read-only)</value>
        [DataMember(Name="importedTime", EmitDefaultValue=false)]
        public string ImportedTime { get; private set; }

        /// <summary>
        /// An ID for the RuleGroup that is tracked across exports and imports
        /// </summary>
        /// <value>An ID for the RuleGroup that is tracked across exports and imports</value>
        [DataMember(Name="trackingId", EmitDefaultValue=false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  ImportedTime: ").Append(ImportedTime).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
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
            return this.Equals(input as RuleGroup);
        }

        /// <summary>
        /// Returns true if RuleGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleGroup input)
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
                    this.ModifiedTime == input.ModifiedTime ||
                    (this.ModifiedTime != null &&
                    this.ModifiedTime.Equals(input.ModifiedTime))
                ) && 
                (
                    this.ImportedTime == input.ImportedTime ||
                    (this.ImportedTime != null &&
                    this.ImportedTime.Equals(input.ImportedTime))
                ) && 
                (
                    this.TrackingId == input.TrackingId ||
                    (this.TrackingId != null &&
                    this.TrackingId.Equals(input.TrackingId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ModifiedTime != null)
                    hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.ImportedTime != null)
                    hashCode = hashCode * 59 + this.ImportedTime.GetHashCode();
                if (this.TrackingId != null)
                    hashCode = hashCode * 59 + this.TrackingId.GetHashCode();
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
