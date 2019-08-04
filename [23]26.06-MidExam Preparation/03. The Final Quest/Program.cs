using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine()
                .Split(" ")
                .ToList();



            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] splittedCommand = command.Split();

                string operation = splittedCommand[0];

                if (operation == "Delete")
                {
                    int index = int.Parse(splittedCommand[1]) + 1;

                    if (index >= 0 && index < words.Count)
                    {
                        words.RemoveAt(index);
                    }
                }
                else if (operation == "Swap")
                {
                    string word1 = splittedCommand[1];
                    string word2 = splittedCommand[2];

                    if (words.Contains(word1) && words.Contains(word2))
                    {
                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);

                        words[index1] = word2;
                        words[index2] = word1;
                    }
                }
                else if (operation == "Put")
                {
                    string word = splittedCommand[1];
                    int index = int.Parse(splittedCommand[2]) - 1;

                    if (index >= 0 && index < words.Count + 1)
                    {
                        words.Insert(index, word);
                    }
                }
                else if (operation == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (operation == "Replace")
                {
                    string word1 = splittedCommand[1];
                    string word2 = splittedCommand[2];

                    if (words.Contains(word2))
                    {
                        int index = words.IndexOf(word2);
                        words[index] = word1;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
