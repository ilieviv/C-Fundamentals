using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int counterFail = 0;

            string reversedUsername = string.Empty;

            for (int i = username.Length; i > 0; i--)
            {
                reversedUsername += username[i - 1].ToString();
            }

            while (reversedUsername != password && counterFail < 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                counterFail++;
                
            }

            if (counterFail >= 3)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
