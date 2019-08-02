using System;
using System.Collections.Generic;
using System.Linq;

namespace Feed_the_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> animalDailyLimit = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimal = new Dictionary<string, List<string>>();

            while (input != "Last Info")
            {
                string[] splittedInput = input.Split(":");

                string command = splittedInput[0];
                string name = splittedInput[1];
                int food = int.Parse(splittedInput[2]);
                string area = splittedInput[3];

                if (command == "Add")
                {
                    if (!animalDailyLimit.ContainsKey(name))
                    {
                        animalDailyLimit.Add(name, food);

                        if (areaAnimal.ContainsKey(area))
                        {
                            areaAnimal[area].Add(name);
                        }
                        else
                        {
                            List<string> n = new List<string>();
                            n.Add(name);
                            areaAnimal.Add(area, n);
                        }

                    }
                    else
                    {
                        animalDailyLimit[name] += food;
                    }
                }
                else
                {
                    if (animalDailyLimit.ContainsKey(name))
                    {
                        animalDailyLimit[name] -= food;

                        if (animalDailyLimit[name] <= 0)
                        {
                            Console.WriteLine($"{name} was successfully fed");
                            animalDailyLimit.Remove(name);
                            areaAnimal[area].Remove(name);
                        }
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Animals:");

            foreach (var animal in animalDailyLimit.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var item in areaAnimal.OrderByDescending(x => x.Value.Count).Where(x => x.Value.Count > 0))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
