using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models;

public class DiaryEntry
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please enter the title of the diary")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Please enter the content of the diary")]
    public string Content { get; set; }
    [Required(ErrorMessage = "Please enter the Date of the diary")]
    public DateTime Created { get; set; } = DateTime.Now;
}