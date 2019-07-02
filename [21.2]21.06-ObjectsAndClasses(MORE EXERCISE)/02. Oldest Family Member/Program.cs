using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string name = input[0];
                int age = int.Parse(input[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
