using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_Format
{
    class HexadecimalFormat
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(str,16));
        }
    }
}
