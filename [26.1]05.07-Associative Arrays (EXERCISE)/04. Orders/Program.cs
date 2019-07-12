using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, decimal[]>();
            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputArr = input
               .Split(" ")
               .ToArray();

                string product = inputArr[0];
                decimal price = decimal.Parse(inputArr[1]);
                decimal quantity = decimal.Parse(inputArr[2]);

                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new decimal[2]);
                }

                    orders[product][0] = price;
                    orders[product][1] += quantity;

                input = Console.ReadLine();
            }

            foreach (var product in orders)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):F2}");
            }
        }
    }
}
