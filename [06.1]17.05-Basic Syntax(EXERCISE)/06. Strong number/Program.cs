using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int sumInternal = 1;

            int numberLength = number.ToString().Length;
            int initialNumber = number;

            for (int i = 1; i <= numberLength; i++)
            {
                int d = number % 10;
                for (int k = 1; k <= d; k++)
                {
                    sumInternal *= k;
                }
                sum += sumInternal;
                sumInternal = 1;

                number = number / 10;
            }

            if (initialNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
