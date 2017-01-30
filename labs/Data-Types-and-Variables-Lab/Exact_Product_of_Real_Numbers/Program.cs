using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal product=1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                decimal number=decimal.Parse(Console.ReadLine());
                product *= number;
            }
            Console.WriteLine(product);
        }
    }
}
