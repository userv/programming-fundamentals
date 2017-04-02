using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine()
                .Split(new char[] {' ', ',', '.', '?', '!','"'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes=new List<string>();
            foreach (var word in inputString)
            {
                string  reversedWord= new string(word.Reverse().ToArray());
                if (word==reversedWord)
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",palindromes.OrderBy(n => n).Distinct()));
        }
    }
}
