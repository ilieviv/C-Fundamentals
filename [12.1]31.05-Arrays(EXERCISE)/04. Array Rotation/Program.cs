using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int[] newArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int newPosition = i + rotations;

                if (newPosition >= input.Length)
                {
                    newPosition = newPosition - input.Length;

                    if (newPosition >= input.Length)
                    {
                        newPosition = newPosition - input.Length;
                    }
                }
                newArray[i] = input[newPosition];
            }

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
