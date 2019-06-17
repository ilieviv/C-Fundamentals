using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int numbersCount = numbers.Count / 2;

            for (int i = 0; i < numbersCount; i++)
            {
                int otherSide = numbers[numbers.Count - 1];
                numbers[i] += otherSide;
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
            //List<int> result = new List<int>();

            //for (int i = 0; i < numbers.Count / 2; i++)
            //{
            //    int next = numbers[i] + numbers[numbers.Count - 1 - i];
            //    result.Add(next);

            //}

            //if (numbers.Count % 2 == 1)
            //{
            //    result.Add(numbers[numbers.Count / 2]);
            //}


            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
