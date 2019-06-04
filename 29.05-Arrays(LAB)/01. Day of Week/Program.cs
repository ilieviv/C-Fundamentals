

using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[7];

            weekDays[0] = "Monday";
            weekDays[1] = "Tuesday";
            weekDays[2] = "Wednesday";
            weekDays[3] = "Thursday";
            weekDays[4] = "Friday";
            weekDays[5] = "Saturday";
            weekDays[6] = "Sunday";

            //string[] weekDays =
            //{
            //"Invalid day!",
            //"Monday",
            //"Tuesday",
            //"Wednesday",
            //"Thursday",
            //"Friday",
            //"Saturday",
            //"Sunday"
            //};

            int n = int.Parse(Console.ReadLine());


            try
            {
                Console.WriteLine(weekDays[n-1]);

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid day!"); ;
            }
            
        }
    }
}
