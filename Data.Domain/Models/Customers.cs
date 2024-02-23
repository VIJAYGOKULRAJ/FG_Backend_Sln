using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain.Models
{
    public class Customers
    {
        [DisplayName("ID")]
        public string? Id { get; set; }

        [DisplayName("Company ID")]
        public string? CompanyId { get; set; }

        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }

        [DisplayName("Created By")]
        public string? CreatedBy { get; set; }

        [StringLength(50)]
        [DisplayName("Customer Type")]
        public string? CustomerType { get; set; }

        [StringLength(50)]
        [DisplayName("Account Type")]
        public string AccountType { get; set; }

        [StringLength(50)]
        [DisplayName("Account Type Id")]
        public string AccountTypeId { get; set; }

        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [StringLength(50)]
        [DisplayName("Fax")]
        public string Fax { get; set; }

        [StringLength(50)]
        [DisplayName("Mobile")]
        public string Mobile { get; set; }

        [StringLength(50)]
        [DisplayName("Phone Work")]
        public string PhoneWork { get; set; }

        [Email]
        [StringLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Email]
        [StringLength(75)]
        [DisplayName("Billing Department Email")]
        public string BillingDepartmentEmail { get; set; }

        [StringLength(100)]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [StringLength(100)]
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        [StringLength(100)]
        [DisplayName("Physical Address 1")]
        public string PhysicalAddress1 { get; set; }

        [StringLength(100)]
        [DisplayName("Physical Address 2")]
        public string PhysicalAddress2 { get; set; }

        [StringLength(50)]
        [DisplayName("Physical City")]
        public string PhysicalCity { get; set; }

        [StringLength(50)]
        [DisplayName("Physical State")]
        public string PhysicalState { get; set; }

        [StringLength(50)]
        [DisplayName("Physical Zip")]
        public string PhysicalZip { get; set; }

        [StringLength(75)]
        [DisplayName("Physical County")]
        public string PhysicalCounty { get; set; }

        [StringLength(100)]
        [DisplayName("Billing Address 1")]
        public string BillingAddress1 { get; set; }

        [StringLength(100)]
        [DisplayName("Billing Address 2")]
        public string BillingAddress2 { get; set; }

        [StringLength(50)]
        [DisplayName("Billing City")]
        public string BillingCity { get; set; }

        [StringLength(50)]
        [DisplayName("Billing State")]
        public string BillingState { get; set; }

        [StringLength(50)]
        [DisplayName("Billing Zip")]
        public string BillingZip { get; set; }

        [DisplayName("Master Account")]
        public bool? MasterAccount { get; set; }

        [DisplayName("Active")]
        public bool? Active { get; set; }

        [StringLength(50)]
        [DisplayName("Lead Source")]
        public string? LeadSource { get; set; }

        [DisplayName("Notes")]
        public string? Notes { get; set; }

        [DisplayName("Custom Field 1")]
        public string? CustomField1 { get; set; }

        [DisplayName("Custom Field 2")]
        public string? CustomField2 { get; set; }

        [DisplayName("Custom Field 3")]
        public string? CustomField3 { get; set; }

        [DisplayName("Custom Field 4")]
        public string? CustomField4 { get; set; }

        [DisplayName("Custom Field 5")]
        public string? CustomField5 { get; set; }

        [StringLength(150)]
        [DisplayName("Salesperson")]
        public string? Salesman { get; set; }

        [StringLength(50)]
        [DisplayName("Preferred Invoice Method")]
        public string? PreferredInvoiceMethod { get; set; }

        [StringLength(100)]
        [DisplayName("Website")]
        public string? Website { get; set; }

        [DisplayName("Discount")]
        public decimal? Discount { get; set; }

        [DisplayName("House Account")]
        public bool? HouseAccount { get; set; }

        [DisplayName("Credit Hold")]
        public bool? CreditHold { get; set; }

        [DisplayName("Do Not Quote")]
        public bool? DoNotQuote { get; set; }

        [DisplayName("Number")]
        public int? Number { get; set; }

        [DisplayName("Date Modified")]
        public DateTime? DateModified { get; set; }

        [DisplayName("Credit Balance")]
        public decimal? CreditBalance { get; set; }

        [DisplayName("Opt Out SMS Messages")]
        public bool? OptOutSmsMessages { get; set; }

        [DisplayName("Opt Out Of Event and Invoice Reminders")]
        public bool? OptOutOfReminders { get; set; }

        [DisplayName("Pending Credit Approval")]
        public bool? PendingCreditApproval { get; set; }

        [StringLength(50)]
        [DisplayName("Quickbooks ID")]
        public string? QuickbooksId { get; set; }

        [DisplayName("Quickbooks Sync Date")]
        public DateTime? QuickbooksSyncDate { get; set; }

        [StringLength(50)]
        [DisplayName("Quickbooks Sync Token")]
        public string? QuickbooksSyncToken { get; set; }

        [StringLength(50)]
        [DisplayName("Latitude")]
        public string? Latitude { get; set; }

        [StringLength(50)]
        [DisplayName("Longitude")]
        public string? Longitude { get; set; }

        [StringLength(50)]
        [DisplayName("Paya Vault ID")]
        public string? PayaVaultId { get; set; }

        [StringLength(100)]
        [DisplayName("Payment Method Preview")]
        public string? PaymentMethodPreview { get; set; }

        [StringLength(50)]
        [DisplayName("Paya Vault Location ID")]
        public string? PayaVaultLocationId { get; set; }

        [StringLength(50)]
        [DisplayName("Token")]
        public string? Token { get; set; }

        [DisplayName("Opt out of future estimate reminders")]
        public bool? OptOutEstimateReminders { get; set; }

        [StringLength(50)]
        [DisplayName("QuickBookDesktopID")]
        public string? QuickBookDesktopID { get; set; }

        [DisplayName("Quickbooks Desktop Sync Date")]
        public DateTime? QuickBooksDesktopSyncDate { get; set; }
    }
}
