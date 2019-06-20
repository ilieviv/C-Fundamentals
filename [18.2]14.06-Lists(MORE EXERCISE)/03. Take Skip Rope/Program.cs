using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbersList = new List<int>();
            var charList = new List<char>();

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    int num = int.Parse(symbol.ToString());
                    numbersList.Add(num);
                }
                else
                {
                    charList.Add(symbol);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            string result = null;
            int total = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int skipCount = skipList[i];
                int takeCount = takeList[i];

                result += new string(charList.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }

            Console.WriteLine(result);
        }
    }
}
