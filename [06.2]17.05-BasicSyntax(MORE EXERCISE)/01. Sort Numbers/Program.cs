using System;
using System.Collections.Generic;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers.Add(n);
            }

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
