using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double initialVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string beer = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > initialVolume)
                {
                    biggestKeg = beer;
                    initialVolume = volume;
                }

            }

            Console.WriteLine(biggestKeg);
        }
    }
}
