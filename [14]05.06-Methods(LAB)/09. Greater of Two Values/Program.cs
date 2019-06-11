using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            if (type == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                char result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
            else
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                var result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            int result = Math.Max(firstValue, secondValue);
            return result;
        }

        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                char result = firstValue;
                return result;
            }
            else
            {
                char result = secondValue;
                return result;
            }
        }

        static string GetMax(string firstValue, string secondValue)
        {
            int compare = String.Compare(firstValue, secondValue);
            if (compare > 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
