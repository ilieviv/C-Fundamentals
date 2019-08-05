using System;

namespace _GROUP2_Giftbox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            double areaOfBox = side * side * 6;
            double percentage = 0;
            double total = 0;

            for (int i = 1; i <= sheets; i++)
            {
                double currentArea = area;

                if (i % 3 == 0)
                {
                    currentArea = area * 0.25;
                }
                total += currentArea;
            }

            percentage = total / areaOfBox * 100;

            Console.WriteLine($"You can cover {percentage:f2}% of the box.");
        }
    }
}
