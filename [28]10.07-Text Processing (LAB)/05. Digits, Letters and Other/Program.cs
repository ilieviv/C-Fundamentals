using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numbers = new StringBuilder();
            var allChars = new StringBuilder();
            var symbols = new StringBuilder();

            foreach (var chars in input)
            {
                if (chars >= 48 && chars <= 57)
                {
                    numbers.Append(chars);
                }
                else if (chars >= 65 && chars <= 90 || chars >= 97 && chars <= 122)
                {
                    allChars.Append(chars);
                }
                else
                {
                    symbols.Append(chars);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(allChars);
            Console.WriteLine(symbols);
        }
    }
}
