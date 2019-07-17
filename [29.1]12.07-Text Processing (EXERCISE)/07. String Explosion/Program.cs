using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var splittedInput = input.Split(">");

            string result = splittedInput[0];
            int remainingPower = 0;

            for (int i = 1; i < splittedInput.Length; i++)
            {
                result += ">";

                int power = int.Parse(splittedInput[i][0].ToString()) + remainingPower;

                if (power > splittedInput[i].Length)
                {
                    remainingPower = power - splittedInput[i].Length;
                }
                else
                {
                    result += splittedInput[i].Substring(power);
                }
            }

            Console.WriteLine(result);
        }

    }
}
