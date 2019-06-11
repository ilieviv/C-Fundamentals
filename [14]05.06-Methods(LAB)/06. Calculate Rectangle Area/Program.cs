using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine(Area(sideA, sideB));
        }

        static int Area(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
    }
}
