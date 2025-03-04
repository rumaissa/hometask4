using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Employee_Management_System
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;
        public Employee_Management_System(int Id, string name, string department, double salary)
        {
            EmployeeID = Id;
            Name = name;
            Department = department;
            Salary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Department: {Department}");
            Console.WriteLine($"Employee Salary: {Salary}");
        }
        public void IncreaseSalary(double amount)
        {
            Salary += amount;
            Console.WriteLine($"Increased Salary: {Salary}");
        }
    }
}