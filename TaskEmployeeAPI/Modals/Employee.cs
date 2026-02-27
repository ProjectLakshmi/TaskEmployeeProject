namespace TaskEmployeeAPI.Modals
{
    public partial class Employee
    {
        public string EmployeeId { get; set; } = null!;

        public string? EmployeeName { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }
    }
}
