using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> raceTimes = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            double totalTimeFirst = 0;
            double totalTimeSecond = 0;

            int rounds = raceTimes.Count / 2;

            for (int i = 0; i < rounds; i++)
            {
                totalTimeFirst += raceTimes[i];

                if (raceTimes[i] == 0)
                {
                    totalTimeFirst *= 0.8d;
                }
            }

            for (int i = raceTimes.Count - 1; i >= rounds + 1; i--)
            {
                totalTimeSecond += raceTimes[i];

                if (raceTimes[i] == 0)
                {
                    totalTimeSecond *= 0.8d;
                }
            }

            if (totalTimeFirst < totalTimeSecond)
            {
                Console.WriteLine($"The winner is left with total time: {totalTimeFirst}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {totalTimeSecond}");
            }
        }
    }
}
