using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());

            double waterOnePerson = double.Parse(Console.ReadLine());
            double foodOnePerson = double.Parse(Console.ReadLine());

            double water = waterOnePerson * players * days;
            double food = foodOnePerson * players * days;

            bool success = true;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;

                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
                    success = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    energy += (energy * 0.05);
                    water -= (water * 0.30);
                }

                if (i % 3 == 0)
                {
                    energy += energy * 0.10;
                    food -= food / players;
                }
            }
            if (success)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
