using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < lines; i++)
            {
                char asci = char.Parse(Console.ReadLine());
                totalSum += asci;

            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
