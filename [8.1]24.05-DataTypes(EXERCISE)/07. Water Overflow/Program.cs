using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankLiters = 0;
            int counter = 0;

            while (counter < lines)
            {
                counter++;
                int input = int.Parse(Console.ReadLine());

                if (tankLiters + input <= 255)
                {
                    tankLiters += input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            if (tankLiters <= 255)
            {
                Console.WriteLine(tankLiters);
            }
        }
    }
}
