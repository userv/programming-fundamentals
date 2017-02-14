using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_3_Consecutive_Equal_Strings
{
    public class Last3ConsecutiveEqualStrings
    {
        public static void Main(string[] args)
        {
            string[] stringsArray = Console.ReadLine().Split(' ').ToArray();
            int count = 1;
            for (int i = stringsArray.Length - 1; i > 0; i--)
            {
                if (stringsArray[i] == stringsArray[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count == 3)
                {
                    Console.WriteLine("{0} {0} {0}", stringsArray[i]);
                    return;
                }
            }
        }
    }
}
