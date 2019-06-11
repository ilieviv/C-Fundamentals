using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetSmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        static int GetSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int minNumber = Math.Min(firstNumber, secondNumber);
            int finalMinNuber = Math.Min(minNumber, thirdNumber);

            return finalMinNuber;
        }
    }
}
