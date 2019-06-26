using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> listOfSongs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split("_")
                    .ToList();

                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                listOfSongs.Add(song);
            }

            string desiredTypeList = Console.ReadLine();

            for (int i = 0; i < listOfSongs.Count; i++)
            {
                if (listOfSongs[i].TypeList == desiredTypeList)
                {
                    Console.WriteLine(listOfSongs[i].Name);
                }
                else if (desiredTypeList=="all")
                {
                    Console.WriteLine(listOfSongs[i].Name);
                }

            }
        }
    }
}


