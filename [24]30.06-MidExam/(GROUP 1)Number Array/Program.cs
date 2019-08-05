using System;
using System.Linq;

namespace _GROUP_1_Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(" ")
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] operation = command.Split(" ");

                string op = operation[0];

                if (op == "Switch")
                {
                    int index = int.Parse(operation[1]);

                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers[index] *= -1;
                    }
                }
                else if (op == "Change")
                {
                    int index = int.Parse(operation[1]);
                    int value = int.Parse(operation[2]);

                    if (index < numbers.Length && index >= 0)
                    {
                        numbers[index] = value;
                    }
                }
                else if (op == "Sum")
                {
                    int sum = 0;

                    if (operation[1] == "Negative")
                    {

                        foreach (var number in numbers)
                        {
                            if (number < 0)
                            {
                                sum += number;
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    else if (operation[1] == "Positive")
                    {
                        foreach (var number in numbers)
                        {
                            if (number > 0)
                            {
                                sum += number;
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        foreach (var number in numbers)
                        {
                            sum += number;
                        }
                        Console.WriteLine(sum);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
