using System;
using System.Collections.Generic;


namespace Letter_Repetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<char,int> letters=new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!letters.ContainsKey(str[i]))
                {
                    letters[str[i]] = 0;
                }
                letters[str[i]]++;
            }
            foreach (var kvp in letters)
            {
                var letter = kvp.Key;
                var occurence = kvp.Value;
                Console.WriteLine($"{letter} -> {occurence}");

            }
        }
    }
}
