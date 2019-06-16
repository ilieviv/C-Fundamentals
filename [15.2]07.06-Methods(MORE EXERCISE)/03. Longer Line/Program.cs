using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void LongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double secondLineLength = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));


            if (firstLineLength >= secondLineLength)
            {
                bool isFirstCloser = closerPointToCenter(x1, y1, x2, y2);
                if (isFirstCloser)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }

            }
            else
            {
                bool isFirstCloser = closerPointToCenter(x3, y3, x4, y4);
                if (isFirstCloser)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }

        }

        static bool closerPointToCenter(double x1, double y1, double x2, double y2)
        {
            double firstPointLine = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointLine = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            bool isFirstCloser = true;

            if (firstPointLine <= secondPointLine)
            {
                isFirstCloser = true;
            }
            else
            {
                isFirstCloser = false;
            }
            return isFirstCloser;
        }

    }
}
