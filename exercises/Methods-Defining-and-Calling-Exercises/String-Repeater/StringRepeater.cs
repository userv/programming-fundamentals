using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str,n));

        }

        static string RepeatString(string str, int n)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                repeatedString += str;
            }
            return repeatedString;
        }
    }
}
