using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] splittedCommand = command
                    .Split(" ");

                if (splittedCommand[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(splittedCommand[1]));
                }
                else if (splittedCommand[0] == "Insert")
                {
                    int index = int.Parse(splittedCommand[1]);
                    numbers.Insert(int.Parse(splittedCommand[2]), index);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
