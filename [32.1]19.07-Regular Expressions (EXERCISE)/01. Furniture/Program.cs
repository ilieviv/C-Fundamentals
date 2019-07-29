using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> purchasedFurnitures = new List<string>();
            decimal totalSpend = 0;

            Regex ordered = new Regex(@"^>>(\w+)<<(\d+(\.\d+)?)!(\d+)\b");

            while (input != "Purchase")
            {
                if (ordered.IsMatch(input))
                {
                    int quantity = int.Parse(ordered.Match(input).Groups[4].ToString());

                    if (quantity > 0)
                    {
                        string furnitureName = ordered.Match(input).Groups[1].ToString();
                        purchasedFurnitures.Add(furnitureName);

                        decimal price = decimal.Parse(ordered.Match(input).Groups[2].ToString());

                        totalSpend += price * quantity;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (purchasedFurnitures.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, purchasedFurnitures));
            }

            Console.WriteLine($"Total money spend: {totalSpend:f2}");
        }
    }
}
