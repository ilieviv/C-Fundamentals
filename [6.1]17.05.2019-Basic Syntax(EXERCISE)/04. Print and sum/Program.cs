﻿using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.WriteLine(Environment.NewLine + "Sum: {0}", sum);
        }
    }
}
