using System;
using System.Text;

namespace _Demo__String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string sb = string.Empty;

            while (input != "End")
            {
                string[] splittedInput = input.Split(" ");

                string command = splittedInput[0];


                if (input == "Print")
                {
                    Console.WriteLine(sb);
                    input = Console.ReadLine();
                    continue;
                }

                string operation = splittedInput[1];

                switch (command)
                {
                    case "Add": sb += operation; break;
                    case "Upgrade":
                        char newC = operation[0];
                        sb = sb.Replace(newC, (char)(newC + 1)); break;
                    case "Print": Console.WriteLine(sb); break;
                    case "Index":
                        char sym = char.Parse(splittedInput[1]);

                        int counter = 0;

                        for (int i = 0; i < sb.Length; i++)
                        {
                            char currentSymbol = sb[i];

                            if (currentSymbol == sym)
                            {
                                Console.Write(i + " ");
                                counter++;
                            }
                        }

                        if (counter == 0)
                        {
                            Console.WriteLine("None");
                        }
                        Console.WriteLine();
                        break;
                    case "Remove":
                        sb = sb.Replace(operation, "");
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
