using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calm_Healing.DAL.Models
{
    [Table("users", Schema = "public")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Uuid { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long? CountryCodeId { get; set; }
        public string Phone { get; set; }
        public string MobileCarrier { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public long? UserTypeId { get; set; }
        public string RoleType { get; set; }

        public bool Active { get; set; } = true;

        public DateTime? LastLogin { get; set; }
        public DateTime? PhoneVerifiedAt { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string OtpVerification { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public long? LanguageId { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }

        public string RememberToken { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; } // For soft delete
    }
}
