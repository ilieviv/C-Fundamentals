using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = GetVowels(input);
            Console.WriteLine(result);
        }

        static int GetVowels(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a' || input[i]=='e' || input[i] == 'o' || input[i] == 'u' || input[i] == 'i')
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
