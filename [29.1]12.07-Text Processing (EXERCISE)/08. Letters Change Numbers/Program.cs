using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            double total = 0;

            for (int i = 0; i < input.Count; i++)
            {
                string currentWord = input[i];
                int len = currentWord.Length;

                char firstLetter = currentWord[0];
                char lastLetter = currentWord[len - 1];

                currentWord = currentWord.Remove(0, 1);
                currentWord = currentWord.Remove(len - 2, 1);

                int number = int.Parse(currentWord);
                double firstResult = 0;
                double secondResult = 0;


                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    firstResult = number / ((double)firstLetter - 64);
                }
                else if (firstLetter >= 97 && firstLetter <= 122)
                {
                    firstResult = number * ((double)firstLetter - 96);
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    secondResult = firstResult - ((double)lastLetter - 64);
                }
                else if (lastLetter >= 97 && lastLetter <= 122)
                {
                    secondResult = firstResult + ((int)lastLetter - 96);
                }

                double result = firstResult + secondResult;

                total += secondResult;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
