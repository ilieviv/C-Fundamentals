using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumResult = GetSum(firstNumber, secondNumber);


            int result = Subtract(sumResult, thirdNumber);
            Console.WriteLine(result);
        }

        static int GetSum(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        static int Subtract(int sum, int thirdNum)
        {
            int result = sum - thirdNum;
            return result;
        }
    }
}
