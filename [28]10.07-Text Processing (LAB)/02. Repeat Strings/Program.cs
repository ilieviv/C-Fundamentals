using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            StringBuilder result = new StringBuilder();


            foreach (var word in arr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }
 
            Console.WriteLine(result);
        }
    }
}
