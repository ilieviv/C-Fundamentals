using System;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] split = Regex.Split(Console.ReadLine(), @"\s*,\s*");

            Regex winningTicket = new Regex(@"[@]{6,}|[#]{6,}|[$]{6,}|[\^]{6,}");
            Regex jackpot = new Regex(@"[@]{20}|[#]{20}|[$]{20}|[\^]{20}");

            foreach (var ticket in split)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                if (jackpot.IsMatch(ticket))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - ");
                }

               
            }


        }
    }
}
