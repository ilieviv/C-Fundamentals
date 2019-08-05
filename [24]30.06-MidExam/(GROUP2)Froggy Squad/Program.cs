using System;
using System.Linq;
using System.Collections.Generic;

namespace _GROUP2_Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            var frogNames = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                var commandSplitted = command.Split();

                string operation = commandSplitted[0];

                if (operation == "Join")
                {
                    string name = commandSplitted[1];
                    frogNames.Add(name);
                }
                else if (operation == "Jump")//TODO
                {
                    string name = commandSplitted[1];
                    int index = int.Parse(commandSplitted[2]);

                    if (index >= 0 && index < frogNames.Count)
                    {
                        frogNames.Insert(index, name);
                    }
                }
                else if (operation == "Dive")
                {
                    int index = int.Parse(commandSplitted[1]);

                    if (index >= 0 && index < frogNames.Count)
                    {
                        frogNames.RemoveAt(index);
                    }
                }
                else if (operation == "First")
                {
                    int count = int.Parse(commandSplitted[1]);

                    if (count >= frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    var print = new List<string>();
                    print = frogNames.Take(count).Select(x => x).ToList();
                    Console.WriteLine(string.Join(" ", print));
                }
                else if (operation == "Last")
                {
                    int count = int.Parse(commandSplitted[1]);

                    if (count >= frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    frogNames.Reverse();
                    var print = new List<string>();
                    print = frogNames.Take(count).Select(x => x).ToList();
                    print.Reverse();
                    frogNames.Reverse();
                    Console.WriteLine(string.Join(" ", print));
                }
                else if (operation == "Print")
                {
                    string typeOrder = commandSplitted[1];

                    if (typeOrder == "Normal")
                    {
                        Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
                        return;
                    }
                    if (typeOrder == "Reversed")
                    {
                        frogNames.Reverse();
                        Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
                        return;
                    }
                }
            }
        }
    }
}
