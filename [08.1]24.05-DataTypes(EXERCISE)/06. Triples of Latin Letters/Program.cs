using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + input; first++)
            {
                for (char second = 'a'; second < 'a' + input; second++)
                {
                    for (char third = 'a'; third < 'a' + input; third++)
                    {
                        string result = first.ToString() + second.ToString() + third.ToString();
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
