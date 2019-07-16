using System;
using System.Text;
using System.Diagnostics;
using System.Linq;


namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            bool print = true;

            foreach (var username in usernames)
            {
                bool length = username.Length >= 3 && username.Length <= 16;

                foreach (var ch in username)
                {
                    bool symb = ch == 95 || ch == 45;
                    if (!char.IsLetterOrDigit(ch) && !symb)
                    {
                        print = false;
                        break;
                    }
                }
                if (print && length)
                {
                    Console.WriteLine(username);
                }
                print = true;
            }
        }

        //bool print = true;
        //foreach (var username in usernames)
        //{
        //    foreach (char ch in username)
        //    {

        //        bool chars = ch >= 48 && ch <= 57 || ch >= 65 && ch <= 90 || ch >= 48 && ch <= 57 || ch >= 97 && ch <= 122 || ch == 95 || ch == 45;

        //        if (!chars)
        //        {
        //            print = false;
        //            break;
        //        }
        //    }

        //    bool length = username.Length >= 3 && username.Length <= 16;
        //    if (length && print)
        //    {
        //        Console.WriteLine(username);
        //    }
        //    print = true;
        //}
    }
}

