using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] names = line.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.Write(names[i] + " ");
            }
        }
    }
}
