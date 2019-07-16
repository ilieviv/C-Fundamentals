using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];
            int sum = 1;

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }

            if (first.Length < second.Length)
            {
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }

            Console.WriteLine(sum - 1);
        }
    }
}
