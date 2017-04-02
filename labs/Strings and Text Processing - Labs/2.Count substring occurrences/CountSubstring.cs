using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_substring_occurrences
{
    public class CountSubstring
    {
        public static void Main()
        {
            string inputString = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int count = 0;
            int index = inputString.IndexOf(pattern);
            while (index!=-1)
            {
                count++;
                index = inputString.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
