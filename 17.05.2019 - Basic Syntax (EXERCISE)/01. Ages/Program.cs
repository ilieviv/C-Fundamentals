using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string agePerson = string.Empty;

            if (age <= 2)
            {
                agePerson = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                agePerson = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                agePerson = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                agePerson = "adult";
            }
            else if (age>=66)
            {
                agePerson = "elder";
            }

            Console.WriteLine(agePerson);
        }
    }
}
