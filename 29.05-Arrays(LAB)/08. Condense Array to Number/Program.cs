using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            while (mainArray.Length > 1)
            {
                int[] newArr = new int[mainArray.Length - 1];
                for (int i = 0; i < mainArray.Length - 1; i++)
                {
                    newArr[i] = mainArray[i] + mainArray[i + 1];
                }
                mainArray = newArr;
            }
            Console.WriteLine(mainArray[0]);

        }
    }
}
