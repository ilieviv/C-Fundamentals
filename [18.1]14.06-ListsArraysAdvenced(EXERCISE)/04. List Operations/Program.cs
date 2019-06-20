using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string instruction;

            while ((instruction = Console.ReadLine()) != "End")
            {

                string[] command = instruction.Split(" ");

                switch (command[0])
                {
                    case "Add": numbers.Add(int.Parse(command[1])); break;
                    case "Insert":
                        if (int.Parse(command[2]) < numbers.Count && int.Parse(command[2]) >= 0)
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) >= numbers.Count || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            ShiftLeft(numbers, int.Parse(command[2]));
                        }
                        else
                        {
                            ShiftRight(numbers, int.Parse(command[2]));
                        }
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
