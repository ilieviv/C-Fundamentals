using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = GetMiddleCharacter(input);
            Console.WriteLine(result);
        }

        static string GetMiddleCharacter(string input)
        {
            string output = string.Empty;

            if (input.Length % 2 == 1)
            {
                int middle = input.Length / 2;
                output += input[middle];
            }
            else
            {
                int middle = input.Length / 2;
                output += input[middle - 1].ToString() + input[middle].ToString();
            }

            return output;
        }
    }
}
