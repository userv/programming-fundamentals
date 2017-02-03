using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smallestNumber=GetMin(num1,num2);
            smallestNumber = GetMin(smallestNumber, num3);
            Console.WriteLine(smallestNumber);

        }

        static int GetMin(int a, int b)
        {
            if (a<b)
            {
                return a;
            }
            return b;
        }
    }
}
