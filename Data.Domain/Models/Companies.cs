using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain.Models
{
    public class Companies
    {
        [DisplayName("ID")]
        public string Id { get; set; }

        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Date Modified")]
        public DateTime DateModified { get; set; }

        [StringLength(150)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("Industry")]
        public string Industry { get; set; }

        [StringLength(150)]
        [DisplayName("Time Zone")]
        public string TimeZone { get; set; }

        [StringLength(150)]
        [DisplayName("Default Password")]
        public string DefaultPassword { get; set; }

       

        [DisplayName("Logo")]
        public string Logo { get; set; }

        [DisplayName("Lead Sources (Marketing)")]
        public string LeadSources { get; set; }

        [DisplayName("Lead Actions")]
        public string OpportunityActions { get; set; }

        [DisplayName("Opportunity Types")]
        public string ProjectTypes { get; set; }

        [StringLength(250)]
        [DisplayName("Unit of Measures")]
        public string UnitOfMeasures { get; set; }

        [StringLength(250)]
        [DisplayName("Purchase Order Statuses")]
        public string PurchaseOrderStatuses { get; set; }

        [DisplayName("Sales Goal")]
        public decimal SalesGoal { get; set; }

        [StringLength(250)]
        [DisplayName("Default Manufacturer")]
        public string DefaultManufacturer { get; set; }

        [StringLength(255)]
        [DisplayName("Google Refresh Token")]
        public string GoogleOuthRefreshToken { get; set; }

        [StringLength(255)]
        [DisplayName("Google Calendar Id")]
        public string GoogleCalendarId { get; set; }

        [DisplayName("Remove Default Work Order Form")]
        public bool RemoveDefaultWorkOrderForm { get; set; }

        [DisplayName("Display tool list on Work Order")]
        public bool DisplaytoollistonWorkOrder { get; set; }

        [DisplayName("Display Installer Form On Work Order")]
        public bool DisplayInstallerFormOnWorkOrder { get; set; }


        [StringLength(50)]
        [DisplayName("Dashboard Name")]
        public string DashboardName { get; set; }

        [DisplayName("Grouped Inventory View")]
        public bool GroupedInventoryView { get; set; }

        [StringLength(250)]
        [DisplayName("Lead Statuses")]
        public string LeadStatusTypes { get; set; }


        [StringLength(500)]
        [DisplayName("Customer Required Fields")]
        public string CustomerRequiredFields { get; set; }

        [StringLength(50)]
        [DisplayName("Default Event Color")]
        public string DefaultEventColor { get; set; }

        [StringLength(50)]
        [DisplayName("Default Event Text Color")]
        public string DefaultEventTextColor { get; set; }

        [StringLength(500)]
        [DisplayName("Trackable Asset Types")]
        public string TrackableAssetTypes { get; set; }

        [StringLength(250)]
        [DisplayName("Lost Reasons 1")]
        public string LostReasons { get; set; }

        [StringLength(250)]
        [DisplayName("Lost Reasons 2")]
        public string LostReasons2 { get; set; }

        [StringLength(100)]
        [DisplayName("Tracking Application Provider")]
        public string TrackingApplicationProvider { get; set; }

        [StringLength(100)]
        [DisplayName("Tracking Application ID")]
        public string TrackingApplicationId { get; set; }

        [StringLength(100)]
        [DisplayName("Tracking Secret Key")]
        public string TrackingSecretKey { get; set; }

        [StringLength(100)]
        [DisplayName("Tracking Username")]
        public string TrackingApplicationUsername { get; set; }

        [StringLength(100)]
        [DisplayName("Tracking Password")]
        public string TrackingApplicationPassword { get; set; }

        [DisplayName("Field Groove Brand")]
        public bool FieldGrooveBrand { get; set; }

        [DisplayName("Master Demo Account")]
        public bool MasterDemoAccount { get; set; }

        [DisplayName("Demo Account")]
        public bool DemoAccount { get; set; }

        [DisplayName("Bar Color")]
        public string BarColor { get; set; }

        [DisplayName("Number")]
        public int Number { get; set; }

        [StringLength(1000)]
        [DisplayName("Phases")]
        public string Phases { get; set; }

        [StringLength(250)]
        [DisplayName("Installer Pay Schedule")]
        public string InstallerPaySchedule { get; set; }

        [StringLength(400)]
        [DisplayName("Signed Customer Email Subject")]
        public string SignedCustomerEmailSubject { get; set; }


        [StringLength(8000)]
        [DisplayName("Signed Customer Email Message")]
        public string SignedCustomerEmailMessage { get; set; }

        [DisplayName("Disable Billing")]
        public bool DisableBilling { get; set; }

        [DisplayName("Monthly Billing Cap")]
        public decimal MonthlyBillingCap { get; set; }

        [DisplayName("Auto Round Pricing")]
        public string AutoRoundPricing { get; set; }

        [DisplayName("Sms - Time of Notification")]
        public string SmsHourOfDay { get; set; }

        [DisplayName("Sms - Days prior to event")]

        public string SmsSetting { get; set; }

        [DisplayName("Sms Notification Content")]
        public string SmsText { get; set; }

        [DisplayName("Sub Merchant ID")]
        public string SubMerchantId { get; set; }

        [DisplayName("Sub Merchant Account Preview")]
        public string SubMerchantAccountPreview { get; set; }

        [DisplayName("Sub Merchant Rate")]
        public decimal SubMerchantRate { get; set; }

        [DisplayName("Convenience Fee Rate")]
        public decimal ConvenienceFeeRate { get; set; }

        [DisplayName("Billing Start Date")]
        public string BillingStartDate { get; set; }


        [DisplayName("Percentage Of Labor On Work Order")]
        public decimal PercentageOfLaborOnWorkOrder { get; set; }

        [DisplayName("GL Categories")]
        public string GlCategories { get; set; }

        [DisplayName("Hide Phase Totals")]
        public bool HidePhaseTotals { get; set; }

        [DisplayName("Hide Estimate Totals")]
        public bool HideEstimateTotals { get; set; }

        [DisplayName("Collapse Base Estimate by Default")]
        public bool CollapseBaseEstimateByDefault { get; set; }

        [DisplayName("House Account Sales Commission Rate")]
        public decimal HouseAccountSalesCommissionRate { get; set; }

        [DisplayName("House Account Estimator Rate")]
        public decimal HouseAccountEstimatorCommissionRate { get; set; }

        [DisplayName("House Account Project Management Rate")]
        public decimal HouseAccountProjectManagementCommissionRate { get; set; }

        [DisplayName("Auto Mark Lost Days")]
        public int AutoMarkLostDays { get; set; }

        [DisplayName("Show Contact On Estimate")]
        public bool ShowContactOnEstimate { get; set; }

        [StringLength(500)]
        [DisplayName("Proposal Acceptance Text")]
        public string ProposalAcceptanceText { get; set; }

        [StringLength(800)]
        [DisplayName("Customer Acceptance Text")]
        public string CustomerAcceptanceText { get; set; }

        [DisplayName("Calendar Start Day")]
        public int CalendarStartDay { get; set; }

        [StringLength(100)]
        [DisplayName("Invoice Email Subject")]
        public string InvoiceEmailSubject { get; set; }

        [DisplayName("Tax Subtotal")]
        public bool TaxSubtotal { get; set; }

        [StringLength(1000)]
        [DisplayName("Yes Or No Questions")]
        public string YesOrNoQuestions { get; set; }

        [StringLength(1000)]
        [DisplayName("Work Order Tools")]
        public string WorkOrderTools { get; set; }

        [DisplayName("Disable Auto In Progress")]
        public bool DisableAutoInProgress { get; set; }

        [DisplayName("Evenly Space Printable Columns")]
        public bool EvenlySpacePrintableColumns { get; set; }

        [DisplayName("Hide Estimate Tax Total")]
        public bool HideEstimateTaxTotal { get; set; }

        [DisplayName("Hide Estimate SubTotal")]
        public bool HideEstimateSubTotal { get; set; }

        [DisplayName("Disable Ability To Duplicate Work Orders")]
        public bool DisableAbilityToDuplicateWorkOrders { get; set; }

        [DisplayName("Disable Calendar Refresh")]
        public bool DisableCalendarRefresh { get; set; }

        [DisplayName("Enforce Unique Logins")]
        public bool EnforceUniqueLogins { get; set; }

        [DisplayName("Contact Custom Types")]
        public string ContactCustomTypes { get; set; }

        [StringLength(8000)]
        [DisplayName("Quickbooks Token")]
        public string QbToken { get; set; }

        [StringLength(8000)]
        [DisplayName("Quickbooks Refresh Token")]
        public string QbRefreshToken { get; set; }

        [DisplayName("Quickbooks Last Refresh Date")]
        public DateTime QbLastTokenRefreshDate { get; set; }

        [StringLength(100)]
        [DisplayName("Quickbooks Realm ID")]
        public string QbRealmId { get; set; }

        [StringLength(8000)]
        [DisplayName("Quickbooks Error")]
        public string QbError { get; set; }

        [StringLength(50)]
        [DisplayName("Default Quickbooks Income Account")]
        public string DefaultQuickbooksIncomeAccountId { get; set; }

        [StringLength(50)]
        [DisplayName("Default Quickbooks Expense Account")]
        public string DefaultQuickbooksExpenseAccountId { get; set; }

        [StringLength(50)]
        [DisplayName("Quickbooks Asset Account")]
        public string QuickbooksAssetAccountId { get; set; }

        [StringLength(50)]
        [DisplayName("Default Quickbooks Tax Code")]
        public string DefaultQuickbooksTaxCodeId { get; set; }

        [StringLength(50)]
        [DisplayName("Default Quickbooks Tax Rate")]
        public string DefaultQuickbooksTaxRateId { get; set; }

        [DisplayName("Quickbooks Sync After Date")]
        public string QuickbooksSyncAfterDate { get; set; }

        [DisplayName("Quickbooks Desktop Sync After Date")]
        public string QuickbooksDesktopSyncAfterDate { get; set; }

        [DisplayName("Allow Invoicing Before Work Orders Are Marked As Complete")]
        public bool AllowInvoiceBeforeWorkOrderComplete { get; set; }

        [DisplayName("Allow Auto Close a Project Are All Had Been Paid")]
        public bool EnableAutoClose { get; set; }

        [DisplayName("Enable Quickbooks Customers")]
        public bool EnableQuickbooksCustomers { get; set; }

        [DisplayName("Enable Quickbooks Vendors")]
        public bool EnableQuickbooksVendors { get; set; }

        [DisplayName("Enable Quickbooks Products")]
        public bool EnableQuickbooksProducts { get; set; }

        [DisplayName("Enable Quickbooks Invoices")]
        public bool EnableQuickbooksInvoices { get; set; }

        [DisplayName("Enable Quickbooks Payments")]
        public bool EnableQuickbooksPayments { get; set; }

        [DisplayName("Enable Quickbooks Two Way Sync")]
        public bool EnableQuickbooksTwoWaySync { get; set; }

        [DisplayName("Enable Quickbooks Desktop Customers")]
        public bool EnableQuickbooksDesktopCustomers { get; set; }

        [DisplayName("Enable Quickbooks Desktop Vendors")]
        public bool EnableQuickbooksDesktopVendors { get; set; }

        [DisplayName("Enable Quickbooks Desktop Products")]
        public bool EnableQuickbooksDesktopProducts { get; set; }

        [DisplayName("Enable Quickbooks Desktop Invoices")]
        public bool EnableQuickbooksDesktopInvoices { get; set; }

       

        [DisplayName("Enable Quickbooks Desktop Payments")]
        public bool EnableQuickbooksDesktopPayments { get; set; }

        [DisplayName("Enable Quickbooks Desktop Two Way Sync")]
        public bool EnableQuickbooksDesktopTwoWaySync { get; set; }

        [DisplayName("Allow Auto Archive a Project Are Created Over 18 Months")]
        public bool EnableAutoArchive { get; set; }

        [DisplayName("Allow Difficulty Level")]
        public bool AllowDifficultyLevel { get; set; }

        [DisplayName("Do Not Allow Line Item Name Change")]
        public bool DoNotAllowLineItemNameChange { get; set; }

        [DisplayName("Enable Sliding Scale Commissions")]
        public bool EnableSlidingScaleCommissions { get; set; }

        [DisplayName("Show Terms On Invoice")]
        public bool ShowTermsOnInvoice { get; set; }

        [DisplayName("Display Salesperson Phone Number And Email Address")]
        public bool DisplaySalesPhoneAndEmail { get; set; }

        [DisplayName("Show Terms On Estimate")]
        public bool ShowTermsOnEstimate { get; set; }

        [DisplayName("Notify Salesperson when creating a work order by default")]
        public bool NotifySalespersonByDefault { get; set; }

        [DisplayName("Notify Accounting when creating a work order by default")]
        public bool NotifyAccountingByDefault { get; set; }

        [DisplayName("Include Customer Acceptance On Work Order")]
        public bool IncludeCustomerAcceptanceOnWorkOrder { get; set; }

        [DisplayName("Number Of Empty Lines")]
        public int NumberOfEmptyLines { get; set; }

        [DisplayName("Hide Load Ticket From Work Order")]
        public bool HideLoadTicketFromWO { get; set; }

        [DisplayName("Hide Installers Names On Work Order Header")]
        public bool HideInstallersNamesOnWO { get; set; }

        [DisplayName("Show Tax In Phase And Sub Total")]
        public bool ShowTaxInPhaseAndSubTotal { get; set; }

        [DisplayName("Allow Invoice From Estimate")]
        public bool AllowEstimateInvoice { get; set; }

        [DisplayName("Use New Invoice Report Layout")]
        public bool UseNewInvoiceReportLayout { get; set; }

        [DisplayName("Lock The Account")]
        public bool IsLocked { get; set; }

        [DisplayName("Allow To Send Email")]
        public int AllowToSendEmail { get; set; }

    }
}
