using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (TopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool TopNumber(int number)
        {
            int sum = 0;
            bool isOdd = false;
            do
            {
                sum += number % 10;

                if ((number % 10) % 2 == 1)
                {
                    isOdd = true;
                }
                number /= 10;
            } while (number != 0);

            if (isOdd && (sum % 8 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
