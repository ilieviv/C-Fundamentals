using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            while (input != "END")
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                Console.WriteLine(PalindromeCheck(input));
            }
        }

        static string PalindromeCheck(string number)
        {
            string reversed = string.Empty;
            string output = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }

            if (number == reversed)
            {
                output = "true"; 
            }
            else
            {
                output = "false";
            }

            return output;
        }
    }
}
