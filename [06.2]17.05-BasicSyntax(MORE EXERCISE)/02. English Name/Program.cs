using System;

namespace _02._English_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = Math.Abs(n % 10);

            string result = LastDigitEnglish(lastDigit);
            Console.WriteLine(result);
        }

        static string LastDigitEnglish(int number)
        {

            string english = string.Empty;
            switch (number)
            {
                case 1: english = "one"; break;
                case 2: english = "two"; break;
                case 3: english = "three"; break;
                case 4: english = "four"; break;
                case 5: english = "five"; break;
                case 6: english = "six"; break;
                case 7: english = "seven"; break;
                case 8: english = "eight"; break;
                case 9: english = "nine"; break;
                case 0: english = "zero"; break;
                default:
                    break;
            }
            return english;
        }

        //Second solution, with help
        //static void Main(string[] args)
        //{
        //    long n = long.Parse(Console.ReadLine());

        //    LastDigitEnglish(n);

        //}

        //static void LastDigitEnglish(long num)
        //{
        //    long lastDigit = Math.Abs(num % 10);
        //    string english = string.Empty;

        //    switch (lastDigit)
        //    {
        //        case 1: english = "one"; break;
        //        case 2: english = "two"; break;
        //        case 3: english = "three"; break;
        //        case 4: english = "four"; break;
        //        case 5: english = "five"; break;
        //        case 6: english = "six"; break;
        //        case 7: english = "seven"; break;
        //        case 8: english = "eight"; break;
        //        case 9: english = "nine"; break;
        //        case 0: english = "zero"; break;
        //        default:
        //            break;
        //    }
        //    Console.WriteLine(english);
        //}

    }
}
