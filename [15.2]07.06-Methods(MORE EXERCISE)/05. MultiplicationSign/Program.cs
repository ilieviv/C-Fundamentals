using System;

namespace _05._MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string result = Product(num1, num2, num3);
            Console.WriteLine(result);

        }

        static string Product(int num1, int num2, int num3)
        {
            int counterNegative = 0;
            string product = string.Empty;

                if (num1 < 0)
                {
                    counterNegative++;
                }
                if (num2 < 0)
                {
                    counterNegative++;
                }
                if (num3 < 0)
                {
                    counterNegative++;
                }

            if (counterNegative==1 || counterNegative==3)
            {
                product = "negative";
            }
            else
            {
                product = "positive";
            }

            if (num1==0 ||num2==0||num3==0)
            {
                product = "zero";
            }

            return product;
        }
    }
}
