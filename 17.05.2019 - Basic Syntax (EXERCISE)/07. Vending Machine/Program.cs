using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            string input;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(Console.ReadLine());

                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1.0:
                    case 2.0:
                        totalMoney += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
            }


            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                double price = 0;

                if (product == "Coke")
                {
                    price = 1;
                }
                else if (product == "Nuts")
                {
                    price= 2; 
                }
                else if (product == "Water")
                {
                    price = 0.7;
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                }
            }


            //string input = Console.ReadLine();
            //double sumCoins = 0;

            //while (input != "Start")
            //{
            //    double coin = double.Parse(input);

            //    if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1.0 && coin != 2.0)
            //    {
            //        Console.WriteLine($"Cannot accept {coin}");
            //    }
            //    else
            //    {
            //        sumCoins += coin;
            //    }
            //    input = Console.ReadLine();
            //}

            //string inputFood = Console.ReadLine();

            //while (inputFood != "End" && sumCoins >= 0)
            //{
            //    if (inputFood == "Nuts")
            //    {
            //        sumCoins -= 2.0;
            //        if (sumCoins >= 0)
            //        {
            //            Console.WriteLine("Purchased Nuts");
            //        }
            //    }
            //    else if (inputFood == "Water")
            //    {
            //        sumCoins -= 0.7;
            //        if (sumCoins >= 0)
            //        {
            //            Console.WriteLine("Purchased Water");
            //        }
            //    }
            //    else if (inputFood == "Crisps")
            //    {
            //        sumCoins -= 1.5;
            //        if (sumCoins >= 0)
            //        {
            //            Console.WriteLine("Purchased Crisps");
            //        }
            //    }
            //    else if (inputFood == "Soda")
            //    {
            //        sumCoins -= 0.8;
            //        if (sumCoins >= 0)
            //        {
            //            Console.WriteLine("Purchased Soda");
            //        }
            //    }
            //    else if (inputFood == "Coke")
            //    {
            //        sumCoins -= 1;
            //        if (sumCoins >= 0)
            //        {
            //            Console.WriteLine("Purchased Coke");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid product");
            //    }

            //    inputFood = Console.ReadLine();
            //}

            //if (sumCoins < 0)
            //{
            //    Console.WriteLine("Sorry, not enough money");
            //    Console.WriteLine("Change: {0:f2}", Math.Abs(sumCoins));
            //}
        }
    }
}
