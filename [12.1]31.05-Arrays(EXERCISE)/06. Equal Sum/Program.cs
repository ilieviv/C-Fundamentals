using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            bool isNo = true;
            //10 5 5 99 3 4 2 5 1 1 4
            for (int i = 0; i < arr.Length; i++)
            {


                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isNo = false;
                    break;
                }
            }

            if (isNo)
            {
                Console.WriteLine("no");
            }
        }
    }
}
