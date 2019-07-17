using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            List<char> result = new List<char>();
            result.Add(input[0]);

            foreach (char symbol in input)
            {
                if (symbol !=result.Last())
                {
                    result.Add(symbol);
                }
            }
            Console.WriteLine(string.Join("", result));

            //string result = string.Empty;

            //for (int i = 1; i < input.Length; i++)
            //{
            //    if (input[i] != input[i - 1])
            //    {
            //        result += input[i - 1];
            //    }
            //}
            //result += input[input.Length - 1];
            //Console.WriteLine(result);
        }
    }
}
