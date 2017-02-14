using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Negative_Elements_in_Array
{
    class CountNegativeElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int negativeElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                {
                    negativeElements++;
                }
            }
            Console.WriteLine(negativeElements);

        }
    }
}
