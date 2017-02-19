using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    public class SortNumbers
    {
       public static void Main()
       {
           List<decimal> numbersDecimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbersDecimals.Sort();
           for (int i = 0; i < numbersDecimals.Count; i++)
           {
               if (i==numbersDecimals.Count-1)
               {
                    Console.Write(numbersDecimals[i]);
                }
               else
               {
                    Console.Write(numbersDecimals[i] + " <= ");
                    
                }
           }
           Console.WriteLine();
       }
    }
}
