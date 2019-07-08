using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var usefullMaterials = new Dictionary<string, int>();
            usefullMaterials["motes"] = 0;
            usefullMaterials["fragments"] = 0;
            usefullMaterials["shards"] = 0;

            var junkMaterials = new Dictionary<string, int>();
            bool toBreak = false;

            while (!toBreak)
            {
                var input = Console.ReadLine().ToLower().Split(" ");


                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (material == "motes")
                    {
                        usefullMaterials[material] += quantity;

                        if (usefullMaterials[material] >= 250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            usefullMaterials[material] -= 250;
                            toBreak = true;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        usefullMaterials[material] += quantity;

                        if (usefullMaterials[material] >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            usefullMaterials[material] -= 250;
                            toBreak = true;
                            break;
                        }
                    }
                    else if (material == "shards")
                    {
                        usefullMaterials[material] += quantity;

                        if (usefullMaterials[material] >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            usefullMaterials[material] -= 250;
                            toBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                    }

                    if (toBreak)
                    {
                        break;
                    }
                }

                usefullMaterials = usefullMaterials
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                junkMaterials = junkMaterials
                    .OrderBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            }
            foreach (var kvp in usefullMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
