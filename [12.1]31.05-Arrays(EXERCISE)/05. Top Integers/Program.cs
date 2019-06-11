using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {

                string result = string.Empty;
                if (arr[i] > arr[i + 1])
                {
                    result += arr[i] + " ";
                }
                Console.Write(result);

            }
            Console.Write(arr[arr.Length - 1]);
        }
    }
}
