using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int removedSum = 0;
            int loops = distances.Count;
            for (int i = 0; i < loops; i++)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                bool notRemove = false;

                if (currentIndex >= distances.Count)
                {
                    currentIndex = distances.Count - 1;
                    notRemove = true;
                }

                int currentToRemove = distances[currentIndex];
                removedSum += currentToRemove;

                if (!notRemove)
                {
                    distances.RemoveAt(currentIndex);
                }


                for (int j = 0; j < distances.Count; j++)
                {
                    if (distances[j] <= currentToRemove)
                    {
                        distances[j] += currentToRemove;
                    }
                    else
                    {
                        distances[j] -= currentToRemove;
                    }
                }
            }

            Console.WriteLine(removedSum);
        }
    }
}
