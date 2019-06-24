using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialCourse = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(":")
                    .ToList();

                if (input[0] == "course start")
                {
                    break;
                }

                switch (input[0])
                {
                    case "Add":
                        if (!initialCourse.Contains(input[1]))
                        {
                            initialCourse.Add(input[1]);
                        }
                        break;
                    case "Insert":

                        if (!initialCourse.Contains(input[1]))
                        {
                            initialCourse.Insert(int.Parse(input[2]), input[1]);
                        }
                        break;
                    case "Remove":
                        if (initialCourse.Contains(input[1]))
                        {
                            initialCourse.Remove(input[1]);

                        }
                        if (initialCourse.Contains(input[1] + "-Exercise"))
                        {
                            initialCourse.Remove(input[1] + "-Exercise");

                        }
                        break;
                    case "Swap": //TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        if (initialCourse.Contains(input[1]) && initialCourse.Contains(input[2]))
                        {
                            int indexFirst = initialCourse.IndexOf(input[1]);
                            int indexSecond = initialCourse.IndexOf(input[2]);

                            initialCourse.Insert(indexFirst, input[2]);
                            initialCourse.RemoveAt(indexFirst + 1);

                            if (initialCourse.Contains(input[1] + "-Exercise"))
                            {
                                string newExercise = input[1] + "-Exercise";
                                initialCourse.Insert(indexFirst + 1, newExercise);
                                initialCourse.RemoveAt(indexFirst + 1);
                            }

                            initialCourse.Insert(indexSecond, input[1]);
                            initialCourse.RemoveAt(indexSecond + 1);

                            if (initialCourse.Contains(input[2] + "-Exercise"))
                            {
                                string newExercise = input[2] + "-Exercise";
                                initialCourse.Insert(indexFirst + 1, newExercise);
                                initialCourse.RemoveAt(indexSecond + 2);
                            }

                        }
                        break;
                    case "Exercise":
                        if (initialCourse.Contains(input[1]))
                        {
                            if (!initialCourse.Contains(input[1] + "-Exercise"))
                            {
                                string newExercise = input[1] + "-Exercise";
                                int index = initialCourse.IndexOf(input[1]);
                                initialCourse.Insert(index + 1, newExercise);
                            }
                        }
                        else
                        {
                            initialCourse.Add(input[1]);
                            string newExercise = input[1] + "-Exercise";
                            initialCourse.Add(newExercise);
                        }
                        break;
                    default:
                        break;
                }

            }

            for (int i = 0; i < initialCourse.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialCourse[i]}");
            }
        }
    }
}
