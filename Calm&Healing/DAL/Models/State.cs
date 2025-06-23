using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace Calm_Healing.DAL.Models
{
    [Table("states", Schema = "public")]
    public class State
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [ForeignKey("Country")]
        public long CountryId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        // Navigation to Country
        public virtual Country Country { get; set; }

        // Reverse navigation to Addresses
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    }

}
