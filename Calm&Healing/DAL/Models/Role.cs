using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calm_Healing.DAL.Models
{
    [Table("roles", Schema = "public")]
    public class Role
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Type { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public bool? IsEditable { get; set; } = true;

        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
