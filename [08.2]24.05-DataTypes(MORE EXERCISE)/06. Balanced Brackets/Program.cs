using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int openBracket = 0;
            int closedBracked = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openBracket++;

                    if (openBracket - closedBracked > 1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                }
                else if (input == ")")
                {
                    closedBracked++;

                    if (openBracket - closedBracked != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (openBracket == closedBracked)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
        }
    }
}
