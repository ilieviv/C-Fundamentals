﻿using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ").ToArray();

            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
               text= text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
