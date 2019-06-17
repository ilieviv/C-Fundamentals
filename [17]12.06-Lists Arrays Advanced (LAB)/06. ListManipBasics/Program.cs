using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ListManipBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();




            while (true)
            {
                List<string> input = Console.ReadLine()
                             .Split(" ")
                             .ToList();

                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                }
                if (input[0] == "Remove")
                {
                    numbers.Remove(int.Parse(input[1]));
                }
                if (input[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(input[1]));
                }
                if (input[0] == "Insert")
                {
                    int index = int.Parse(input[1]);
                    int toRemove = int.Parse(input[2]);
                    numbers.Insert(toRemove, index);
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
