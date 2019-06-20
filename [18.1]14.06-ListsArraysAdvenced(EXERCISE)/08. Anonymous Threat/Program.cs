using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ")
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] currentCommand = command.Split();

                switch (currentCommand[0])
                {
                    case "merge":
                        input = Merge(input,
                            int.Parse(currentCommand[1]),
                            int.Parse(currentCommand[2]));
                        break;
                    case "divide":
                        input = Divide(input,
                            int.Parse(currentCommand[1]),
                            int.Parse(currentCommand[2]));
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', input));
        }

        static List<string> Merge(List<string> input, int startIndex, int endIndex)
        {
            string[] inputAsArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                inputAsArray[i] = input[i];
            }

            if ((startIndex >= 0 && startIndex < input.Count) && (endIndex >= 0 && endIndex < input.Count))
            {
                if (startIndex != input.Count - 1)
                {
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        inputAsArray[startIndex] += inputAsArray[i];
                        inputAsArray[i] = null;
                    }
                    input = inputAsArray.ToList();
                    input.RemoveAll(x => x == null);
                }
            }
            else
            {
                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex >= input.Count)
                {
                    endIndex = input.Count - 1;
                }

                if (startIndex != input.Count - 1)
                {
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        inputAsArray[startIndex] += inputAsArray[i];
                        inputAsArray[i] = null;
                    }
                    input = inputAsArray.ToList();
                    input.RemoveAll(x => x == null);
                }
            }
            return input;
        }

        static List<string> Divide(List<string> input, int index, int partitions)
        {
            string stringToDivide = input[index];
            input.RemoveAt(index);
            var stringToAdd = new List<string>();

            int partitionLength = stringToDivide.Length / partitions;
            int remainder = stringToDivide.Length % partitions;
            string token = "";
            int count = 0;

            for (int i = 0; i < stringToDivide.Length; i++)
            {
                token += stringToDivide[i];

                if (token.Length == partitionLength)
                {
                    stringToAdd.AddRange(token.Split().ToList());
                    token = "";
                    count++;

                    if (count == partitions - 1)
                    {
                        partitionLength += remainder;
                    }

                }
            }
            input.InsertRange(index, stringToAdd);
            return input;
        }
    }
}
