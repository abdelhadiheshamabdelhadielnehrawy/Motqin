using System.ComponentModel.DataAnnotations;

public class FillInTheBlankQuestion : Question
{
    [Required]
    public string CorrectText { get; set; }

    public bool CaseSensitive { get; set; }
}
