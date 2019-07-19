using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\+359)( |-)2\2\d{3}\2\d{4}\b";

            var phones = Console.ReadLine();

            MatchCollection validPhones = Regex.Matches(phones, regex);


            Console.WriteLine(string.Join(", ", validPhones));

        }
    }
}
