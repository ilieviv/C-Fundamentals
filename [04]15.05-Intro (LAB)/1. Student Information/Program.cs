using System;

namespace _1._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            string output = String.Format($"Name: {name}, Age: {age}, Grade: {grade:f2}");

            Console.WriteLine(output);
        }
    }
}
