using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    input[1] = Article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    input[2] = Article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    input[0] = Article.Rename(command[1]);
                }

                
            }
            Article.Print(input[0], input[1], input[2]);

        }
    }
}
