using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> initialDrumSet = new List<int>();

            foreach (var drum in drumSet)
            {
                initialDrumSet.Add(drum);
            }

            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hit = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hit;

                    if (drumSet[i] <= 0)
                    {
                        if ((savings - (3 * initialDrumSet[i]) >= 0))
                        {
                            savings -= 3 * initialDrumSet[i];
                            drumSet[i] = initialDrumSet[i];
                        }
                    }
                }

                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= 0)
                    {
                        drumSet.Remove(drumSet[i]);
                        initialDrumSet.Remove(initialDrumSet[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
