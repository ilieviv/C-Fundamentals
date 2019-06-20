using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();

            for (int i = 0; i < array.Count; i++)
            {
                List<string> output = array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < output.Count; j++)
                {
                    Console.Write($"{output[j]} ");
                }

            }

        }
    }
}
