using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = "";
            for (int i = 0; i < n; i++)
            {
                char ch = (char) int.Parse(Console.ReadLine());
                str += ch;
            }
            Console.WriteLine(str);
        }
    }
}
