using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());

            double result = GetFactorial(number1) / GetFactorial(number2);
            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorial(double number)
        {
            double sum = 1;
            for (int i = 2; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
