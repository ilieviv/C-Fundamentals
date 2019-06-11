using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;

            int snowballSnowMax = 0;
            int snowballTimeMax = 0;
            int snowballQualityMax = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValueCalculated =BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValueCalculated >= snowballValue)
                {
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballQualityMax = snowballQuality;
                    snowballValue = snowballValueCalculated;

                }
            }

            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValue} ({snowballQualityMax})");
        }
    }
}
