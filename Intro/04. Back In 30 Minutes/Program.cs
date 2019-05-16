using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes + 30;
            int newHour = totalMinutes / 60;
            int newMinutes = totalMinutes % 60;

            if (newHour == 24)
            {
                newHour = 0;
            }

            string output = string.Format($"{newHour}:{newMinutes:d2}");

            Console.WriteLine(output);
        }
    }
}
