using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalSabreSum = (Math.Ceiling(students * 1.1)) * sabrePrice; //maybe problem with ceiling
            double totalRobeSum = students * robePrice;
            double totalBeltSum = (students - (students / 6)) * beltPrice;

            double totalSum = totalSabreSum + totalRobeSum + totalBeltSum;

            if (totalSum<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money-totalSum):f2}lv more.");
            }
        }
    }
}
