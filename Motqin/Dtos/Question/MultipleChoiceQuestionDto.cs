using System.ComponentModel.DataAnnotations;

namespace Motqin.Dtos.Question
{
    public class MultipleChoiceQuestionDto
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
        public string AnswerOptions { get; set; } // JSON

        [Required]
        public string CorrectAnswer { get; set; }
    }
}
