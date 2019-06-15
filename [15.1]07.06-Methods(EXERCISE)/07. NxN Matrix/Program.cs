using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Matrix(number));
        }

        static string Matrix(int number)
        {
            string output = string.Empty;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    output += number + " ";
                }
                output += Environment.NewLine;
                
            }
            return output;
        }
        
        //static void Main(string[] args)
        //{
        //    int number = int.Parse(Console.ReadLine());

        //    Matrix(number);
        //}

        //static void Matrix(int number)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        for (int j = 0; j < number; j++)
        //        {
        //            Console.Write(number + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
