using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(input, n);
            Console.WriteLine(result);
        }

        static string RepeatString(string input, int n)
        {
            string newString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                newString += input;
            }
            return newString;
        }
    }
}
