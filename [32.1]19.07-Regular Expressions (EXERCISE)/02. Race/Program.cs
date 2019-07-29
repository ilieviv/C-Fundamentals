using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(", ");

            Regex lettersReg = new Regex(@"[A-Za-z]");
            Regex digitsReg = new Regex(@"[0-9]");

            Dictionary<string, int> runners = new Dictionary<string, int>();

            foreach (var name in participants)
            {
                runners.Add(name, 0);
            }

            var input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = string.Empty;

                foreach (var letter in lettersReg.Matches(input))
                {
                    name += letter;
                }

                if (runners.ContainsKey(name))
                {
                    int distance = 0;

                    foreach (var digit in digitsReg.Matches(input))
                    {
                        distance += int.Parse(digit.ToString());
                    }

                    runners[name] += distance;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> winners = runners.OrderByDescending(kvp => kvp.Value)
                .Take(3)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine($"1st place: {winners.Keys.First()}");
            winners.Remove(winners.Keys.First());
            Console.WriteLine($"2nd place: {winners.Keys.First()}");
            winners.Remove(winners.Keys.First());
            Console.WriteLine($"3rd place: {winners.Keys.First()}");
        }
    }
}
