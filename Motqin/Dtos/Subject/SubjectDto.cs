using System.ComponentModel.DataAnnotations;

namespace Motqin.Dtos.Subject
{
    public class SubjectDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(50)]
        public string EducationalStage { get; set; }

        [StringLength(50)]
        public string GradeLevel { get; set; }

    }
}
