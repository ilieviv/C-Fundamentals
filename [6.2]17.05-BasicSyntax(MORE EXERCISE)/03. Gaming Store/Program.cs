using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = string.Empty;
            double price = 0;
            double initialBalance = balance;
            bool stop = false;

            while ((input = Console.ReadLine()) != "Game Time")
            {
                if (input != "OutFall 4" && input != "CS: OG" && input != "Zplinter Zell" && input != "Honored 2" && input != "RoverWatch" && input!= "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                switch (input)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        break;
                }

                if (balance - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= price;
                }

                if (balance == 0)
                {   
                    Console.WriteLine("Out of money!");
                    stop = true;
                    break;
                }
            }

            if (!stop)
            {
                Console.WriteLine($"Total spent: ${(initialBalance - balance):f2}. Remaining: ${balance:f2}");
            }

        }
    }
}
