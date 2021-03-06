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
    /// An element version describes a change detected by Tripwire Enterprise.
    /// </summary>
    [DataContract]
    public partial class ElementVersion :  IEquatable<ElementVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElementVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementVersion" /> class.
        /// </summary>
        /// <param name="id">Readable-Key identity of the element version (required).</param>
        /// <param name="elementName">The name of the element, such as filename, or registry key name (required).</param>
        /// <param name="nodeName">The name of the Node the element version was detected on (required).</param>
        /// <param name="ruleName">The name of the rule the defining how the element version should be monitored (required).</param>
        /// <param name="elementId">Readable-Key identity of the element (required).</param>
        /// <param name="nodeId">Readable-Key identity of the node (required).</param>
        /// <param name="ruleId">Readable-Key identity of the rule (required).</param>
        /// <param name="baselineVersion">Readable-key identity of previous baseline element version (required).</param>
        /// <param name="changeType">Indicates if this change is an initial baseline snapshot, a modification, or removal of the element, or an additional element since the last scan (required).</param>
        /// <param name="exists">True if the element existed on the monitored host at the time of the scan (required) (default to false).</param>
        /// <param name="severity">Assigned severity for this element based on options in the rule, startpoints, and attribute criteria (modifiable) (required).</param>
        /// <param name="timeDetected">Timestamp indicating when the scanning mechanism detected the change (required).</param>
        /// <param name="promotionComment">User supplied meta data assigned when element versions are promoted to approved state (required).</param>
        /// <param name="approvalId">User supplied id used to correlate approvals to external tracking systems (required).</param>
        /// <param name="outsideMaintenanceWindow">outsideMaintenanceWindow (required) (default to false).</param>
        /// <param name="scanId">An id assigned to the scan occurance (required).</param>
        /// <param name="md5">The MD5 hash of the content of this element version (required).</param>
        /// <param name="sha1">The SHA-1 hash of the content of this element version (required).</param>
        /// <param name="sha256">The SHA-256 hash of the content of this element version (required).</param>
        /// <param name="sha512">The SHA-512 hash of the content of this element version (required).</param>
        /// <param name="isPromoted">True if the element version has been promoted (required) (default to false).</param>
        public ElementVersion(string id = default(string), string elementName = default(string), string nodeName = default(string), string ruleName = default(string), string elementId = default(string), string nodeId = default(string), string ruleId = default(string), string baselineVersion = default(string), string changeType = default(string), bool? exists = false, int? severity = default(int?), string timeDetected = default(string), string promotionComment = default(string), string approvalId = default(string), bool? outsideMaintenanceWindow = false, string scanId = default(string), string md5 = default(string), string sha1 = default(string), string sha256 = default(string), string sha512 = default(string), bool? isPromoted = false)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "elementName" is required (not null)
            if (elementName == null)
            {
                throw new InvalidDataException("elementName is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.ElementName = elementName;
            }
            // to ensure "nodeName" is required (not null)
            if (nodeName == null)
            {
                throw new InvalidDataException("nodeName is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.NodeName = nodeName;
            }
            // to ensure "ruleName" is required (not null)
            if (ruleName == null)
            {
                throw new InvalidDataException("ruleName is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.RuleName = ruleName;
            }
            // to ensure "elementId" is required (not null)
            if (elementId == null)
            {
                throw new InvalidDataException("elementId is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.ElementId = elementId;
            }
            // to ensure "nodeId" is required (not null)
            if (nodeId == null)
            {
                throw new InvalidDataException("nodeId is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.NodeId = nodeId;
            }
            // to ensure "ruleId" is required (not null)
            if (ruleId == null)
            {
                throw new InvalidDataException("ruleId is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.RuleId = ruleId;
            }
            // to ensure "baselineVersion" is required (not null)
            if (baselineVersion == null)
            {
                throw new InvalidDataException("baselineVersion is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.BaselineVersion = baselineVersion;
            }
            // to ensure "changeType" is required (not null)
            if (changeType == null)
            {
                throw new InvalidDataException("changeType is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.ChangeType = changeType;
            }
            // to ensure "exists" is required (not null)
            if (exists == null)
            {
                throw new InvalidDataException("exists is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Exists = exists;
            }
            // to ensure "severity" is required (not null)
            if (severity == null)
            {
                throw new InvalidDataException("severity is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Severity = severity;
            }
            // to ensure "timeDetected" is required (not null)
            if (timeDetected == null)
            {
                throw new InvalidDataException("timeDetected is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.TimeDetected = timeDetected;
            }
            // to ensure "promotionComment" is required (not null)
            if (promotionComment == null)
            {
                throw new InvalidDataException("promotionComment is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.PromotionComment = promotionComment;
            }
            // to ensure "approvalId" is required (not null)
            if (approvalId == null)
            {
                throw new InvalidDataException("approvalId is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.ApprovalId = approvalId;
            }
            // to ensure "outsideMaintenanceWindow" is required (not null)
            if (outsideMaintenanceWindow == null)
            {
                throw new InvalidDataException("outsideMaintenanceWindow is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.OutsideMaintenanceWindow = outsideMaintenanceWindow;
            }
            // to ensure "scanId" is required (not null)
            if (scanId == null)
            {
                throw new InvalidDataException("scanId is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.ScanId = scanId;
            }
            // to ensure "md5" is required (not null)
            if (md5 == null)
            {
                throw new InvalidDataException("md5 is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Md5 = md5;
            }
            // to ensure "sha1" is required (not null)
            if (sha1 == null)
            {
                throw new InvalidDataException("sha1 is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Sha1 = sha1;
            }
            // to ensure "sha256" is required (not null)
            if (sha256 == null)
            {
                throw new InvalidDataException("sha256 is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Sha256 = sha256;
            }
            // to ensure "sha512" is required (not null)
            if (sha512 == null)
            {
                throw new InvalidDataException("sha512 is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.Sha512 = sha512;
            }
            // to ensure "isPromoted" is required (not null)
            if (isPromoted == null)
            {
                throw new InvalidDataException("isPromoted is a required property for ElementVersion and cannot be null");
            }
            else
            {
                this.IsPromoted = isPromoted;
            }
        }
        
        /// <summary>
        /// Readable-Key identity of the element version
        /// </summary>
        /// <value>Readable-Key identity of the element version</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the element, such as filename, or registry key name
        /// </summary>
        /// <value>The name of the element, such as filename, or registry key name</value>
        [DataMember(Name="elementName", EmitDefaultValue=false)]
        public string ElementName { get; set; }

        /// <summary>
        /// The name of the Node the element version was detected on
        /// </summary>
        /// <value>The name of the Node the element version was detected on</value>
        [DataMember(Name="nodeName", EmitDefaultValue=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// The name of the rule the defining how the element version should be monitored
        /// </summary>
        /// <value>The name of the rule the defining how the element version should be monitored</value>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Readable-Key identity of the element
        /// </summary>
        /// <value>Readable-Key identity of the element</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// Readable-Key identity of the node
        /// </summary>
        /// <value>Readable-Key identity of the node</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Readable-Key identity of the rule
        /// </summary>
        /// <value>Readable-Key identity of the rule</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// Readable-key identity of previous baseline element version
        /// </summary>
        /// <value>Readable-key identity of previous baseline element version</value>
        [DataMember(Name="baselineVersion", EmitDefaultValue=false)]
        public string BaselineVersion { get; set; }

        /// <summary>
        /// Indicates if this change is an initial baseline snapshot, a modification, or removal of the element, or an additional element since the last scan
        /// </summary>
        /// <value>Indicates if this change is an initial baseline snapshot, a modification, or removal of the element, or an additional element since the last scan</value>
        [DataMember(Name="changeType", EmitDefaultValue=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// True if the element existed on the monitored host at the time of the scan
        /// </summary>
        /// <value>True if the element existed on the monitored host at the time of the scan</value>
        [DataMember(Name="exists", EmitDefaultValue=false)]
        public bool? Exists { get; set; }

        /// <summary>
        /// Assigned severity for this element based on options in the rule, startpoints, and attribute criteria (modifiable)
        /// </summary>
        /// <value>Assigned severity for this element based on options in the rule, startpoints, and attribute criteria (modifiable)</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public int? Severity { get; set; }

        /// <summary>
        /// Timestamp indicating when the scanning mechanism detected the change
        /// </summary>
        /// <value>Timestamp indicating when the scanning mechanism detected the change</value>
        [DataMember(Name="timeDetected", EmitDefaultValue=false)]
        public string TimeDetected { get; set; }

        /// <summary>
        /// Timestamp indicating when the Tripwire Enterprise server received the change
        /// </summary>
        /// <value>Timestamp indicating when the Tripwire Enterprise server received the change</value>
        [DataMember(Name="timeReceived", EmitDefaultValue=false)]
        public string TimeReceived { get; private set; }

        /// <summary>
        /// User supplied meta data assigned when element versions are promoted to approved state
        /// </summary>
        /// <value>User supplied meta data assigned when element versions are promoted to approved state</value>
        [DataMember(Name="promotionComment", EmitDefaultValue=false)]
        public string PromotionComment { get; set; }

        /// <summary>
        /// User supplied id used to correlate approvals to external tracking systems
        /// </summary>
        /// <value>User supplied id used to correlate approvals to external tracking systems</value>
        [DataMember(Name="approvalId", EmitDefaultValue=false)]
        public string ApprovalId { get; set; }

        /// <summary>
        /// Gets or Sets OutsideMaintenanceWindow
        /// </summary>
        [DataMember(Name="outsideMaintenanceWindow", EmitDefaultValue=false)]
        public bool? OutsideMaintenanceWindow { get; set; }

        /// <summary>
        /// An id assigned to the scan occurance
        /// </summary>
        /// <value>An id assigned to the scan occurance</value>
        [DataMember(Name="scanId", EmitDefaultValue=false)]
        public string ScanId { get; set; }

        /// <summary>
        /// The MD5 hash of the content of this element version
        /// </summary>
        /// <value>The MD5 hash of the content of this element version</value>
        [DataMember(Name="md5", EmitDefaultValue=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// The SHA-1 hash of the content of this element version
        /// </summary>
        /// <value>The SHA-1 hash of the content of this element version</value>
        [DataMember(Name="sha1", EmitDefaultValue=false)]
        public string Sha1 { get; set; }

        /// <summary>
        /// The SHA-256 hash of the content of this element version
        /// </summary>
        /// <value>The SHA-256 hash of the content of this element version</value>
        [DataMember(Name="sha256", EmitDefaultValue=false)]
        public string Sha256 { get; set; }

        /// <summary>
        /// The SHA-512 hash of the content of this element version
        /// </summary>
        /// <value>The SHA-512 hash of the content of this element version</value>
        [DataMember(Name="sha512", EmitDefaultValue=false)]
        public string Sha512 { get; set; }

        /// <summary>
        /// True if the element version has been promoted
        /// </summary>
        /// <value>True if the element version has been promoted</value>
        [DataMember(Name="isPromoted", EmitDefaultValue=false)]
        public bool? IsPromoted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementVersion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ElementName: ").Append(ElementName).Append("\n");
            sb.Append("  NodeName: ").Append(NodeName).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  BaselineVersion: ").Append(BaselineVersion).Append("\n");
            sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  TimeDetected: ").Append(TimeDetected).Append("\n");
            sb.Append("  TimeReceived: ").Append(TimeReceived).Append("\n");
            sb.Append("  PromotionComment: ").Append(PromotionComment).Append("\n");
            sb.Append("  ApprovalId: ").Append(ApprovalId).Append("\n");
            sb.Append("  OutsideMaintenanceWindow: ").Append(OutsideMaintenanceWindow).Append("\n");
            sb.Append("  ScanId: ").Append(ScanId).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  Sha1: ").Append(Sha1).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  Sha512: ").Append(Sha512).Append("\n");
            sb.Append("  IsPromoted: ").Append(IsPromoted).Append("\n");
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
            return this.Equals(input as ElementVersion);
        }

        /// <summary>
        /// Returns true if ElementVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementVersion input)
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
                    this.ElementName == input.ElementName ||
                    (this.ElementName != null &&
                    this.ElementName.Equals(input.ElementName))
                ) && 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.BaselineVersion == input.BaselineVersion ||
                    (this.BaselineVersion != null &&
                    this.BaselineVersion.Equals(input.BaselineVersion))
                ) && 
                (
                    this.ChangeType == input.ChangeType ||
                    (this.ChangeType != null &&
                    this.ChangeType.Equals(input.ChangeType))
                ) && 
                (
                    this.Exists == input.Exists ||
                    (this.Exists != null &&
                    this.Exists.Equals(input.Exists))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.TimeDetected == input.TimeDetected ||
                    (this.TimeDetected != null &&
                    this.TimeDetected.Equals(input.TimeDetected))
                ) && 
                (
                    this.TimeReceived == input.TimeReceived ||
                    (this.TimeReceived != null &&
                    this.TimeReceived.Equals(input.TimeReceived))
                ) && 
                (
                    this.PromotionComment == input.PromotionComment ||
                    (this.PromotionComment != null &&
                    this.PromotionComment.Equals(input.PromotionComment))
                ) && 
                (
                    this.ApprovalId == input.ApprovalId ||
                    (this.ApprovalId != null &&
                    this.ApprovalId.Equals(input.ApprovalId))
                ) && 
                (
                    this.OutsideMaintenanceWindow == input.OutsideMaintenanceWindow ||
                    (this.OutsideMaintenanceWindow != null &&
                    this.OutsideMaintenanceWindow.Equals(input.OutsideMaintenanceWindow))
                ) && 
                (
                    this.ScanId == input.ScanId ||
                    (this.ScanId != null &&
                    this.ScanId.Equals(input.ScanId))
                ) && 
                (
                    this.Md5 == input.Md5 ||
                    (this.Md5 != null &&
                    this.Md5.Equals(input.Md5))
                ) && 
                (
                    this.Sha1 == input.Sha1 ||
                    (this.Sha1 != null &&
                    this.Sha1.Equals(input.Sha1))
                ) && 
                (
                    this.Sha256 == input.Sha256 ||
                    (this.Sha256 != null &&
                    this.Sha256.Equals(input.Sha256))
                ) && 
                (
                    this.Sha512 == input.Sha512 ||
                    (this.Sha512 != null &&
                    this.Sha512.Equals(input.Sha512))
                ) && 
                (
                    this.IsPromoted == input.IsPromoted ||
                    (this.IsPromoted != null &&
                    this.IsPromoted.Equals(input.IsPromoted))
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
                if (this.ElementName != null)
                    hashCode = hashCode * 59 + this.ElementName.GetHashCode();
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.BaselineVersion != null)
                    hashCode = hashCode * 59 + this.BaselineVersion.GetHashCode();
                if (this.ChangeType != null)
                    hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.Exists != null)
                    hashCode = hashCode * 59 + this.Exists.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.TimeDetected != null)
                    hashCode = hashCode * 59 + this.TimeDetected.GetHashCode();
                if (this.TimeReceived != null)
                    hashCode = hashCode * 59 + this.TimeReceived.GetHashCode();
                if (this.PromotionComment != null)
                    hashCode = hashCode * 59 + this.PromotionComment.GetHashCode();
                if (this.ApprovalId != null)
                    hashCode = hashCode * 59 + this.ApprovalId.GetHashCode();
                if (this.OutsideMaintenanceWindow != null)
                    hashCode = hashCode * 59 + this.OutsideMaintenanceWindow.GetHashCode();
                if (this.ScanId != null)
                    hashCode = hashCode * 59 + this.ScanId.GetHashCode();
                if (this.Md5 != null)
                    hashCode = hashCode * 59 + this.Md5.GetHashCode();
                if (this.Sha1 != null)
                    hashCode = hashCode * 59 + this.Sha1.GetHashCode();
                if (this.Sha256 != null)
                    hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                if (this.Sha512 != null)
                    hashCode = hashCode * 59 + this.Sha512.GetHashCode();
                if (this.IsPromoted != null)
                    hashCode = hashCode * 59 + this.IsPromoted.GetHashCode();
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
