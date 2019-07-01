using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Students> studentsList = new List<Students>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string firstName = input[0];
                string lastName = input[1];
                float grade = float.Parse(input[2]);

                Students student = new Students(firstName, lastName, grade);

                studentsList.Add(student);
            }

            var orderedList = studentsList.OrderByDescending(x => x.Grade);

            foreach (var student in orderedList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
