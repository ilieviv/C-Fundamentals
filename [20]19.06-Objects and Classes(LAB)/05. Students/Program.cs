using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];

                Student stud = new Student();
                stud.FirstName = firstName;
                stud.LastName = lastName;
                stud.Age = age;
                stud.City = city;

                allStudents.Add(stud);

            }

            string cityInput = Console.ReadLine();

            for (int i = 0; i < allStudents.Count; i++)
            {
                if (allStudents[i].City == cityInput)
                {
                    Console.WriteLine($"{allStudents[i].FirstName} {allStudents[i].LastName} is {allStudents[i].Age} years old.");
                }
            }

        }
    }
}
