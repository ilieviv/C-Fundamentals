using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var companies = new SortedDictionary<string, List<string>>();

            while (input != "End")
            {
                var inputArr = input.Split(" -> ").ToArray();

                string company = inputArr[0];
                string id = inputArr[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine(kvp.Key);

                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
