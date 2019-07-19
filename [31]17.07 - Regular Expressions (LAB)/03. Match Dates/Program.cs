using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<day>\d{2})(?<delimiter>.|-|\/)(?<month>[A-Za-z]+)\2(?<year>\d{4})\b");

            string input = Console.ReadLine();

            MatchCollection matchedDates = regex.Matches(input);

            foreach (Match match in matchedDates)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
