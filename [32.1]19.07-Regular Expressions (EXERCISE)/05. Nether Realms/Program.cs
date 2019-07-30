using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+\-*\/.]";
            Regex healthRegex = new Regex(healthPattern);

            string digitPattern = @"-?\d+\.?\d*";
            Regex digitRegex = new Regex(digitPattern);

            string operatorPattern = @"[*\/]";
            Regex operatorRegex = new Regex(operatorPattern);

            string[] demonsNames = Regex.Split(Console.ReadLine(), @"\s*,\s*")
                .OrderBy(x => x)
                .ToArray();

            for (int i = 0; i < demonsNames.Length; i++)
            {
                string currentDemon = demonsNames[i];

                int currentHealth = 0;
                MatchCollection healthSymbols = healthRegex.Matches(currentDemon);
                foreach (Match symbol in healthSymbols)
                {
                    currentHealth += char.Parse(symbol.Value);
                }

                double baseDamage = 0;
                MatchCollection digitMatch = digitRegex.Matches(currentDemon);
                foreach (Match number in digitMatch)
                {
                    baseDamage += double.Parse(number.Value);
                }

                MatchCollection operatorMatch = operatorRegex.Matches(currentDemon);
                foreach (Match operatorr in operatorMatch)
                {
                    string @operator = operatorr.Value;

                    if (@operator == "*")
                    {
                        baseDamage *= 2;
                    }
                    else
                    {
                        baseDamage /= 2;
                    }
                }
                Console.WriteLine($"{currentDemon} - {currentHealth} health, {baseDamage:f2} damage");
            }
        }
    }
}
