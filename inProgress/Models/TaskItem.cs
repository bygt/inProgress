using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace inProgress.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int AssigneeId { get; set; }
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public ICollection<TaskAssignment> TaskAssignments { get; set; } = new List<TaskAssignment>();


    }
}
