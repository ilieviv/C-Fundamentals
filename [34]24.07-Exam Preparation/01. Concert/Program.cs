using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var bandsList = new Dictionary<string, List<string>>();
            var bandsWithTimeList = new Dictionary<string, long>();
            long totalTime = 0;

            while (input != "start of concert")
            {
                string[] inputArr = input.Split("; ");
                string command = inputArr[0];
                string bandName = inputArr[1];

                string[] members = inputArr[2].Split(", ");


                if (command == "Add")
                {
                    if (bandsList.ContainsKey(bandName))
                    {
                        foreach (var member in members)
                        {
                            if (!bandsList[bandName].Contains(member))
                            {
                                bandsList[bandName].Add(member);
                            }
                        }
                    }
                    else
                    {
                        bandsList.Add(bandName, new List<string>());

                        foreach (var member in members)
                        {
                            bandsList[bandName].Add(member);
                        }
                    }
                }
                else if (command == "Play")
                {
                    long time = long.Parse(inputArr[2]);
                    totalTime += time;

                    if (!bandsWithTimeList.ContainsKey(bandName))
                    {
                        bandsWithTimeList.Add(bandName, 0);
                    }
                    bandsWithTimeList[bandName] += time;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {bandsWithTimeList.Values.Sum()}");

            foreach (var band in bandsWithTimeList.OrderByDescending(kvp => kvp.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string bandNameToShow = Console.ReadLine();
            Console.WriteLine(bandNameToShow);
            List<string> membersToPrlong = bandsList.FirstOrDefault(b => b.Key == bandNameToShow).Value;

            foreach (var member in membersToPrlong)
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
