using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var charsDictionary = new Dictionary<char, int>();
             
            foreach (char ch in input)
            {
                if (ch==' ')
                {
                    continue;
                }
                else
                {
                    if (!charsDictionary.ContainsKey(ch))
                    {
                        charsDictionary[ch] = 0;
                    }
                    charsDictionary[ch]++;
                }
            }

            foreach (var ch in charsDictionary)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
