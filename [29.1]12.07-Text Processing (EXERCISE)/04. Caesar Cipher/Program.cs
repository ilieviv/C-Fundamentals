using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var newChar = Convert.ToChar(input[i] + 3);

                str.Append(newChar);
            }

            Console.WriteLine(str);
        }
    }
}
