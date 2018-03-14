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
    /// Policy test results represent the compliance status for a specific policy test and node.
    /// </summary>
    [DataContract]
    public partial class PolicyTestResult :  IEquatable<PolicyTestResult>, IValidatableObject
    {
        /// <summary>
        /// One of PASSED, FAILED, ERROR, or UNKNOWN, where UNKNOWN indicates no result value was produced, ERROR indicates that policy test evaluation failed, and PASSED or FAILED indicate the compliance state
        /// </summary>
        /// <value>One of PASSED, FAILED, ERROR, or UNKNOWN, where UNKNOWN indicates no result value was produced, ERROR indicates that policy test evaluation failed, and PASSED or FAILED indicate the compliance state</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum PASSED for value: PASSED
            /// </summary>
            [EnumMember(Value = "PASSED")]
            PASSED = 1,
            
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 2,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 4
        }

        /// <summary>
        /// One of PASSED, FAILED, ERROR, or UNKNOWN, where UNKNOWN indicates no result value was produced, ERROR indicates that policy test evaluation failed, and PASSED or FAILED indicate the compliance state
        /// </summary>
        /// <value>One of PASSED, FAILED, ERROR, or UNKNOWN, where UNKNOWN indicates no result value was produced, ERROR indicates that policy test evaluation failed, and PASSED or FAILED indicate the compliance state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Summary state for all element versions that comprise the policy test result.
        /// </summary>
        /// <value>Summary state for all element versions that comprise the policy test result.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SummaryStateEnum
        {
            
            /// <summary>
            /// Enum PASSED for value: PASSED
            /// </summary>
            [EnumMember(Value = "PASSED")]
            PASSED = 1,
            
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 2,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 4
        }

        /// <summary>
        /// Summary state for all element versions that comprise the policy test result.
        /// </summary>
        /// <value>Summary state for all element versions that comprise the policy test result.</value>
        [DataMember(Name="summaryState", EmitDefaultValue=false)]
        public SummaryStateEnum? SummaryState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTestResult" /> class.
        /// </summary>
        /// <param name="id">Readable-key identity of the policy test result.</param>
        /// <param name="policyTestId">Readable-key identity of the policy test that produced this result.</param>
        /// <param name="policyTestName">Name of the policy test that produced this result.</param>
        /// <param name="elementId">The ID of the element that produced this policy test result..</param>
        /// <param name="elementName">The name of the element that produced this policy test result..</param>
        /// <param name="elementVersionId">The ID of the element version that produced this policy test result..</param>
        /// <param name="nodeId">Readable-key identity of the node that produced this result.</param>
        /// <param name="nodeLabel">Name of the node that produced this result.</param>
        /// <param name="state">One of PASSED, FAILED, ERROR, or UNKNOWN, where UNKNOWN indicates no result value was produced, ERROR indicates that policy test evaluation failed, and PASSED or FAILED indicate the compliance state.</param>
        /// <param name="creationTime">Timestamp indicating when this policy test result was produced..</param>
        /// <param name="expected">The value or expression required to pass the test.</param>
        /// <param name="actual">The actual value found on the node.</param>
        /// <param name="summaryState">Summary state for all element versions that comprise the policy test result..</param>
        public PolicyTestResult(string id = default(string), string policyTestId = default(string), string policyTestName = default(string), string elementId = default(string), string elementName = default(string), string elementVersionId = default(string), string nodeId = default(string), string nodeLabel = default(string), StateEnum? state = default(StateEnum?), string creationTime = default(string), string expected = default(string), string actual = default(string), SummaryStateEnum? summaryState = default(SummaryStateEnum?))
        {
            this.Id = id;
            this.PolicyTestId = policyTestId;
            this.PolicyTestName = policyTestName;
            this.ElementId = elementId;
            this.ElementName = elementName;
            this.ElementVersionId = elementVersionId;
            this.NodeId = nodeId;
            this.NodeLabel = nodeLabel;
            this.State = state;
            this.CreationTime = creationTime;
            this.Expected = expected;
            this.Actual = actual;
            this.SummaryState = summaryState;
        }
        
        /// <summary>
        /// Readable-key identity of the policy test result
        /// </summary>
        /// <value>Readable-key identity of the policy test result</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Readable-key identity of the policy test that produced this result
        /// </summary>
        /// <value>Readable-key identity of the policy test that produced this result</value>
        [DataMember(Name="policyTestId", EmitDefaultValue=false)]
        public string PolicyTestId { get; set; }

        /// <summary>
        /// Name of the policy test that produced this result
        /// </summary>
        /// <value>Name of the policy test that produced this result</value>
        [DataMember(Name="policyTestName", EmitDefaultValue=false)]
        public string PolicyTestName { get; set; }

        /// <summary>
        /// The ID of the element that produced this policy test result.
        /// </summary>
        /// <value>The ID of the element that produced this policy test result.</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// The name of the element that produced this policy test result.
        /// </summary>
        /// <value>The name of the element that produced this policy test result.</value>
        [DataMember(Name="elementName", EmitDefaultValue=false)]
        public string ElementName { get; set; }

        /// <summary>
        /// The ID of the element version that produced this policy test result.
        /// </summary>
        /// <value>The ID of the element version that produced this policy test result.</value>
        [DataMember(Name="elementVersionId", EmitDefaultValue=false)]
        public string ElementVersionId { get; set; }

        /// <summary>
        /// Readable-key identity of the node that produced this result
        /// </summary>
        /// <value>Readable-key identity of the node that produced this result</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Name of the node that produced this result
        /// </summary>
        /// <value>Name of the node that produced this result</value>
        [DataMember(Name="nodeLabel", EmitDefaultValue=false)]
        public string NodeLabel { get; set; }


        /// <summary>
        /// Timestamp indicating when this policy test result was produced.
        /// </summary>
        /// <value>Timestamp indicating when this policy test result was produced.</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The value or expression required to pass the test
        /// </summary>
        /// <value>The value or expression required to pass the test</value>
        [DataMember(Name="expected", EmitDefaultValue=false)]
        public string Expected { get; set; }

        /// <summary>
        /// The actual value found on the node
        /// </summary>
        /// <value>The actual value found on the node</value>
        [DataMember(Name="actual", EmitDefaultValue=false)]
        public string Actual { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTestResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PolicyTestId: ").Append(PolicyTestId).Append("\n");
            sb.Append("  PolicyTestName: ").Append(PolicyTestName).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  ElementName: ").Append(ElementName).Append("\n");
            sb.Append("  ElementVersionId: ").Append(ElementVersionId).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  NodeLabel: ").Append(NodeLabel).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Expected: ").Append(Expected).Append("\n");
            sb.Append("  Actual: ").Append(Actual).Append("\n");
            sb.Append("  SummaryState: ").Append(SummaryState).Append("\n");
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
            return this.Equals(input as PolicyTestResult);
        }

        /// <summary>
        /// Returns true if PolicyTestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyTestResult input)
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
                    this.PolicyTestId == input.PolicyTestId ||
                    (this.PolicyTestId != null &&
                    this.PolicyTestId.Equals(input.PolicyTestId))
                ) && 
                (
                    this.PolicyTestName == input.PolicyTestName ||
                    (this.PolicyTestName != null &&
                    this.PolicyTestName.Equals(input.PolicyTestName))
                ) && 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.ElementName == input.ElementName ||
                    (this.ElementName != null &&
                    this.ElementName.Equals(input.ElementName))
                ) && 
                (
                    this.ElementVersionId == input.ElementVersionId ||
                    (this.ElementVersionId != null &&
                    this.ElementVersionId.Equals(input.ElementVersionId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NodeLabel == input.NodeLabel ||
                    (this.NodeLabel != null &&
                    this.NodeLabel.Equals(input.NodeLabel))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.Expected == input.Expected ||
                    (this.Expected != null &&
                    this.Expected.Equals(input.Expected))
                ) && 
                (
                    this.Actual == input.Actual ||
                    (this.Actual != null &&
                    this.Actual.Equals(input.Actual))
                ) && 
                (
                    this.SummaryState == input.SummaryState ||
                    (this.SummaryState != null &&
                    this.SummaryState.Equals(input.SummaryState))
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
                if (this.PolicyTestId != null)
                    hashCode = hashCode * 59 + this.PolicyTestId.GetHashCode();
                if (this.PolicyTestName != null)
                    hashCode = hashCode * 59 + this.PolicyTestName.GetHashCode();
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.ElementName != null)
                    hashCode = hashCode * 59 + this.ElementName.GetHashCode();
                if (this.ElementVersionId != null)
                    hashCode = hashCode * 59 + this.ElementVersionId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeLabel != null)
                    hashCode = hashCode * 59 + this.NodeLabel.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.Expected != null)
                    hashCode = hashCode * 59 + this.Expected.GetHashCode();
                if (this.Actual != null)
                    hashCode = hashCode * 59 + this.Actual.GetHashCode();
                if (this.SummaryState != null)
                    hashCode = hashCode * 59 + this.SummaryState.GetHashCode();
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
