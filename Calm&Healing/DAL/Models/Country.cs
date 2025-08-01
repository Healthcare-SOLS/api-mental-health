﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calm_Healing.DAL.Models
{
    [Table("countries", Schema = "public")]
    public class Country
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ShortCode { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string CountryCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public virtual ICollection<State> States { get; set; } = new List<State>();
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
