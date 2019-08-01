using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string emojiCodeAsStr = Console.ReadLine();

            int[] asciiCodes = emojiCodeAsStr
                .Split(":")
                .Select(int.Parse)
                .ToArray();

            string emojiCode = ":";

            for (int i = 0; i < asciiCodes.Length; i++)
            {
                emojiCode += (char)asciiCodes[i];
            }
            emojiCode += ":";


            string pattern = @"(?<=[\s])(?<emoji>:(?<emojiValue>[a-z]{4,}):)(\s|,|\.|!|\?)";

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> emojis = matches
                .Select(x => x.Groups["emoji"].Value)
                .ToList();

            int totalAsciiSum = 0;

            foreach (var emoji in emojis)
            {

                foreach (var symb in emoji)
                {
                    if (symb != ':')
                    {
                        totalAsciiSum += symb;
                    }
                }
            }

            if (emojis.Contains(emojiCode))
            {
                totalAsciiSum *= 2;
            }

            if (emojis.Any())
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", emojis)}");
            }

            Console.WriteLine($"Total Emoji Power: {totalAsciiSum}");
        }
    }
}
