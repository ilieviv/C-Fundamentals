using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double rounds = Math.Ceiling(people / capacity);

            Console.WriteLine(rounds);
        }
    }
}
