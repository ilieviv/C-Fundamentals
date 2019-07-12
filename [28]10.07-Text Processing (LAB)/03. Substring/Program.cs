using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            bool matches = true;

            while (matches)
            {
                if (second.Contains(first))
                {
                    second = second.Remove(second.IndexOf(first), first.Length);
                }
                else
                {
                    matches = false;
                }
            }
            Console.WriteLine(second);
        }
    }
}
