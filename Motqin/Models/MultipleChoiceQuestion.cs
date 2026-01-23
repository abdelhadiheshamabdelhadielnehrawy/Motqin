using System.ComponentModel.DataAnnotations;

public class MultipleChoiceQuestion : Question
{
    [Required]
    public string AnswerOptions { get; set; } // JSON

    [Required]
    public string CorrectAnswer { get; set; }
}
