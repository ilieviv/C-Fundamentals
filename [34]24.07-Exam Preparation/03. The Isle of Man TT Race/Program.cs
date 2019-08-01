using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool coordinatedFound = false;
            Regex pattern = new Regex(@"^([#|$|%|\*|&])(?<name>[A-Za-z]+)(\1)=(?<length>\d+)!!(?<geohash>.+)$");

            while (!coordinatedFound)
            {
                bool found = pattern.IsMatch(input);

                if (found)
                {
                    string name = pattern.Match(input).Groups["name"].ToString();
                    int length = int.Parse(pattern.Match(input).Groups["length"].ToString());
                    string geohash = pattern.Match(input).Groups["geohash"].ToString();

                    if (geohash.Length != length)
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (var symbol in geohash)
                        {
                            sb.Append((char)(symbol + length));
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {sb}");
                        coordinatedFound = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
