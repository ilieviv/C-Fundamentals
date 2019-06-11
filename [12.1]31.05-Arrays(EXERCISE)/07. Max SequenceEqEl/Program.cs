using System;
using System.Linq;

namespace _07._Max_SequenceEqEl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int maxCounter = 1;
            int number = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                int previousNumber = input[i - 1];
                int currentNumber = input[i];

                if (previousNumber == currentNumber)
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        number = currentNumber;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
