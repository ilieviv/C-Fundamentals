using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListOfNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondListOfNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < Math.Max(firstListOfNumbers.Count, secondListOfNumbers.Count); i++)
            {
                if (i < firstListOfNumbers.Count)
                {
                    resultList.Add(firstListOfNumbers[i]);
                }

                if (i < secondListOfNumbers.Count)
                {
                    resultList.Add(secondListOfNumbers[i]);
                }
            }


            //if (firstListOfNumbers.Count >= secondListOfNumbers.Count)
            //{
            //    for (int i = 0; i < secondListOfNumbers.Count; i++)
            //    {
            //        resultList.Add(firstListOfNumbers[i]);
            //        resultList.Add(secondListOfNumbers[i]);
            //    }
            //    for (int i = secondListOfNumbers.Count; i < firstListOfNumbers.Count; i++)
            //    {
            //        resultList.Add(firstListOfNumbers[i]);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < firstListOfNumbers.Count; i++)
            //    {
            //        resultList.Add(firstListOfNumbers[i]);
            //        resultList.Add(secondListOfNumbers[i]);
            //    }
            //    for (int i = firstListOfNumbers.Count; i < secondListOfNumbers.Count; i++)
            //    {
            //        resultList.Add(secondListOfNumbers[i]);
            //    }
            //}

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
