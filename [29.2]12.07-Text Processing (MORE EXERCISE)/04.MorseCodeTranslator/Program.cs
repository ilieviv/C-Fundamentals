using System;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case ".-": output.Append('A'); break;
                    case "-...": output.Append('B'); break;
                    case "-.-.": output.Append('C'); break;
                    case "-..": output.Append('D'); break;
                    case ".": output.Append('E'); break;
                    case "..-.": output.Append('F'); break;
                    case "--.": output.Append('G'); break;
                    case "....": output.Append('H'); break;
                    case "..": output.Append('I'); break;
                    case ".---": output.Append('J'); break;
                    case "-.-": output.Append('K'); break;
                    case ".-..": output.Append('L'); break;
                    case "--": output.Append('M'); break;
                    case "-.": output.Append('N'); break;
                    case "---": output.Append('O'); break;
                    case ".--.": output.Append('P'); break;
                    case "--.-": output.Append('Q'); break;
                    case ".-.": output.Append('R'); break;
                    case "...": output.Append('S'); break;
                    case "-": output.Append('T'); break;
                    case "..-": output.Append('U'); break;
                    case "...-": output.Append('V'); break;
                    case ".--": output.Append('W'); break;
                    case "-..-": output.Append('X'); break;
                    case "-.--": output.Append('Y'); break;
                    case "--..": output.Append('Z'); break;
                    case "|": output.Append(' '); break;
                    default:
                        break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
