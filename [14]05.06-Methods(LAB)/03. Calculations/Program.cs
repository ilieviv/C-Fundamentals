using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            //if (operation == "add")
            //{
            //    Console.WriteLine(Add(firstNumber, secondNumber));
            //}
            //else if (operation == "subtract")
            //{
            //    Console.WriteLine(Subtract(firstNumber, secondNumber));
            //}
            //else if (operation == "multiply")
            //{
            //    Console.WriteLine(Multiply(firstNumber, secondNumber));
            //}
            //else if (operation == "divide")
            //{
            //    Console.WriteLine(Divide(firstNumber, secondNumber));
            //}

            switch (operation)
            {
                case "add": Console.WriteLine(Add(firstNumber, secondNumber)); break;
                case "multiply": Console.WriteLine(Multiply(firstNumber, secondNumber)); break;
                case "divide": Console.WriteLine(Divide(firstNumber, secondNumber)); break;
                case "subtract": Console.WriteLine(Subtract(firstNumber, secondNumber)); break;
                default:
                    break;
            }

        }

        static int Subtract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }

        static int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
