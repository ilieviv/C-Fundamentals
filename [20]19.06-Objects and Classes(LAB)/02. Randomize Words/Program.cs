using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ")
                .ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var randomIndex = rnd.Next(0, words.Count);
                var randomEl = words[randomIndex];
                var el = words[i];

                words[randomIndex] = el;
                words[i] = randomEl;

            }

            foreach (var number in words)
            {
                Console.WriteLine(number);
            }
        }
    }
}
