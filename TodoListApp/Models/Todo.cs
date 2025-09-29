using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Models;

public class Todo
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
    [Display(Name = "Task Title")]
    public string? Title { get; set; }

    [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Display(Name = "Due Date")]
    [DataType(DataType.Date)]
    public DateTime? DueDate { get; set; }

    [Display(Name = "Priority")]
    public Priority Priority { get; set; } = Priority.Medium;

    [Display(Name = "Status")]
    public TodoStatus Status { get; set; } = TodoStatus.Pending;

    [Display(Name = "Is Completed")]
    public bool IsCompleted { get; set; } = false;

    [Display(Name = "Created Date")]
    [DataType(DataType.DateTime)]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [Display(Name = "Completed Date")]
    [DataType(DataType.DateTime)]
    public DateTime? CompletedDate { get; set; }

    [StringLength(100, ErrorMessage = "Category cannot exceed 100 characters")]
    [Display(Name = "Category")]
    public string? Category { get; set; }
}

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3,
    Urgent = 4
}

public enum TodoStatus
{
    Pending,
    InProgress,
    Completed,
    Cancelled
}