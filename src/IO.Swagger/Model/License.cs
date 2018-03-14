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
    /// A feature in TE and the license counts associated to it.
    /// </summary>
    [DataContract]
    public partial class License :  IEquatable<License>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="License" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected License() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="License" /> class.
        /// </summary>
        /// <param name="id">Readable-Key identity of the license (required).</param>
        /// <param name="name">The canonical name for the licensed feature (required).</param>
        /// <param name="displayName">The name useful for reporting or display purposes (required).</param>
        /// <param name="inUse">Number of license counts allocated for this feature (required).</param>
        /// <param name="pool">The number of licenses installed for this feature including unused and used (required).</param>
        /// <param name="expires">Date for the licensed feature expiration (required).</param>
        public License(string id = default(string), string name = default(string), string displayName = default(string), int? inUse = default(int?), int? pool = default(int?), string expires = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for License and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for License and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for License and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "inUse" is required (not null)
            if (inUse == null)
            {
                throw new InvalidDataException("inUse is a required property for License and cannot be null");
            }
            else
            {
                this.InUse = inUse;
            }
            // to ensure "pool" is required (not null)
            if (pool == null)
            {
                throw new InvalidDataException("pool is a required property for License and cannot be null");
            }
            else
            {
                this.Pool = pool;
            }
            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException("expires is a required property for License and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }
        }
        
        /// <summary>
        /// Readable-Key identity of the license
        /// </summary>
        /// <value>Readable-Key identity of the license</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The canonical name for the licensed feature
        /// </summary>
        /// <value>The canonical name for the licensed feature</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name useful for reporting or display purposes
        /// </summary>
        /// <value>The name useful for reporting or display purposes</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Number of license counts allocated for this feature
        /// </summary>
        /// <value>Number of license counts allocated for this feature</value>
        [DataMember(Name="inUse", EmitDefaultValue=false)]
        public int? InUse { get; set; }

        /// <summary>
        /// The number of licenses installed for this feature including unused and used
        /// </summary>
        /// <value>The number of licenses installed for this feature including unused and used</value>
        [DataMember(Name="pool", EmitDefaultValue=false)]
        public int? Pool { get; set; }

        /// <summary>
        /// Date for the licensed feature expiration
        /// </summary>
        /// <value>Date for the licensed feature expiration</value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class License {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  InUse: ").Append(InUse).Append("\n");
            sb.Append("  Pool: ").Append(Pool).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
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
            return this.Equals(input as License);
        }

        /// <summary>
        /// Returns true if License instances are equal
        /// </summary>
        /// <param name="input">Instance of License to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(License input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.InUse == input.InUse ||
                    (this.InUse != null &&
                    this.InUse.Equals(input.InUse))
                ) && 
                (
                    this.Pool == input.Pool ||
                    (this.Pool != null &&
                    this.Pool.Equals(input.Pool))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.InUse != null)
                    hashCode = hashCode * 59 + this.InUse.GetHashCode();
                if (this.Pool != null)
                    hashCode = hashCode * 59 + this.Pool.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
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