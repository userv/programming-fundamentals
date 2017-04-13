using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Cards
{
    public class Cards
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            string cardsPattern = @"([1]?[0-9JQAK])([SHDC])";
            Regex regex = new Regex(cardsPattern);
            MatchCollection matches = regex.Matches(inputLine);
            List<string> validCards = new List<string>();
            foreach (Match card in matches)
            {
                int power = 0;
                bool success = Int32.TryParse(card.Groups[1].Value, out power);
                if (success)
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                validCards.Add(card.Value);
            }
            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
