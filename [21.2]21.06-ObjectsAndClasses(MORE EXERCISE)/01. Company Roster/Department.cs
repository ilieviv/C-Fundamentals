using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Company_Roster
{
    class Department
    {
        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
        }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string employeName, decimal employeSalary)
        {
            this.TotalSalaries += employeSalary;
            this.Employees.Add(new Employee(employeName, employeSalary));
        }
    }
}
