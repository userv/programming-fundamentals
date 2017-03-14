using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Short_Words_Sorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            char[] separators = new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = Console.ReadLine().ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
