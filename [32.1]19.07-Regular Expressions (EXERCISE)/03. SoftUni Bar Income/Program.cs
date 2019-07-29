using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nameRegex = new Regex(@"\%([A-Z][a-z]+)\%");
            Regex productRegex = new Regex(@"<(\w+)>");
            Regex quantityRegex = new Regex(@"\|(\d+)\|");
            Regex priceRegex = new Regex(@"(\d+\.?\d+)\$");

            string input = Console.ReadLine();
            decimal totalIncome = 0;

            while (input != "end of shift")
            {
                if (nameRegex.IsMatch(input) && productRegex.IsMatch(input) & quantityRegex.IsMatch(input) && priceRegex.IsMatch(input))
                {
                    string name = nameRegex.Match(input).Groups[1].ToString();
                    string product = productRegex.Match(input).Groups[1].ToString();
                    int quantity = int.Parse(quantityRegex.Match(input).Groups[1].ToString());
                    decimal price = decimal.Parse(priceRegex.Match(input).Groups[1].ToString());

                    decimal total = quantity * price;
                    totalIncome += total;
                    Console.WriteLine($"{name}: {product} - {total:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
