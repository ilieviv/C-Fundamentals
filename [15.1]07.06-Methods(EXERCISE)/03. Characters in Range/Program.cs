using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());

            char first = firstCharacter;
            char second = secondCharacter;

            if (firstCharacter > secondCharacter)
            {
                first = secondCharacter;
                second = firstCharacter;
            }

            string result = GetCharacters(first, second);
            Console.WriteLine(result);
        }

        static string GetCharacters(char firstCharacter, char secondCharacter)
        {
            string output = string.Empty;

            for (int i = firstCharacter + 1; i < secondCharacter; i++)
            {
                output += (char)i + " ";
            }

            return output;
        }
    }
}
