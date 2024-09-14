using inProgress.Models;

public class TaskAssignment
{
    public int TaskId { get; set; }
    public TaskItem TaskItem { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
