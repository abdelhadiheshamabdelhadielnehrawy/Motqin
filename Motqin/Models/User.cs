using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Motqin.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        [StringLength(50)]
        public string GradeLevel { get; set; }

        // Navigation Properties
        public virtual ICollection<StudySession> StudySessions { get; set; } = new List<StudySession>();
        public virtual ICollection<StudyPlan> StudyPlans { get; set; } = new List<StudyPlan>();
        public virtual ICollection<DistractionControl> DistractionControls { get; set; } = new List<DistractionControl>();
        public virtual ICollection<CompetitionEntry> CompetitionEntries { get; set; } = new List<CompetitionEntry>();
    }
}
