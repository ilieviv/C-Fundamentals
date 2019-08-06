using System;

namespace _EXAM_Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dayPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            double additionalPlunder = dayPlunder * 0.50; //maybe 1/2

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    totalPlunder += additionalPlunder;
                }

                totalPlunder += dayPlunder;

                if (i % 5 == 0)
                {
                    totalPlunder -= (totalPlunder * 0.30);
                }

            }

            double percentage = totalPlunder / expectedPlunder * 100;

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
