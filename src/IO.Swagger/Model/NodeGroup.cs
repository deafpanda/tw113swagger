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
    /// A group of nodes or other node groups
    /// </summary>
    [DataContract]
    public partial class NodeGroup :  IEquatable<NodeGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodeGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGroup" /> class.
        /// </summary>
        /// <param name="name">The name of the node group (required).</param>
        /// <param name="description">A description of the node group.</param>
        /// <param name="trackingId">An ID for the node group that is tracked across exports and imports.</param>
        /// <param name="type">Type of the group object.</param>
        public NodeGroup(string name = default(string), string description = default(string), string trackingId = default(string), string type = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for NodeGroup and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
            this.TrackingId = trackingId;
            this.Type = type;
        }
        
        /// <summary>
        /// Readable-key identity of this node group (restrictions: read-only)
        /// </summary>
        /// <value>Readable-key identity of this node group (restrictions: read-only)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the node group
        /// </summary>
        /// <value>The name of the node group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the node group
        /// </summary>
        /// <value>A description of the node group</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Timestamp indicating when the node group definition was last modified (restrictions: read-only)
        /// </summary>
        /// <value>Timestamp indicating when the node group definition was last modified (restrictions: read-only)</value>
        [DataMember(Name="modifiedTime", EmitDefaultValue=false)]
        public string ModifiedTime { get; private set; }

        /// <summary>
        /// Timestamp indicating when the node group definition was imported from xml (restrictions: read-only)
        /// </summary>
        /// <value>Timestamp indicating when the node group definition was imported from xml (restrictions: read-only)</value>
        [DataMember(Name="importedTime", EmitDefaultValue=false)]
        public string ImportedTime { get; private set; }

        /// <summary>
        /// An ID for the node group that is tracked across exports and imports
        /// </summary>
        /// <value>An ID for the node group that is tracked across exports and imports</value>
        [DataMember(Name="trackingId", EmitDefaultValue=false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Type of the group object
        /// </summary>
        /// <value>Type of the group object</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  ImportedTime: ").Append(ImportedTime).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
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
            return this.Equals(input as NodeGroup);
        }

        /// <summary>
        /// Returns true if NodeGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeGroup input)
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
