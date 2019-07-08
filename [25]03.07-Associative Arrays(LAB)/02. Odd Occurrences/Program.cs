using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ")
                .ToList();

            var dict = new Dictionary<string, int>();

            foreach (var element in input)
            {
                string word = element.ToLower();
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }

                dict[word]++;
            }

            foreach (var element in dict)
            {
                if (!(element.Value % 2 == 0))
                {
                    Console.Write(element.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
