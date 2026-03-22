namespace TaskManager.Models;

public class CreateTaskDto
{
    public string TaskTitle { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
}