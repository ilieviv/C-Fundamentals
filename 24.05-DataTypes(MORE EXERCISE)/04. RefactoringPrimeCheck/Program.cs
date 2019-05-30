using System;

namespace _04._RefactoringPrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int start = 2; start <= input; start++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < start; divider++)
                {
                    if (start % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string primeNotPrime = isPrime.ToString().ToLower();
                Console.WriteLine("{0} -> {1}", start, primeNotPrime);
            }

        }
    }
}
