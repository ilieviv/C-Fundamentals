using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main()
        {
            SignOfNumber(int.Parse(Console.ReadLine()));
        }

        static void SignOfNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number { number} is zero.");
            }
        }
    }
}
