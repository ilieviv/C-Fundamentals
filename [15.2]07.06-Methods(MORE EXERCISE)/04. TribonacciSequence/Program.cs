using System;

namespace _04._TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write(1 + " ");
            if (num >= 2)
            {
                Console.Write(1 + " ");
                if (num >= 3)
                {
                    Console.Write(2 + " ");
                }

            }


            int first = 1;
            int second = 1;
            int third = 2;

            for (int i = 0; i < num - 3; i++)
            {

                int current = first + second + third;
                Console.Write(current + " ");
                first = second;
                second = third;
                third = current;
            }
            Console.WriteLine();
        }
    }
}
