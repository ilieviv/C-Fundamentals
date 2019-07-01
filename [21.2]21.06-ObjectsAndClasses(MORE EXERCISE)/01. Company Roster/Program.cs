using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployes = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < numberOfEmployes; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (!departments.Any(d => d.DepartmentName == input[2]))
                {
                    departments.Add(new Department(input[2]));
                }

                departments.Find(d => d.DepartmentName == input[2]).AddNewEmployee(input[0], decimal.Parse(input[1]));

            }

            Department bestDepartment = departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}
