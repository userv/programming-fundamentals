using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Terabytes_To_Bits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            double numTerabytes = double.Parse(Console.ReadLine());
            decimal bits = (decimal) (Math.Pow(1024, 4) * 8 * numTerabytes);
            Console.WriteLine(bits);

        }
    }
}
