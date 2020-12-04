/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
 *
 * The version of the OpenAPI document: 2.6.0
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

namespace Xero.NetStandard.OAuth2.Model.Bankfeeds
{
    /// <summary>
    /// The starting balance of the statement
    /// </summary>
    [DataContract]
    public partial class StartBalance :  IEquatable<StartBalance>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CreditDebitIndicator
        /// </summary>
        [DataMember(Name="creditDebitIndicator", EmitDefaultValue=false)]
        public CreditDebitIndicator CreditDebitIndicator { get; set; }
        
        /// <summary>
        /// decimal(19,4) unsigned Opening/closing balance amount.
        /// </summary>
        /// <value>decimal(19,4) unsigned Opening/closing balance amount.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartBalance {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreditDebitIndicator: ").Append(CreditDebitIndicator).Append("\n");
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
            return this.Equals(input as StartBalance);
        }

        /// <summary>
        /// Returns true if StartBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of StartBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.CreditDebitIndicator == input.CreditDebitIndicator ||
                    this.CreditDebitIndicator.Equals(input.CreditDebitIndicator)
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
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.CreditDebitIndicator.GetHashCode();
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