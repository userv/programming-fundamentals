using System;
using System.Collections.Generic;

namespace _5.Capitalize_Words
{
    public class CapitalizeWords
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            while (sentence != "end")
            {
                PrintCapitalizedWords(sentence);
                sentence = Console.ReadLine();
            }
        }
        public static void PrintCapitalizedWords(string sentence)
        {
            string[] words = sentence.ToLower().Split(new char[] { ' ', ',', '.', '?', '!', '"', ':', ';','-' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> capitalizedWords = new List<string>();
            foreach (var word in words)
            {
                capitalizedWords.Add(char.ToUpper(word[0]) + word.Substring(1));
            }
            Console.WriteLine(string.Join(", ", capitalizedWords));

        }
    }
}
