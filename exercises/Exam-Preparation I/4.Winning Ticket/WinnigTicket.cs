using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Winning_Ticket
{
    public class WinnigTicket
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            string ticketPattern = @"([$#@^])\1{5,}";
            Regex regex = new Regex(ticketPattern);
            string[] tickets = inputLine.Split(',').Select(x => x.Trim()).ToArray();
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftHalf = ticket.Substring(0, ticket.Length / 2);
                string rightHalf = ticket.Substring(ticket.Length / 2);
                var leftMatch = regex.Match(leftHalf);
                var rightMatch = regex.Match(rightHalf);
                if (leftMatch.Success && rightMatch.Success)
                {

                    int matchLength = Math.Min(leftMatch.Length, rightMatch.Length);
                    var winSymbol = leftMatch.Value[0];
                    string jackpot = string.Empty;
                    if (matchLength == 10)
                    {
                        //Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{leftMatch.Value[0]} Jackpot!");
                        jackpot = " Jackpot!";
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{winSymbol}{jackpot}");

                }
                else
                {
                    Console.WriteLine($"ticket \"{inputLine}\" - no match");
                }

            }

        }
    }
}
