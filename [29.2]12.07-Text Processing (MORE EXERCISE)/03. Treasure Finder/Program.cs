using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().Split(" ").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                string output = string.Empty;

                if (input == "find")
                {
                    break;
                }

                int counter = 0;

                foreach (char ch in input)
                {
                    if (counter == key.Count)
                    {
                        counter = 0;
                    }
                    int currentKey = int.Parse(key[counter]);

                    char c = (char)(ch - currentKey);
                    output += c.ToString();

                    counter++;
                }

                int typeFirstIndex = output.IndexOf('&');
                int typeLastIndex = output.LastIndexOf('&');

                int coordinatesFirstIndex = output.IndexOf('<');
                int coordinatesLastIndex = output.IndexOf('>');

                string decodedType = output.Substring(typeFirstIndex + 1, typeLastIndex - typeFirstIndex - 1);
                string decodedCoordinates = output.Substring(coordinatesFirstIndex + 1, coordinatesLastIndex - coordinatesFirstIndex - 1);

                Console.WriteLine($"Found {decodedType} at {decodedCoordinates}");
            }
        }
    }
}
