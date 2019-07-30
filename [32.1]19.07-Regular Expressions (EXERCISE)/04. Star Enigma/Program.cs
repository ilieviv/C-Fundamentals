using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"@([A-Z][a-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([A|D])![^@\-!:>]*->(\d+)");

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int key = 0;

                string decryptInput = input.ToLower();

                foreach (char symbol in decryptInput)
                {
                    if (symbol == 115 || symbol == 116 || symbol == 97 || symbol == 114)
                    {
                        key++;
                    }
                }

                string encryptedInput = string.Empty;

                foreach (var symbol in input)
                {
                    int newSymbol = symbol - key;
                    encryptedInput += (char)newSymbol;
                }

                if (regex.IsMatch(encryptedInput))
                {
                    string planetNames = regex.Match(encryptedInput).Groups[1].ToString();
                    string attackType = regex.Match(encryptedInput).Groups[3].ToString();
                    
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetNames);
                    }

                    if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetNames);
                    }
                }

            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
