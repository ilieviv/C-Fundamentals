using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> usersWithPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageList = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] splittedInput = input.Split('-');

                string name = splittedInput[0];
                string language = splittedInput[1];

                if (language != "banned")
                {
                    int points = int.Parse(splittedInput[2]);

                    if (languageList.ContainsKey(language))
                    {
                        languageList[language]++;
                    }
                    else
                    {
                        languageList.Add(language, 1);
                    }


                    if (!usersWithPoints.ContainsKey(name))
                    {
                        usersWithPoints.Add(name, points);
                    }
                    else
                    {
                        if (usersWithPoints[name] < points)
                        {
                            usersWithPoints[name] = points;
                        }
                    }

                }
                else
                {
                    usersWithPoints.Remove(name);
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"Results:");



            foreach (var kvp in usersWithPoints.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine($"Submissions:");

            foreach (var kvp in languageList.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))

            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
