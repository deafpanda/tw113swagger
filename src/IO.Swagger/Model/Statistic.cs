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
    /// Contains the name and associated attributes of a managed bean
    /// </summary>
    [DataContract]
    public partial class Statistic :  IEquatable<Statistic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statistic" /> class.
        /// </summary>
        /// <param name="name">Name of the JMX managed bean.</param>
        /// <param name="attributes">Attributes map of the managed bean.</param>
        public Statistic(string name = default(string), Dictionary<string, string> attributes = default(Dictionary<string, string>))
        {
            this.Name = name;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// Name of the JMX managed bean
        /// </summary>
        /// <value>Name of the JMX managed bean</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Attributes map of the managed bean
        /// </summary>
        /// <value>Attributes map of the managed bean</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statistic {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as Statistic);
        }

        /// <summary>
        /// Returns true if Statistic instances are equal
        /// </summary>
        /// <param name="input">Instance of Statistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
