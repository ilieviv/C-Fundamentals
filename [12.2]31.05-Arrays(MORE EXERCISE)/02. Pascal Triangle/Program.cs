using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (n == 1)
            {
                return;
            }

            int[] startArr = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", startArr));

            if (n == 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < startArr.Length + 1; i++)
                {
                    int[] arr = new int[startArr.Length + 1];
                    arr[0] = 1;
                    arr[arr.Length - 1] = 1;

                    for (int j = 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = startArr[j - 1] + startArr[j];
                    }
                    Console.WriteLine(string.Join(" ", arr));

                    startArr = arr;

                    if (startArr.Length == n)
                    {
                        break;
                    }
                }
            }   
        }
    }
}
