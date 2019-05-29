using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());
            int numb3 = int.Parse(Console.ReadLine());
            int numb4 = int.Parse(Console.ReadLine());

            int sum = ((numb1 + numb2) / numb3) * numb4;
            Console.WriteLine(sum);
        }
    }
}
