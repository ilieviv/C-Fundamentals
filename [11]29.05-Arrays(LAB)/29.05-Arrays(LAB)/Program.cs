using System;
using System.Linq;

namespace _29._05_Arrays_LAB_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach (string text in input.Reverse())
            {
                Console.WriteLine(text); 
            }

            Console.WriteLine();
        }
    }
}
