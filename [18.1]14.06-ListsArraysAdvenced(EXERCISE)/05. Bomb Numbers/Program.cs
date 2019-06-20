using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();

            List<int> command = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int bomb = command[0];
            int power = command[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = numbers.IndexOf(bomb);
                if (index < 0)
                {
                    break;
                }

                int startIndex = StartIndex(index, power, numbers);
                int countLeftElements = CalculateLeft(startIndex, index);
                int count = GetCount(power, numbers, index, countLeftElements);
                numbers.RemoveRange(startIndex, count);

            }
            Console.WriteLine(numbers.Sum());

        }

        static int CalculateLeft(int startIndex, int index)
        {
            int count = 0;
            for (int i = startIndex; i < index; i++)
            {
                count++;
            }
            return count;
        }

        static int GetCount(int power, List<int> numbers, int index, int leftCount)
        {
            int count = 0;
            if ((numbers.Count - 1 - index) < power)
            {
                for (int i = index; i < numbers.Count; i++)
                {
                    count++;
                }
            }
            else
            {
                for (int i = 0; i <= power; i++)
                {
                    count++;
                }
            }
            return count + leftCount;
        }

        static int StartIndex(int index, int power, List<int> numbers)
        {
            if (index < power)
            {
                index = 0;
            }
            else
            {
                index -= power;
            }
            return index;
        }
    }
}
