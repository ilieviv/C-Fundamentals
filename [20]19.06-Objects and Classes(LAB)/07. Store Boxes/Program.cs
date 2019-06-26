using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> allBoxes = new List<Box>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "end")
                {
                    break;
                }

                string serialNumber = input[0];
                string item = input[1];
                int quantity = int.Parse(input[2]);
                decimal price = decimal.Parse(input[3]);

                Box box = new Box();
                //box.Item = new Item();

                box.SerialNumber = serialNumber;
                box.Item.Name = item;
                box.Quantity = quantity;
                box.PriceBox = price;
                box.Item.Price = (double)price * quantity;

                allBoxes.Add(box);

            }

            var newList = allBoxes.OrderByDescending(x => x.Item.Price);

            foreach (Box boxItem in newList)
            {
                Console.WriteLine(boxItem.SerialNumber);
                Console.WriteLine($"-- {boxItem.Item.Name} - ${boxItem.PriceBox:f2}: {boxItem.Quantity}");
                Console.WriteLine($"-- ${boxItem.Item.Price:f2}");
            }

        }
    }
}
