using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> listOfArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                listOfArticles.Add(article);
            }

            string orderBy = Console.ReadLine();



            if (orderBy == "title")
            {
                var orderedListOfArticles = listOfArticles.OrderBy(x => x.Title);

                foreach (Article article in orderedListOfArticles)
                {
                    //Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    Console.WriteLine(article);
                }
            }
            else if (orderBy == "content")
            {
                var orderedListOfArticles = listOfArticles.OrderBy(x => x.Content);

                foreach (Article article in orderedListOfArticles)
                {
                    //Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    Console.WriteLine(article);
                }
            }
            else if (orderBy == "author")
            {
                var orderedListOfArticles = listOfArticles.OrderBy(x => x.Author);

                foreach (Article article in orderedListOfArticles)
                {
                    //Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    Console.WriteLine(article);
                }
            }



        }
    }
}
