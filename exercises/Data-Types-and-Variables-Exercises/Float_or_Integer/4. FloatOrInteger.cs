using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if ((num % 1)<1)
            {
                Console.WriteLine(Math.Round(num));
            }
            else
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
