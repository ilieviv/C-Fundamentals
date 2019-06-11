using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringsNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[stringsNumber];

            string vowels = "aAeEiIoOuU";
            char[] vowelsArr = vowels.ToCharArray();
            string consonants = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXzZyY";
            char[] consonantsArr = consonants.ToCharArray();

            for (int i = 0; i < stringsNumber; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();

                int sum = 0;

                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];

                    if (vowelsArr.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }
                numbers[i] = sum;
            }

            Array.Sort(numbers);

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }


        }
    }
}
