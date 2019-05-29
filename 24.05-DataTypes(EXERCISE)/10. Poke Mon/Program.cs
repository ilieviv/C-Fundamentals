using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());          //N
            int distance = int.Parse(Console.ReadLine());           //M
            int exhaustionFactor = int.Parse(Console.ReadLine());   //Y

            double halfPokePower = pokePower * 0.5;
            int targets = 0;

            while (pokePower >= distance)
            {
                if (pokePower == halfPokePower)
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower /= exhaustionFactor;

                        if (pokePower < distance)
                        {
                            break;
                        }
                    }
                }
                pokePower -= distance;
                targets++;
            }
            Console.WriteLine(pokePower + Environment.NewLine + targets);
        }
    }
}
