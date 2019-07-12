using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArr = input.Split(" : ").ToArray();

                string courseName = inputArr[0];
                string userName = inputArr[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(userName);

                input = Console.ReadLine();
            }

            foreach (var kvp in courses.OrderByDescending(kvp => kvp.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var student in kvp.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
