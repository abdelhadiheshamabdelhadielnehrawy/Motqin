using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Motqin.Models
{
    public class Competition
    {
        [Key]
        public int CompetitionID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation Property
        public virtual ICollection<CompetitionEntry> CompetitionEntries { get; set; } = new List<CompetitionEntry>();
    }
}
