using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //string[] numbers = input.Split();
            //double[] arr = new double[numbers.Length];
 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    arr[i] = double.Parse(numbers[i]);
            //    Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], 0, MidpointRounding.AwayFromZero)}");
            //}

            //Second 

            double[] numbers2 = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine($"{numbers2[i]} => {Math.Round(numbers2[i], 0, MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
