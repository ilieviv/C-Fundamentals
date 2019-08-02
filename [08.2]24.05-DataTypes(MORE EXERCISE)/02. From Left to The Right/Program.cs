using System;
using System.Collections.Generic;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            long lines = long.Parse(Console.ReadLine());

            for (long i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                long sum1 = 0;
                long sum2 = 0;
                string[] numbers = input.Split(' ');
                List<string> digits = new List<string>();

                foreach (var number in numbers)
                {
                    digits.Add(number);
                }

                long num1 = long.Parse(digits[0]);
                long num2 = long.Parse(digits[1]);

                if (num1 > num2)
                {
                    num1 = Math.Abs(num1);
                    string num1Length = num1.ToString();

                    for (long k = 0; k < num1Length.Length; k++)
                    {
                        long lastDigit = num1 % 10;
                        sum1 += lastDigit;
                        num1 /= 10;
                    }
                    Console.WriteLine(sum1);
                }
                else
                {
                    num2 = Math.Abs(num2);
                    string num2Length = num2.ToString();

                    for (long l = 0; l < num2Length.Length; l++)
                    {
                        long lastDigit = num2 % 10;
                        sum2 += lastDigit;
                        num2 /= 10;
                    }
                    Console.WriteLine(sum2);
                }
                numbers = null;

            }
        }
    }
}
