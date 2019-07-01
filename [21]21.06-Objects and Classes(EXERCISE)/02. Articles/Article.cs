using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public static string Edit(string oldContent)
        {
            return oldContent;
        }

        public static string ChangeAuthor(string newAuthor)
        {
            return newAuthor;
        }
        public static string Rename(string renameTitle)
        {
            return renameTitle;
        }

        public static void Print(string title, string content, string author)
        {
            Console.WriteLine($"{title} - {content}: {author}");
        }


        public override string ToString()
        {
            return Title + "-" + Content + ":" + Author;
        }
    }
}
