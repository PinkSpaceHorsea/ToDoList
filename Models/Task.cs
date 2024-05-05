using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models;

public class Task
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [StringLength (60, MinimumLength = 3)]
    public string? Description { get; set; } = null;

    [Display(Name = "Created Date")]
    [DataType(DataType.Date)]
    public DateTime? CreatedDate { get; set; } = DateTime.Today;

    [Display(Name = "Due Date")]
    [DataType(DataType.Date)]
    public DateTime? DueDate { get; set; }

    [Range(1, 3)]
    public int Priority { get; set; }

    [StringLength(60, MinimumLength =3)]
    [Required]
    public string? Category { get; set; }
}
