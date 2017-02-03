using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Nth_Digit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number,index));

        }

        static int FindNthDigit(int number, int index)
        {
            int digit = 0;
            for (int i = 1; i < index; i++)
            {
                if (index==1)
                {
                    return digit = number % 10;
                }
                number /= 10;
            }
            digit = number % 10;
            return digit;
        }
    }
}
