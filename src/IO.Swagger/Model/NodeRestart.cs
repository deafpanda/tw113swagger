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
    /// A collection of Nodes to restart and optionally refresh
    /// </summary>
    [DataContract]
    public partial class NodeRestart :  IEquatable<NodeRestart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRestart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodeRestart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRestart" /> class.
        /// </summary>
        /// <param name="nodes">The set of nodes to restart (required).</param>
        /// <param name="refresh">If true, the version data on the node will be resynced with the TE Server (default to false).</param>
        public NodeRestart(List<string> nodes = default(List<string>), bool? refresh = false)
        {
            // to ensure "nodes" is required (not null)
            if (nodes == null)
            {
                throw new InvalidDataException("nodes is a required property for NodeRestart and cannot be null");
            }
            else
            {
                this.Nodes = nodes;
            }
            // use default value if no "refresh" provided
            if (refresh == null)
            {
                this.Refresh = false;
            }
            else
            {
                this.Refresh = refresh;
            }
        }
        
        /// <summary>
        /// The set of nodes to restart
        /// </summary>
        /// <value>The set of nodes to restart</value>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// If true, the version data on the node will be resynced with the TE Server
        /// </summary>
        /// <value>If true, the version data on the node will be resynced with the TE Server</value>
        [DataMember(Name="refresh", EmitDefaultValue=false)]
        public bool? Refresh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeRestart {\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  Refresh: ").Append(Refresh).Append("\n");
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
            return this.Equals(input as NodeRestart);
        }

        /// <summary>
        /// Returns true if NodeRestart instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeRestart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeRestart input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.Refresh == input.Refresh ||
                    (this.Refresh != null &&
                    this.Refresh.Equals(input.Refresh))
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
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Refresh != null)
                    hashCode = hashCode * 59 + this.Refresh.GetHashCode();
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
