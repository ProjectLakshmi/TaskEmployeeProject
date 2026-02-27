namespace TaskEmployeeAPI.Modals
{
    public partial class Task
    {
        public string EmployeeId { get; set; } = null!;

        public string TaskDiscrption { get; set; } = null!;

        public bool TaskStatus { get; set; }

        public int TaskId { get; set; }
    }
}
