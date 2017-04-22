using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _3.Rage_Quit
{
    public class RageQuit
    {
        public static void Main()
        {
            string pattern = @"(\D+)(\d+)";
            string inputLine = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputLine);
            StringBuilder msg = new StringBuilder();
            foreach (Match match in matches)
            {
                string str = match.Groups[1].Value;
                int count = int.Parse(match.Groups[2].Value);
                msg.Append(RepeatString(str, count).ToUpper());
            }
            string result = msg.ToString();
            Console.WriteLine($"Unique symbols used: {result.Distinct().Count()}");
            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int count)
        {
            StringBuilder repeatedString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                repeatedString.Append(str);
            }
            return repeatedString.ToString();
        }
    }
}
