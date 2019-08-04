using System;
using System.Collections.Generic;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string fires = Console.ReadLine();

            int water = int.Parse(Console.ReadLine());

            string[] splittedFires = fires.Split("#");

            double totalEffort = 0;
            List<int> cells = new List<int>();

            for (int i = 0; i < splittedFires.Length; i++)
            {
                string[] currentCell = splittedFires[i].Split();

                string intense = currentCell[0];
                int level = int.Parse(currentCell[2]);

                bool isValidCell = IsCellValid(intense, level);

                if (water - level >= 0 && isValidCell)
                {
                    water -= level;
                    cells.Add(level);
                    totalEffort += (0.25 * level);
                }

            }
            Console.WriteLine("Cells:");

            int totalFire = 0;
            foreach (var cell in cells)
            {
                Console.WriteLine($" - {cell}");
                totalFire += cell;
            }

            Console.WriteLine($"Effort: {totalEffort:f2}");

            Console.WriteLine($"Total Fire: {totalFire}");
        }

        private static bool IsCellValid(string intense, int level)
        {
            if (intense == "High")
            {
                return level >= 81 && level <= 125;
            }
            if (intense == "Medium")
            {
                return level >= 51 && level <= 80;
            }
            if (intense == "Low")
            {
                return level >= 1 && level <= 50;
            }
            return false;
        }
    }
}
