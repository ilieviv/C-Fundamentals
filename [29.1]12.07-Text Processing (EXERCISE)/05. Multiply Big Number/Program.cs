using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            int lengthOfFrist = first.Length;
            StringBuilder str = new StringBuilder();
            int onMind = 0;

            for (int i = lengthOfFrist - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(first[i].ToString());

                int result = lastDigit * second + onMind;

                str.Append(result % 10);

                onMind = result / 10;
            }

            if (onMind != 0)
            {
                str.Append(onMind);
            }

            string resultNumber = string.Join("", str.ToString().Reverse()).TrimStart('0');

            if (resultNumber == string.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {

                Console.WriteLine(resultNumber);
            }
        }
    }
}
