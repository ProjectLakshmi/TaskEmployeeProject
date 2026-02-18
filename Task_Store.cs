using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using System.Text;

namespace Assignment_1
{
    internal class Task_Store

    {
     public static  BindingList<Task_Class> tasks = new BindingList<Task_Class> { new Task_Class("employee1",1,"Fix button",true), new Task_Class("employee1",2,"Shipping",false), new Task_Class("employee2",1,"Resizing page",true)};
        
    }
}
