using System;
using System.Text.RegularExpressions;

namespace _4.Happiness_Index
{
    public class HappinessIndex
    {
        public static void Main()
        {
            string happyFacesPattern = @"[(\[:;*c][)|\]D}:;*)]";
            string sadFacesPattern = @"[:;D\]\)][(|\[{:;|c]";
            string inputLine = Console.ReadLine();
            Regex regexHappy = new Regex(happyFacesPattern);
            int happyEmoticonsCount = 0;
            int sadEmoticonsCount = 0;
            MatchCollection matchHappyCollection = regexHappy.Matches(inputLine);
            foreach (Match happyFaces in matchHappyCollection)
            {
                foreach (var emoticon in happyFaces.Groups)
                {
                    if (emoticon.ToString() != "**")
                    {
                        happyEmoticonsCount++;
                    }
                }
            }
            Regex regexSad = new Regex(sadFacesPattern);
            MatchCollection matchSadCollection = regexSad.Matches(inputLine);
            foreach (Match sadFaces in matchSadCollection)
            {
                foreach (var emoticon in sadFaces.Groups)
                {
                    sadEmoticonsCount++;
                }
            }

            double happinessIndex = happyEmoticonsCount / (double)sadEmoticonsCount;

            if (happinessIndex >= 2)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:F2} :D");
            }
            else if (happinessIndex < 2 && happinessIndex > 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:F2} :)");
            }
            else if (happinessIndex == 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:F2} :|");
            }
            else if (happinessIndex < 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:F2} :(");
            }
            Console.WriteLine($"[Happy count: {happyEmoticonsCount}, Sad count: {sadEmoticonsCount}]");
        }
    }
}
