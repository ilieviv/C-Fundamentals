using System;

namespace _GROUP_1_Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            double total = 0;
            double shorterLength = length - (length * 0.3);

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    total += shorterLength * 0.01;
                }
                else
                {
                    total += length * 0.01;
                }
            }

            double percentage = total / distance * 100;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
