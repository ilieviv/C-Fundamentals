using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] splittedInput = input.Split(":");

                string artist = splittedInput[0];
                string song = splittedInput[1];

                string reg = @"^([A-Z][a-z|\s|']+):[A-Z|\s]+\b";

                int key = artist.Length;

                Match match = Regex.Match(input, reg);

                if (match.Success)
                {
                    StringBuilder output = new StringBuilder();
                    foreach (var symbol in input)
                    {
                        int newSymbol = 0;

                        if (!(symbol == ' ' | symbol == '\''))
                        {
                            newSymbol = symbol + key;
                        }
                        else
                        {
                            newSymbol = symbol;
                        }

                        if (symbol == ':')
                        {
                            newSymbol = 64;
                        }


                        if (symbol >= 65 && symbol <= 90 && newSymbol > 90)
                        {
                            int diff = newSymbol - 90;
                            newSymbol = 64 + diff;
                        }
                        if (symbol >= 97 && symbol <= 122 && newSymbol > 122)
                        {
                            int diff = newSymbol - 122;
                            newSymbol = 96 + diff;
                        }

                        output.Append((char)newSymbol);
                    }
                    Console.WriteLine($"Successful encryption: {output}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
