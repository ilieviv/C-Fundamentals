using System;
using System.Collections.Generic;
using System.Linq;

namespace _EXAM_Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> chest = new List<string>(input.Split("|").ToList());
            List<string> dropped = new List<string>();



            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                var operation = command.Split(" ").ToList();

                if (operation[0] == "Loot")
                {
                    for (int i = 1; i < operation.Count; i++)
                    {
                        if (!chest.Contains(operation[i]))
                        {
                            chest.Insert(0, operation[i]);
                        }
                    }
                }
                else if (operation[0] == "Drop")
                {
                    int index = int.Parse(operation[1]);

                    if (index >= 0 && index < chest.Count)
                    {
                        string temp = chest[index];

                        chest.RemoveAt(index);
                        chest.Add(temp);
                    }
                }
                else if (operation[0] == "Steal")
                {
                    int count = int.Parse(operation[1]);

                    if (count >= chest.Count)
                    {
                        count = chest.Count;
                    }
                    chest.Reverse();

                    for (int i = 0; i < count; i++)
                    {
                        dropped.Add(chest[0]);
                        chest.RemoveAt(0);
                    }

                    chest.Reverse();
                    dropped.Reverse();//tova nakraia, ako ima poveche ot 2
                    Console.WriteLine(string.Join(", ", dropped));
                    dropped.Clear();

                }

                command = Console.ReadLine();
            }

            double countItems = chest.Count;
            int totalLength = 0;

            foreach (var element in chest)
            {
                totalLength += element.Length;
            }

            double average = totalLength / countItems;

            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
        }
    }
}
