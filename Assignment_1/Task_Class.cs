using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Task_Class
    {
        public string employee_id { get; set; }
        public int task_id { get; set; }
        public string task_discription { get; set; }
        public bool task_status { get; set; }

        public  Task_Class(string emp_id,int t_id,string td,bool ts)

        {
            employee_id = emp_id;
            task_discription = td;
            task_id = t_id;
            task_status = ts;
        }
    }
}
