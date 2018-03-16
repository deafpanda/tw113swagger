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
    /// Location to end recursive scanning for elements
    /// </summary>
    [DataContract]
    public partial class StopPoint :  IEquatable<StopPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopPoint" /> class.
        /// </summary>
        /// <param name="stopsRecursion">If the target is a directory, exclude all children of the directory as well as the target (default to false).</param>
        /// <param name="target">Location to halt scanning for elements.</param>
        public StopPoint(bool? stopsRecursion = false, string target = default(string))
        {
            // use default value if no "stopsRecursion" provided
            if (stopsRecursion == null)
            {
                this.StopsRecursion = false;
            }
            else
            {
                this.StopsRecursion = stopsRecursion;
            }
            this.Target = target;
        }
        
        /// <summary>
        /// If the target is a directory, exclude all children of the directory as well as the target
        /// </summary>
        /// <value>If the target is a directory, exclude all children of the directory as well as the target</value>
        [DataMember(Name="stopsRecursion", EmitDefaultValue=false)]
        public bool? StopsRecursion { get; set; }

        /// <summary>
        /// Location to halt scanning for elements
        /// </summary>
        /// <value>Location to halt scanning for elements</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopPoint {\n");
            sb.Append("  StopsRecursion: ").Append(StopsRecursion).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as StopPoint);
        }

        /// <summary>
        /// Returns true if StopPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of StopPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopsRecursion == input.StopsRecursion ||
                    (this.StopsRecursion != null &&
                    this.StopsRecursion.Equals(input.StopsRecursion))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.StopsRecursion != null)
                    hashCode = hashCode * 59 + this.StopsRecursion.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
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
