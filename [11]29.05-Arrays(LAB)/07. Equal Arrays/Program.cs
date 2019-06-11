using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool identical = false;
            int notIdentical = 0;
            int sum = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == input2[i])
                {
                    identical = true;
                    sum += input2[i];
                }
                else
                {
                    identical = false;
                    notIdentical = i;
                    break;
                }
            }

            if (identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {notIdentical} index");
            }
        }
    }
}
