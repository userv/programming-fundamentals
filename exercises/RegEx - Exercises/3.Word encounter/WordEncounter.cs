using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Word_encounter
{
    public class WordEncounter
    {
        public static void Main(string[] args)
        {
            List<string> filteredWords = new List<string>();
            List<string> validSentences = new List<string>();
            string filter = Console.ReadLine();
            // string sentencePattern = @"^[A-Z][A-za-z].+[\.\?\!]";
            //  string sentencePattern = @"[A-Z][A-Za-z].+[\.|?|!]";
            string sentencePattern = @"(?<!.)[A-Z](.*)[.!?](?!.)";
            // string sentencePattern = @"[^.!?\s][^.!?]*(?:[.!?](?!['""]?\s|$)[^.!?]*)*[.!?]?['""]?(?=\s|$)";
            Regex regex = new Regex(sentencePattern);
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                MatchCollection macthes = regex.Matches(inputLine);
                foreach (Match sentence in macthes)
                {
                    validSentences.Add(sentence.Value);
                }
                inputLine = Console.ReadLine();
            }
            foreach (var sentence in validSentences)
            {
                char letter = filter[0];
                int n = int.Parse(filter[1].ToString());
                string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    int count = word.Where(x => x.Equals(letter)).Count();
                    if (count >= n)
                    {
                        filteredWords.Add(word);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", filteredWords));
        }
    }
}
