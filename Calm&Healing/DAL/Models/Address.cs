using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calm_Healing.DAL.Models
{
    [Table("addresses", Schema = "public")]
    public class Address
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public Guid Uuid { get; set; }

        [Required]
        [MaxLength(255)]
        public string Line1 { get; set; }

        [MaxLength(255)]
        public string Line2 { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        public long? StateId { get; set; }
        public long? CountryId { get; set; }

        [MaxLength(50)]
        public string PostalCode { get; set; }

        public bool IsPrimary { get; set; } = false;
        public bool Active { get; set; } = true;

        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // 🔁 Navigation Properties (define only if relationships exist in the model)
        [ForeignKey("CreatedBy")]
        public virtual User Creator { get; set; }

        [ForeignKey("ModifiedBy")]
        public virtual User Modifier { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}
