using Motqin.Models;
using System.ComponentModel.DataAnnotations;

public abstract class Question
{
    [Key]
    public int QuestionID { get; set; }

    [Required]
    public int LessonID { get; set; }

    public int DisplayOrder { get; set; } = 0;   // for structured lesson ordering

    public int Priority { get; set; } = 2;       // 1 = High, 2 = Medium, 3 = Low


    [Required]
    public string QuestionCategory { get; set; }  // Basic / Advanced

    [Required]
    public string QuestionText { get; set; }

    [StringLength(20)]
    public string DifficultyLevel { get; set; }

    public virtual Lesson Lesson { get; set; }
    public virtual ICollection<QuestionDetails> QuestionDetails { get; set; }
}
