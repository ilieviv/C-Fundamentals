using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double sum = Product(product) * quantity;
            Console.WriteLine($"{sum:f2}");
        }
        static double Product(string product)
        {
            if (product=="coffee")
            {
                return 1.50;
            }
            else if (product=="water")
            {
                return 1.0;
            }
            else if (product == "coke")
            {
                return 1.40;
            }
            else if (product == "snacks")
            {
                return 2.0;
            }

            return 0;
        }
    }
}
