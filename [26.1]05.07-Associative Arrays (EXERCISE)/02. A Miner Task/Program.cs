using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 1;

            Dictionary<string, int> resources = new Dictionary<string, int>();
            string key = null;

            while (input != "stop")
            {

                if (counter % 2 == 1)
                {
                    if (!resources.ContainsKey(input))
                    {
                        resources.Add(input, 0);
                    }
                }
                else
                {
                    resources[key] += int.Parse(input);
                }

                key = input;
                input = Console.ReadLine();
                counter++;
            }

            foreach (var element in resources)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
