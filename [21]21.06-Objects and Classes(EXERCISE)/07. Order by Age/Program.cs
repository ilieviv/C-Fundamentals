using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name, id, age);

                persons.Add(person);

            }

            persons = persons
                .OrderBy(x => x.Age)
                .ToList();

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(string.Join(Environment.NewLine, person));
            //}

            persons.ForEach(x => Console.WriteLine(x));
        }
    }
}
