using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double result = GetResult(firstNumber, operation, secondNumber);
            Console.WriteLine($"{result:f0}");
        }

        static double GetResult(double fistNumber, char operation, double secondNumber)
        {
            if (operation == '+')
            {
                return fistNumber + secondNumber;
            }
            else if (operation == '-')
            {
                return fistNumber - secondNumber;
            }
            else if (operation == '/')
            {
                return fistNumber / secondNumber;
            }
            else
            {
                return fistNumber * secondNumber;
            }
        }
    }
}
