using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<string> result = new List<string>();

            bool operationFromPreviousTask = false;

            List<int> copyNumbers = numbers;

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ")
                    .ToList();



                //From previous task
                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Add")
                {
                    operationFromPreviousTask = true;
                    numbers.Add(int.Parse(input[1]));
                }
                if (input[0] == "Remove")
                {
                    operationFromPreviousTask = true;
                    numbers.Remove(int.Parse(input[1]));
                }
                if (input[0] == "RemoveAt")
                {
                    operationFromPreviousTask = true;
                    numbers.RemoveAt(int.Parse(input[1]));
                }
                if (input[0] == "Insert")
                {
                    operationFromPreviousTask = true;
                    int index = int.Parse(input[1]);
                    int toRemove = int.Parse(input[2]);
                    numbers.Insert(toRemove, index);
                }
                //ENd previous task

                if (input[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(input[1])))
                    {
                        result.Add("Yes");
                    }
                    else
                    {
                        result.Add("No such number");
                    }
                }

                if (input[0] == "PrintEven")
                {
                    string res = string.Empty;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            res += numbers[i] + " ";
                        }

                    }
                    result.Add(res);
                }

                if (input[0] == "PrintOdd")
                {
                    string res = string.Empty;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            res += numbers[i] + " ";
                        }

                    }
                    result.Add(res);
                }

                if (input[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    result.Add(sum.ToString());
                }

                if (input[0] == "Filter")
                {

                    switch (input[1])
                    {
                        case "<":
                            string res = string.Empty;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < int.Parse(input[2]))
                                {
                                    res += numbers[i] + " ";
                                }
                            }
                            result.Add(res);
                            break;
                        case ">":
                            res = string.Empty;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(input[2]))
                                {
                                    res += numbers[i] + " ";
                                }
                            }
                            result.Add(res);
                            break;
                        case "<=":
                            res = string.Empty;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= int.Parse(input[2]))
                                {
                                    res += numbers[i] + " ";
                                }
                            }
                            result.Add(res);
                            break;
                        case ">=":
                            res = string.Empty;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= int.Parse(input[2]))
                                {
                                    res += numbers[i] + " ";
                                }
                            }
                            result.Add(res);
                            break;
                        default:
                            break;
                    }

                }

            }
            if (operationFromPreviousTask == false && copyNumbers==numbers)
            {
                Console.WriteLine(string.Join(Environment.NewLine, result));
            }
        }
    }
}
