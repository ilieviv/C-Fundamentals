using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();

            List<int> secondList = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();

            List<int> newList = new List<int>();
            List<int> constraintList = new List<int>();

            secondList.Reverse();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                newList.Add(firstList[i]);
                newList.Add(secondList[i]);
            }

            if (firstList.Count < secondList.Count)
            {
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    constraintList.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    constraintList.Add(firstList[i]);
                }
            }

            constraintList.Sort();
            newList.Sort();

            int startNumber = constraintList[0];
            int lastNumber = constraintList[1];

            foreach (var numb in newList)
            {
                if (numb > startNumber && numb < lastNumber)
                {
                    Console.Write(numb + " ");
                }
            }
        }
    }
}
