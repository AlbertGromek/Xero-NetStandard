/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.6.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// PayTemplate
    /// </summary>
    [DataContract]
    public partial class PayTemplate :  IEquatable<PayTemplate>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets EarningsLines
        /// </summary>
        [DataMember(Name="EarningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> EarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets DeductionLines
        /// </summary>
        [DataMember(Name="DeductionLines", EmitDefaultValue=false)]
        public List<DeductionLine> DeductionLines { get; set; }

        /// <summary>
        /// Gets or Sets SuperLines
        /// </summary>
        [DataMember(Name="SuperLines", EmitDefaultValue=false)]
        public List<SuperLine> SuperLines { get; set; }

        /// <summary>
        /// Gets or Sets ReimbursementLines
        /// </summary>
        [DataMember(Name="ReimbursementLines", EmitDefaultValue=false)]
        public List<ReimbursementLine> ReimbursementLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveLines
        /// </summary>
        [DataMember(Name="LeaveLines", EmitDefaultValue=false)]
        public List<LeaveLine> LeaveLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayTemplate {\n");
            sb.Append("  EarningsLines: ").Append(EarningsLines).Append("\n");
            sb.Append("  DeductionLines: ").Append(DeductionLines).Append("\n");
            sb.Append("  SuperLines: ").Append(SuperLines).Append("\n");
            sb.Append("  ReimbursementLines: ").Append(ReimbursementLines).Append("\n");
            sb.Append("  LeaveLines: ").Append(LeaveLines).Append("\n");
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
            return this.Equals(input as PayTemplate);
        }

        /// <summary>
        /// Returns true if PayTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of PayTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsLines == input.EarningsLines ||
                    this.EarningsLines != null &&
                    input.EarningsLines != null &&
                    this.EarningsLines.SequenceEqual(input.EarningsLines)
                ) && 
                (
                    this.DeductionLines == input.DeductionLines ||
                    this.DeductionLines != null &&
                    input.DeductionLines != null &&
                    this.DeductionLines.SequenceEqual(input.DeductionLines)
                ) && 
                (
                    this.SuperLines == input.SuperLines ||
                    this.SuperLines != null &&
                    input.SuperLines != null &&
                    this.SuperLines.SequenceEqual(input.SuperLines)
                ) && 
                (
                    this.ReimbursementLines == input.ReimbursementLines ||
                    this.ReimbursementLines != null &&
                    input.ReimbursementLines != null &&
                    this.ReimbursementLines.SequenceEqual(input.ReimbursementLines)
                ) && 
                (
                    this.LeaveLines == input.LeaveLines ||
                    this.LeaveLines != null &&
                    input.LeaveLines != null &&
                    this.LeaveLines.SequenceEqual(input.LeaveLines)
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
                if (this.EarningsLines != null)
                    hashCode = hashCode * 59 + this.EarningsLines.GetHashCode();
                if (this.DeductionLines != null)
                    hashCode = hashCode * 59 + this.DeductionLines.GetHashCode();
                if (this.SuperLines != null)
                    hashCode = hashCode * 59 + this.SuperLines.GetHashCode();
                if (this.ReimbursementLines != null)
                    hashCode = hashCode * 59 + this.ReimbursementLines.GetHashCode();
                if (this.LeaveLines != null)
                    hashCode = hashCode * 59 + this.LeaveLines.GetHashCode();
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
