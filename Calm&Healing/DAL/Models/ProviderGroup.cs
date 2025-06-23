using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calm_Healing.DAL.Models
{
    [Table("providergroups", Schema = "public")]
    public class ProviderGroup
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public Guid Uuid { get; set; }

        [MaxLength(255)]
        public string GroupId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(255)]
        public long Npi { get; set; }

        public bool Active { get; set; } = true;

        [Required]
        [MaxLength(255)]
        public string Schema { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Website { get; set; }

        [MaxLength(100)]
        public string Fax { get; set; }

        public long? PhysicalAddressId { get; set; }

        public long? BillingAddressId { get; set; }

        public long? CreatedBy { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        // 🔁 Navigation properties
        [ForeignKey("PhysicalAddressId")]
        public virtual Address PhysicalAddress { get; set; }

        [ForeignKey("BillingAddressId")]
        public virtual Address BillingAddress { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual User Creator { get; set; }

        [ForeignKey("ModifiedBy")]
        public virtual User Modifier { get; set; }
    }
}
