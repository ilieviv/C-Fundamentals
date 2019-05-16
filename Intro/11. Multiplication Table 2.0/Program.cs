using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int result = 0;

            do
            {
                result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
