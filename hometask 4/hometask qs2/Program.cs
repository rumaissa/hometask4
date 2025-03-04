using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee_Management_System employee1 = new Employee_Management_System(1211, "Rumaissa", "Software Engineer", 4000000);
            employee1.DisplayEmployeeDetails();
            employee1.IncreaseSalary(3000000);
        }
    }
}