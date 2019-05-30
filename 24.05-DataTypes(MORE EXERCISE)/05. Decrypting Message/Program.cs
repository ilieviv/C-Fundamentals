using System;
using System.Collections.Generic;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                message += (char)(char.Parse(Console.ReadLine()) + key);
            }
            Console.WriteLine(message);
        }
    }
}
