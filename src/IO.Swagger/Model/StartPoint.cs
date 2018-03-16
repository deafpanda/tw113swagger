/* 
 * Tripwire Enterprise TE REST API User Guide & Reference
 *
 * The TE REST API allows automation of many aspects of Tripwire Enterprise
 *
 * OpenAPI spec version: 1.13.0.bmaster.r20180119190259-8b60eaa.b1753
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
    /// Target location to scan a resource for elements
    /// </summary>
    [DataContract]
    public partial class StartPoint :  IEquatable<StartPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartPoint" /> class.
        /// </summary>
        /// <param name="archiveContent">If true, text file bodies will be archived with the element versions (default to false).</param>
        /// <param name="criteriaId">Criteria set for attributes of elements.</param>
        /// <param name="filterOnlyLeaves">If true, element name filters do not apply to directory elements (default to false).</param>
        /// <param name="id">Readable-key identity of the start point.</param>
        /// <param name="recurseLevel">Depth of directory descent under start point.</param>
        /// <param name="severity">Severity of element changes found by this start point.</param>
        /// <param name="target">Location to begin scanning for elements.</param>
        /// <param name="type">Type of start point.</param>
        public StartPoint(bool? archiveContent = false, string criteriaId = default(string), bool? filterOnlyLeaves = false, string id = default(string), int? recurseLevel = default(int?), int? severity = default(int?), string target = default(string), string type = default(string))
        {
            // use default value if no "archiveContent" provided
            if (archiveContent == null)
            {
                this.ArchiveContent = false;
            }
            else
            {
                this.ArchiveContent = archiveContent;
            }
            this.CriteriaId = criteriaId;
            // use default value if no "filterOnlyLeaves" provided
            if (filterOnlyLeaves == null)
            {
                this.FilterOnlyLeaves = false;
            }
            else
            {
                this.FilterOnlyLeaves = filterOnlyLeaves;
            }
            this.Id = id;
            this.RecurseLevel = recurseLevel;
            this.Severity = severity;
            this.Target = target;
            this.Type = type;
        }
        
        /// <summary>
        /// If true, text file bodies will be archived with the element versions
        /// </summary>
        /// <value>If true, text file bodies will be archived with the element versions</value>
        [DataMember(Name="archiveContent", EmitDefaultValue=false)]
        public bool? ArchiveContent { get; set; }

        /// <summary>
        /// Criteria set for attributes of elements
        /// </summary>
        /// <value>Criteria set for attributes of elements</value>
        [DataMember(Name="criteriaId", EmitDefaultValue=false)]
        public string CriteriaId { get; set; }

        /// <summary>
        /// If true, element name filters do not apply to directory elements
        /// </summary>
        /// <value>If true, element name filters do not apply to directory elements</value>
        [DataMember(Name="filterOnlyLeaves", EmitDefaultValue=false)]
        public bool? FilterOnlyLeaves { get; set; }

        /// <summary>
        /// Readable-key identity of the start point
        /// </summary>
        /// <value>Readable-key identity of the start point</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Depth of directory descent under start point
        /// </summary>
        /// <value>Depth of directory descent under start point</value>
        [DataMember(Name="recurseLevel", EmitDefaultValue=false)]
        public int? RecurseLevel { get; set; }

        /// <summary>
        /// Severity of element changes found by this start point
        /// </summary>
        /// <value>Severity of element changes found by this start point</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public int? Severity { get; set; }

        /// <summary>
        /// Location to begin scanning for elements
        /// </summary>
        /// <value>Location to begin scanning for elements</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// Type of start point
        /// </summary>
        /// <value>Type of start point</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartPoint {\n");
            sb.Append("  ArchiveContent: ").Append(ArchiveContent).Append("\n");
            sb.Append("  CriteriaId: ").Append(CriteriaId).Append("\n");
            sb.Append("  FilterOnlyLeaves: ").Append(FilterOnlyLeaves).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RecurseLevel: ").Append(RecurseLevel).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StartPoint);
        }

        /// <summary>
        /// Returns true if StartPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of StartPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveContent == input.ArchiveContent ||
                    (this.ArchiveContent != null &&
                    this.ArchiveContent.Equals(input.ArchiveContent))
                ) && 
                (
                    this.CriteriaId == input.CriteriaId ||
                    (this.CriteriaId != null &&
                    this.CriteriaId.Equals(input.CriteriaId))
                ) && 
                (
                    this.FilterOnlyLeaves == input.FilterOnlyLeaves ||
                    (this.FilterOnlyLeaves != null &&
                    this.FilterOnlyLeaves.Equals(input.FilterOnlyLeaves))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RecurseLevel == input.RecurseLevel ||
                    (this.RecurseLevel != null &&
                    this.RecurseLevel.Equals(input.RecurseLevel))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ArchiveContent != null)
                    hashCode = hashCode * 59 + this.ArchiveContent.GetHashCode();
                if (this.CriteriaId != null)
                    hashCode = hashCode * 59 + this.CriteriaId.GetHashCode();
                if (this.FilterOnlyLeaves != null)
                    hashCode = hashCode * 59 + this.FilterOnlyLeaves.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RecurseLevel != null)
                    hashCode = hashCode * 59 + this.RecurseLevel.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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