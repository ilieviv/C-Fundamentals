using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();

            if (operation == "int")
            {
                int input = int.Parse(Console.ReadLine());
                int result = Integer(input);
                Console.WriteLine(result);
            }
            else if (operation == "real")
            {
                double input = double.Parse(Console.ReadLine());
                double result = Double(input);
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                string input = Console.ReadLine();
                string result = StringResult(input);
                Console.WriteLine(result);
            }
        }

        static int Integer(int number)
        {
            int result = number * 2;
            return result;
        }

        static double Double(double number)
        {
            double result = number * 1.5;
            return result;
        }

        static string StringResult(string text)
        {
            string result = "$";
            result += text + "$";
            return result;
        }
    }
}
