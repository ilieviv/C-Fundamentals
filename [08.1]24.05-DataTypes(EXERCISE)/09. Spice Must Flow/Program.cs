using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int minned = 0;
            int days = 0;
            int actualYield = startingYield;


            while (actualYield >= 100)
            {
                days++;
                minned += actualYield - 26;
                actualYield -= 10;
            }

            if (minned - 26 >= 0)
            {
                minned -= 26;
            }
            else
            {
                minned = 0;
            }


            Console.WriteLine(days + Environment.NewLine + minned);
        }
    }
}
