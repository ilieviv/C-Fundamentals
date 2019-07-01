using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Company_Roster
{
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }

    }
}
