using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    result += " ";
                    continue;
                }

                int mainDigit = input % 10;
                int digitLength = input.ToString().Length;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letter = offset + digitLength - 1;
                result += (char)(letter + 97);
            }
            Console.WriteLine(result);
        }
    }
}
