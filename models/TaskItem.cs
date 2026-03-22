
namespace TaskManager.Models;
public class TaskItem
{
    public Guid Id {get; set; } = Guid.NewGuid();
    public string TaskTitle {get; set; } = string.Empty;
    public string? Description {get; set; }
    public ToDoStatus Status {get; set; } = ToDoStatus.Todo;
    public DateTime CreatedAt {get; set; } = DateTime.UtcNow;
    public DateTime? DueDate {get; set; }
}