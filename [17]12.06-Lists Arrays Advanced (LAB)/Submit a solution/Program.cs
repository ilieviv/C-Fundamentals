using System;
using System.Collections.Generic;

namespace Submit_a_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                productsList.Add(input);
            }

            productsList.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}." + productsList[i]);
            }
        }
    }
}
