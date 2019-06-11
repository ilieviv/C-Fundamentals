using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            string typePerson = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double price = 0;
            double sum = 0;

            if (weekDay == "Friday")
            {
                switch (typePerson)
                {
                    case "Students": price = 8.45; break;
                    case "Business": price = 10.9; break;
                    case "Regular": price = 15; break;
                    default:
                        break;
                }
            }
            else if (weekDay == "Saturday")
            {
                switch (typePerson)
                {
                    case "Students": price = 9.8; break;
                    case "Business": price = 15.6; break;
                    case "Regular": price = 20; break;
                    default:
                        break;
                }
            }
            else if (weekDay == "Sunday")
            {
                switch (typePerson)
                {
                    case "Students": price = 10.46; break;
                    case "Business": price = 16; break;
                    case "Regular": price = 22.5; break;
                    default:
                        break;
                }
            }

            sum = numberOfPersons * price;

            if (typePerson == "Students" && numberOfPersons >= 30)
            {
                sum -= (sum * 0.15);
            }
            if (typePerson == "Business" && numberOfPersons >= 100)
            {
                sum -= (10 * price);
            }
            if (typePerson == "Regular" && numberOfPersons >= 10 && numberOfPersons <= 20)
            {
                sum -= (sum * 0.05);
            }

            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
