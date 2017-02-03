using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Base
{
    class IntegerBase
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number,toBase));


        }

        static string IntegerToBase(int num, int toBase)
        {
            string result = string.Empty;
            do
            {
                int  remainder = num%toBase;
                result = remainder.ToString() + result;
                num /= toBase;
             } while (num>0) ;
             return result;
        }
    }
}
