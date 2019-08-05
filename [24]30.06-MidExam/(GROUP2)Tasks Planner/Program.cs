using System;
using System.Collections.Generic;
using System.Linq;

namespace _GROUP2_Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> completedTasks = new List<int>();
            List<int> droppedTasks = new List<int>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var splittedInput = input.Split();
                string operation = splittedInput[0];

                if (operation == "Complete")
                {
                    int index = int.Parse(splittedInput[1]);

                    if (index >= 0 && index < hours.Count)
                    {
                        completedTasks.Add(index);
                        hours[index] = 0;
                    }
                }
                else if (operation == "Change")
                {
                    int index = int.Parse(splittedInput[1]);
                    int time = int.Parse(splittedInput[2]);

                    if (index >= 0 && index < hours.Count)
                    {
                        hours[index] = time;
                    }
                }
                else if (operation == "Drop")
                {
                    int index = int.Parse(splittedInput[1]);

                    if (index >= 0 && index < hours.Count)
                    {
                        hours[index] = -1;
                    }
                }
                else if (operation == "Count")
                {
                    string task = splittedInput[1];

                    if (task == "Completed")
                    {
                        Console.WriteLine(string.Join(" ", hours.Where(x => x == 0).Count()));
                    }
                    else if (task == "Incomplete")
                    {
                        Console.WriteLine(hours.Where(x => x > 0).Count());
                    }
                    else if (task == "Dropped")
                    {
                        Console.WriteLine(hours.Where(x => x < 0).Count());
                    }
                }
                input = Console.ReadLine();
            }

            //Console.WriteLine(string.Join(" ", completedTasks));

            Console.WriteLine(string.Join(" ", hours.Where(x => x > 0)));
        }
    }
}
