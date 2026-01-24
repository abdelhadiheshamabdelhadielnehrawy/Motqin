using System.ComponentModel.DataAnnotations;

namespace Motqin.Dtos.Question
{
    public class FillInTheBlankQuestionDto
    {
        [Key]
        public int QuestionID { get; set; }

        [Required]
        public int LessonID { get; set; }

        [Required]
        public string QuestionCategory { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [StringLength(20)]
        public string DifficultyLevel { get; set; }

        [Required]
        public string CorrectText { get; set; }

        public bool CaseSensitive { get; set; }
    }
}
