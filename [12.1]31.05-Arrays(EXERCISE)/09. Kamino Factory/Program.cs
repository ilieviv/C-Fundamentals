using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = string.Empty;

            int[] lss = new int[sequenceLength];
            int lssLength = int.MinValue, lssIndex = int.MinValue, lssSum = int.MinValue, lssStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dnaSequence = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue;
                int currentIndex = int.MinValue;
                int currentSubLength = 0;
                int currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < sequenceLength; i++)
                {
                    if (dnaSequence[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (dnaSequence[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (dnaSequence[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if (currentLength > lssLength)
                {
                    lssLength = currentLength;
                    lssIndex = currentIndex;
                    lssSum = dnaSequence.Sum();
                    lss = dnaSequence;
                    lssStart = index;
                }
                else if (currentLength == lssLength)
                {
                    if (currentIndex < lssIndex)
                    {
                        lssLength = currentLength;
                        lssIndex = currentIndex;
                        lssSum = dnaSequence.Sum();
                        lss = dnaSequence;
                        lssStart = index;
                    }
                    else if (currentIndex == lssIndex)
                    {
                        if (dnaSequence.Sum() > lssSum)
                        {
                            lssLength = currentLength;
                            lssIndex = currentIndex;
                            lssSum = dnaSequence.Sum();
                            lss = dnaSequence;
                            lssStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {lssStart} with sum: {lssSum}.");
            Console.WriteLine(string.Join(" ", lss));
        }
    }
}

