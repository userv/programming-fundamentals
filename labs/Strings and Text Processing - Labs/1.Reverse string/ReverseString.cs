using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_string
{
    public class ReverseString
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
