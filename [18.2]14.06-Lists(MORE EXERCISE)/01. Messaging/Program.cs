using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();

            string word = Console.ReadLine();

            for (int i = 0; i < input.Count; i++)
            {
                int currentNumber = input[i];
                int currentNumberLength = currentNumber.ToString().Length;
                int sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (sum >= word.Length)
                {
                    sum -= word.Length;
                }
                Console.Write(word[sum]);
                word = word.Remove(sum, 1);
            }
            Console.WriteLine();
        }
    }
}
