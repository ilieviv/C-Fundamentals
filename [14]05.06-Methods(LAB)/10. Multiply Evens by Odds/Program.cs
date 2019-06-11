using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(input));
        }

        static int GetMultipleOfEvenAndOdds(int input)
        {
            int result = GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);

            return result;
        }


        static int GetSumOfEvenDigits(int input)
        {
            int sum = 0;

            while (input != 0)
            {
                int digit = input % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                input /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int input)
        {
            int sum = 0;

            while (input != 0)
            {
                int digit = input % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                input /= 10;
            }

            return sum;
        }
    }
}
