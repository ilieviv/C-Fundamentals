using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if (input[0] == "register")
                {
                    string user = input[1];
                    string plate = input[2];

                    if (!parking.ContainsKey(user))
                    {
                        parking.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }
                else
                {
                    string user = input[1];


                    if (!parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    parking.Remove(user);
                }
            }

            foreach (var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
