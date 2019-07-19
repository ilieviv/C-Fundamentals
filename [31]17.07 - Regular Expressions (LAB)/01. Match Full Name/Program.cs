using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            Console.WriteLine(string.Join(" ", matchedNames));

            //foreach (Match name in matchedNames)
            //{
            //    Console.Write(name.Value + " ");
            //}
            //Console.WriteLine();
        }
    }
}
