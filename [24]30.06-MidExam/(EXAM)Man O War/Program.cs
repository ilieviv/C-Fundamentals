using System;
using System.Linq;

namespace _EXAM_Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            var statusPirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            var statusWarShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            int maximumHealth = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Retire")
            {
                string[] splittedInput = input.Split(" ");

                string command = splittedInput[0];

                if (command == "Fire")
                {
                    int index = int.Parse(splittedInput[1]);
                    int damage = int.Parse(splittedInput[2]);

                    //if (!(index >= statusWarShip.Count))
                    if (index >= 0 && index < statusWarShip.Count)
                    {
                        statusWarShip[index] -= damage;

                        if (statusWarShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }

                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int endIndex = int.Parse(splittedInput[2]);
                    int damage = int.Parse(splittedInput[3]);

                    //if (!(startIndex >= statusPirateShip.Count && endIndex >= statusPirateShip.Count))//
                    if (startIndex >= 0 && startIndex < statusPirateShip.Count && endIndex < statusPirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            statusPirateShip[i] -= damage;

                            if (statusPirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(splittedInput[1]);
                    int health = int.Parse(splittedInput[2]);

                    //  if (!(index >= statusPirateShip.Count))
                    if (index >= 0 && index < statusPirateShip.Count)
                    {
                        statusPirateShip[index] += health;

                        if (statusPirateShip[index] > maximumHealth)
                        {
                            statusPirateShip[index] = maximumHealth;
                        }
                    }

                }
                else if (command == "Status")
                {
                    int sectionsToRepair = 0;

                    foreach (var section in statusPirateShip)
                    {
                        double criticalLevel = maximumHealth * 0.20;
                        if (section < criticalLevel)
                        {
                            sectionsToRepair++;
                        }
                    }

                    Console.WriteLine($"{sectionsToRepair} sections need repair.");
                }


                input = Console.ReadLine();
            }
            int pirateShipSum = 0;
            int warshipSum = 0;

            foreach (var section in statusPirateShip)
            {
                pirateShipSum += section;
            }

            foreach (var section in statusWarShip)
            {
                warshipSum += section;
            }

            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warshipSum}");
        }
    }
}
