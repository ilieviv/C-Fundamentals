using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int fileIndex = input.LastIndexOf("\\") + 1;
            int dotINdex = input.LastIndexOf(".");

            string fileName = input.Substring(fileIndex, dotINdex - fileIndex);
            string extension = input.Substring(dotINdex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

            //var input = Console.ReadLine()
            //      .Split("\\")
            //      .ToArray();

            //  int arrLength =input.Length;

            //  string file = input[arrLength - 1];

            //  var nameAndEx = file.Split(".").ToArray();
            //  string fileName = nameAndEx[0];
            //  string extension = nameAndEx[1];

            //  Console.WriteLine($"File name: {fileName} {Environment.NewLine}File extension: {extension}");
        }
    }
}
