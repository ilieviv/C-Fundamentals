using System;

namespace String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(" ");

                string command = splittedInput[0];

                if (command == "Translate")
                {
                    char ch1 = char.Parse(splittedInput[1]);
                    char ch2 = char.Parse(splittedInput[2]);

                    text = text.Replace(ch1, ch2);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string str = splittedInput[1];
                    int isThere = text.IndexOf(str);
                    if (isThere < 0)
                    {
                        Console.WriteLine("False");
                    }
                    else
                    {
                        Console.WriteLine("True");
                    }
                }
                else if (command == "Start")
                {
                    string str = splittedInput[1];
                    if (text.IndexOf(str, 0) == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char ch = char.Parse(splittedInput[1]);
                    int index = text.LastIndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int count = int.Parse(splittedInput[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                input = Console.ReadLine();
            }


        }
    }
}
