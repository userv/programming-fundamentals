using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger bigInt = 1;
            for (int i = n; i > 1; i--)
            {
                bigInt *= i;
            }
            Console.WriteLine(bigInt);
        }


    }
}
