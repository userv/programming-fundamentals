using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] delimeters = new char[] { ',', '\'', ':', ';', '.', '!', '(', ')', '\"', '\\', '/', '[', ']', ' ' };
            List<string> stringsList = Console.ReadLine()
                .Split(delimeters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            for (int i = 0; i < stringsList.Count; i++)
            {
                if (IsLowerCaseWord(stringsList[i]))
                {
                    lowerCaseWords.Add(stringsList[i]);
                }
                else if (IsUpperCaseWord(stringsList[i]))
                {
                    upperCaseWords.Add(stringsList[i]);
                }
                else
                {
                    mixedCaseWords.Add(stringsList[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }

        public static bool IsLowerCaseWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLower(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsUpperCaseWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsUpper(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
