using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(sum);
            //int sum = 0;

            //string[] input = new string[n];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    input[i] = Console.ReadLine();
            //}

            //foreach (var number in input)
            //{
            //    Console.Write(number + " ");
            //    int numberConvert = int.Parse(number);
            //    sum += numberConvert;
            //}
            //Console.WriteLine();
            
            //Console.WriteLine(sum);
        }
    }
}
