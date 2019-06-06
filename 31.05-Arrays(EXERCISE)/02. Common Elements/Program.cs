using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
                .Split(" ");
            string[] input2 = Console.ReadLine()
               .Split(" ");

            string result = string.Empty;

            for (int i = 0; i < input2.Length; i++)
            {
                foreach (var item in input1)
                {
                    if (item==input2[i])
                    {
                        result += item + " ";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
