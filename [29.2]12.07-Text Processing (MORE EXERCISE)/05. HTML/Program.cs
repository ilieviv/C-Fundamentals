using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            var commentsList = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }

                commentsList.Add(input); 
            }

            Console.WriteLine($"<h1>{Environment.NewLine}    {title}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}    {content}{Environment.NewLine}</article>");

            for (int i = 0; i < commentsList.Count; i++)
            {
                Console.WriteLine($"<div>{Environment.NewLine}    {commentsList[i]}{Environment.NewLine}</div>");
            }
        }
    }
}
