using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1.Replace_a_tag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            string text = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a></ li > </ ul >";
            string pattern = @"<a.*?href.*?=(.*)>(.*)<\/a>";
            string replace = @"[URL href=$1>$2[/URL]";
            Regex regex=new Regex(pattern);
            bool match = regex.IsMatch(text);
             var maches = regex.Matches(text);
            
            string replaced = Regex.Replace(text, pattern, replace);
            Console.WriteLine(replaced);

        }
    }
}
