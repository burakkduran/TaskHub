namespace TaskHub.Models
{
    public class Assignments : BaseEntity
    {
        public int AssignmentId { get; set; } // Primary Key
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public int CreatedBy { get; set; } // Foreign Key to Users table
    }
}
