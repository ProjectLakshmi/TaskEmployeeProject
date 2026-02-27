using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Modals
{
    public class Task
    {
        public string EmployeeId { get; set; } = null!;

        public string TaskDiscrption { get; set; } = null!;

        public bool TaskStatus { get; set; }

        public int TaskId { get; set; }
    }
}
