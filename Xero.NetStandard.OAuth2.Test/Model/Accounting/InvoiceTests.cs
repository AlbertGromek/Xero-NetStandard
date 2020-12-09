/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Xero.NetStandard.OAuth2.Test.Model.Accounting
{
    /// <summary>
    ///  Class for testing Invoice
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InvoiceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Invoice
        //private Invoice instance;

        public InvoiceTests()
        {
            // TODO uncomment below to create an instance of Invoice
            //instance = new Invoice();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Invoice
        /// </summary>
        [Fact]
        public void InvoiceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Invoice
            //Assert.IsInstanceOfType<Invoice> (instance, "variable 'instance' is a Invoice");
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Contact'
        /// </summary>
        [Fact]
        public void ContactTest()
        {
            // TODO unit test for the property 'Contact'
        }
        /// <summary>
        /// Test the property 'LineItems'
        /// </summary>
        [Fact]
        public void LineItemsTest()
        {
            // TODO unit test for the property 'LineItems'
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Fact]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }
        /// <summary>
        /// Test the property 'LineAmountTypes'
        /// </summary>
        [Fact]
        public void LineAmountTypesTest()
        {
            // TODO unit test for the property 'LineAmountTypes'
        }
        /// <summary>
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [Fact]
        public void InvoiceNumberTest()
        {
            // TODO unit test for the property 'InvoiceNumber'
        }
        /// <summary>
        /// Test the property 'Reference'
        /// </summary>
        [Fact]
        public void ReferenceTest()
        {
            // TODO unit test for the property 'Reference'
        }
        /// <summary>
        /// Test the property 'BrandingThemeID'
        /// </summary>
        [Fact]
        public void BrandingThemeIDTest()
        {
            // TODO unit test for the property 'BrandingThemeID'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Fact]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'CurrencyRate'
        /// </summary>
        [Fact]
        public void CurrencyRateTest()
        {
            // TODO unit test for the property 'CurrencyRate'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'SentToContact'
        /// </summary>
        [Fact]
        public void SentToContactTest()
        {
            // TODO unit test for the property 'SentToContact'
        }
        /// <summary>
        /// Test the property 'ExpectedPaymentDate'
        /// </summary>
        [Fact]
        public void ExpectedPaymentDateTest()
        {
            // TODO unit test for the property 'ExpectedPaymentDate'
        }
        /// <summary>
        /// Test the property 'PlannedPaymentDate'
        /// </summary>
        [Fact]
        public void PlannedPaymentDateTest()
        {
            // TODO unit test for the property 'PlannedPaymentDate'
        }
        /// <summary>
        /// Test the property 'CISDeduction'
        /// </summary>
        [Fact]
        public void CISDeductionTest()
        {
            // TODO unit test for the property 'CISDeduction'
        }
        /// <summary>
        /// Test the property 'SubTotal'
        /// </summary>
        [Fact]
        public void SubTotalTest()
        {
            // TODO unit test for the property 'SubTotal'
        }
        /// <summary>
        /// Test the property 'TotalTax'
        /// </summary>
        [Fact]
        public void TotalTaxTest()
        {
            // TODO unit test for the property 'TotalTax'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'TotalDiscount'
        /// </summary>
        [Fact]
        public void TotalDiscountTest()
        {
            // TODO unit test for the property 'TotalDiscount'
        }
        /// <summary>
        /// Test the property 'InvoiceID'
        /// </summary>
        [Fact]
        public void InvoiceIDTest()
        {
            // TODO unit test for the property 'InvoiceID'
        }
        /// <summary>
        /// Test the property 'HasAttachments'
        /// </summary>
        [Fact]
        public void HasAttachmentsTest()
        {
            // TODO unit test for the property 'HasAttachments'
        }
        /// <summary>
        /// Test the property 'IsDiscounted'
        /// </summary>
        [Fact]
        public void IsDiscountedTest()
        {
            // TODO unit test for the property 'IsDiscounted'
        }
        /// <summary>
        /// Test the property 'Payments'
        /// </summary>
        [Fact]
        public void PaymentsTest()
        {
            // TODO unit test for the property 'Payments'
        }
        /// <summary>
        /// Test the property 'Prepayments'
        /// </summary>
        [Fact]
        public void PrepaymentsTest()
        {
            // TODO unit test for the property 'Prepayments'
        }
        /// <summary>
        /// Test the property 'Overpayments'
        /// </summary>
        [Fact]
        public void OverpaymentsTest()
        {
            // TODO unit test for the property 'Overpayments'
        }
        /// <summary>
        /// Test the property 'AmountDue'
        /// </summary>
        [Fact]
        public void AmountDueTest()
        {
            // TODO unit test for the property 'AmountDue'
        }
        /// <summary>
        /// Test the property 'AmountPaid'
        /// </summary>
        [Fact]
        public void AmountPaidTest()
        {
            // TODO unit test for the property 'AmountPaid'
        }
        /// <summary>
        /// Test the property 'FullyPaidOnDate'
        /// </summary>
        [Fact]
        public void FullyPaidOnDateTest()
        {
            // TODO unit test for the property 'FullyPaidOnDate'
        }
        /// <summary>
        /// Test the property 'AmountCredited'
        /// </summary>
        [Fact]
        public void AmountCreditedTest()
        {
            // TODO unit test for the property 'AmountCredited'
        }
        /// <summary>
        /// Test the property 'UpdatedDateUTC'
        /// </summary>
        [Fact]
        public void UpdatedDateUTCTest()
        {
            // TODO unit test for the property 'UpdatedDateUTC'
        }
        /// <summary>
        /// Test the property 'CreditNotes'
        /// </summary>
        [Fact]
        public void CreditNotesTest()
        {
            // TODO unit test for the property 'CreditNotes'
        }
        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }
        /// <summary>
        /// Test the property 'HasErrors'
        /// </summary>
        [Fact]
        public void HasErrorsTest()
        {
            // TODO unit test for the property 'HasErrors'
        }
        /// <summary>
        /// Test the property 'StatusAttributeString'
        /// </summary>
        [Fact]
        public void StatusAttributeStringTest()
        {
            // TODO unit test for the property 'StatusAttributeString'
        }
        /// <summary>
        /// Test the property 'ValidationErrors'
        /// </summary>
        [Fact]
        public void ValidationErrorsTest()
        {
            // TODO unit test for the property 'ValidationErrors'
        }

    }

}