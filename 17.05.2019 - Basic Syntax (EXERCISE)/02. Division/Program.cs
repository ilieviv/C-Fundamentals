using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool notDivisible = true;
            int biggerDivision = 0;

            if (number % 2 == 0)
            {
                biggerDivision = 2;
                notDivisible = false;
            }
            if (number % 3 == 0)
            {
                biggerDivision = 3;
                notDivisible = false;
            }
            if (number % 6 == 0)
            {
                biggerDivision = 6;
                notDivisible = false;
            }
            if (number % 7 == 0)
            {
                biggerDivision = 7;
                notDivisible = false;
            }
            if (number % 10 == 0)
            {
                biggerDivision = 10;
                notDivisible = false;
            }

            if (notDivisible)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("The number is divisible by {0}", biggerDivision);
            }
        }
    }
}
