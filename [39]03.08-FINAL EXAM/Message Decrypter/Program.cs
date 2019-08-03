using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex pattern = new Regex(@"^([$%])(?<tag>[A-Z][a-z]{2,})\1:\s(\[(?<digit1>[\d]+)\]\|)(\[(?<digit2>[\d]+)\]\|)(\[(?<digit3>[\d]+)\]\|)$");

                MatchCollection match = pattern.Matches(input);

                if (pattern.IsMatch(input))
                {
                    string tag = pattern.Match(input).Groups["tag"].ToString();
                    int digit1 = int.Parse(pattern.Match(input).Groups["digit1"].ToString());
                    int digit2 = int.Parse(pattern.Match(input).Groups["digit2"].ToString());
                    int digit3 = int.Parse(pattern.Match(input).Groups["digit3"].ToString());

                    char c1 = (char)digit1;
                    char c2 = (char)digit2;
                    char c3 = (char)digit3;

                    StringBuilder str = new StringBuilder();

                    str.Append(c1);
                    str.Append(c2);
                    str.Append(c3);
                    Console.WriteLine($"{tag}: {str}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }

        }
    }
}
