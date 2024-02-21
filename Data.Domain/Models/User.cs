using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Domain.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string? CompanyId { get; set; }

        public DateTime? DateCreated { get; set; }

        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string? LastName { get; set; }

        [StringLength(100)]
        public string? DisplayName { get; set; }

        [Required]
        [StringLength(100)]
        public string? Username { get; set; }

        [StringLength(100)]
        public string? Password { get; set; }

        public bool? Active { get; set; }

        public bool? SuperAdmin { get; set; }

        [StringLength(250)]
        public string? Image { get; set; }

        public bool? LoggedIn { get; set; }

        public decimal? SalesGoal { get; set; }

        [StringLength(100)]
        public string? Phone { get; set; }

        public bool? EnableTaskNotifications { get; set; }

        public int? SquareFootageCapacity { get; set; }

        public int? MoneyCapacity { get; set; }

        public bool? RestrictedAccess { get; set; }

        public bool? DailyJobsNotification { get; set; }

        public string? Signature { get; set; }

        public string? Initials { get; set; }

        public string? SignatureStyle { get; set; }

        public decimal? SalesCommissionRate { get; set; }

        public decimal? EstimatorCommissionRate { get; set; }

        public decimal? ProjectManagementCommissionRate { get; set; }

        public bool? Driver { get; set; }

        public string? AccessCode { get; set; }

        public decimal? MonthlyBreakEven { get; set; }

        public bool? PrivacyMode { get; set; }

        public decimal? HourlyRate { get; set; }

        public bool? ShowWorkAreaFirst { get; set; }

        public bool? DisableModalClickingOff { get; set; }

        public bool? ExcludeFromReports { get; set; }

        public string? SessionToken { get; set; }

        public DateTime? SessionTokenDate { get; set; }

        [StringLength(500)]
        public string? EmailSignature { get; set; }

        [StringLength(50)]
        public string? TaskEventBackgroundColor { get; set; }

        [StringLength(50)]
        public string? TaskEventTextColor { get; set; }

        public bool? AllowAddRemoveCreditHold { get; set; }

        public bool? AllowUserstoUpdatePricing { get; set; }
    }

    public class UserLoginView
    {
        [Required]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public string? RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }

    public class UserAccessCodeView
    {
        [Required]
        [DisplayName("User ID")]
        public string UserId { get; set; }

        [DisplayName("Step")]
        public string Step { get; set; }

        [DisplayName("Method")]
        public string Method { get; set; }

        [DisplayName("Access Code")]
        public string AccessCode { get; set; }
    }

    public class UserRegisterView
    {
        [Required]
        [DisplayName("Industry")]
        public string Industry { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Address1")]
        public string Address1 { get; set; }


        [StringLength(150)]
        [DisplayName("Address2")]
        public string Address2 { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("City")]
        public string City { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("State")]
        public string State { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Zip")]
        public string Zip { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Time Zone")]
        public string TimeZone { get; set; }


        [Required]
        [StringLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Password Again")]
        public string PasswordAgain { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [DisplayName("Credit Card Number")]
        public string CcNumber { get; set; }

        [DisplayName("Name on Credit Card")]
        public string CcName { get; set; }


        [DisplayName("Expire Month")]
        public string CcExpireMonth { get; set; }


        [DisplayName("Expire Year")]
        public string CcExpireYear { get; set; }


        [DisplayName("CVV")]
        public string CcCsc { get; set; }

        [StringLength(50)]
        [DisplayName("Billing First Name")]
        public string BillingFirstName { get; set; }

        [StringLength(50)]
        [DisplayName("Billing Last Name")]
        public string BillingLastName { get; set; }

        [StringLength(150)]
        [DisplayName("Billing Street")]
        public string BillingAddress1 { get; set; }

        [StringLength(150)]
        [DisplayName("Billing Address 2")]
        public string BillingAddress2 { get; set; }

        [StringLength(100)]
        [DisplayName("Billing City")]
        public string BillingCity { get; set; }

        [StringLength(50)]
        [DisplayName("Billing State")]
        public string BillingState { get; set; }

        [StringLength(15)]
        [DisplayName("Billing Zip")]
        public string BillingZip { get; set; }

        [StringLength(40)]
        [DisplayName("Billing Phone")]
        public string BillingPhone { get; set; }


        [DisplayName("Same As Primary Address")]
        public bool SameAsPrimaryAddress { get; set; }
    }

    public class UserChangePasswordView
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [DisplayName("New Password")]
        public string NewPassword { get; set; }

        [Required]
        [DisplayName("New Password Again")]
        public string NewPasswordConfirm { get; set; }
    }

    public class UserPerformance
    {
        /* public UserPerformance()
         {
             SalesRepPerformance = new List<SalesRepPerformance>();
         }

         public List<SalesRepPerformance> SalesRepPerformance { get; set; }
         public Graph SalesRepPerformanceLineGraph { get; set; }
         public Graph SalesRepPerformanceBarGraph { get; set; }*/
    }

}
 